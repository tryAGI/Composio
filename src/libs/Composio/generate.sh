#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://backend.composio.dev/api/v3/openapi.json

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -L -o openapi.json https://backend.composio.dev/api/v3/openapi.json

# Fix 1: Replace 74-variant anyOf on connection_data with generic object to avoid CS7013 metadata length limit.
# Fix 2: Remove deprecated duplicate query params on /api/v3/trigger_instances/active
#         (snake_case + deprecated camelCase normalize to same C# name, causing CS0100).
jq '
  # Fix 1: connection_data simplification
  (.paths["/api/v3/connected_accounts/link"].post.requestBody.content["application/json"].schema.properties.connection_data) = {"type": "object", "description": "Connection data for the linked account (provider-specific key-value pairs)"} |

  # Fix 2: deprecated parameter dedup
  (.paths["/api/v3/trigger_instances/active"].get.parameters) |= [.[] | select(.deprecated != true)]
' openapi.json > fixed.json && mv fixed.json openapi.json

# Auth: --security-scheme overrides the spec's apiKey auth with standard HTTP bearer.
autosdk generate openapi.json \
  --namespace Composio \
  --clientClassName ComposioClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer

# Fix 3: CS0618 pragma suppression — generated code references [Obsolete] types from
#         non-deprecated parent models. Insert #pragma warning disable CS0618.
CS0618_FILES=(
  "Composio.Models.GetMcpAppByAppKeyResponseItem.g.cs"
  "Composio.Models.GetMcpByIdResponse.g.cs"
  "Composio.Models.PostMcpServersResponse.g.cs"
  "Composio.Models.PatchMcpByIdResponse.g.cs"
  "Composio.Models.GetMcpServersResponseItem.g.cs"
  "Composio.Models.PostToolkitsMultiResponseItem.g.cs"
  "Composio.Models.GetToolkitsResponseItem.g.cs"
)
for file in "${CS0618_FILES[@]}"; do
  filepath="Generated/$file"
  if [ -f "$filepath" ]; then
    sed -i '' '1s/^/#pragma warning disable CS0618\n/' "$filepath"
  fi
done
