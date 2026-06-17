#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

# OpenAPI spec: https://backend.composio.dev/api/v3/openapi.json
install_autosdk_cli
rm -rf Generated
fetch_spec --fail --silent --show-error -L -o openapi.json https://backend.composio.dev/api/v3/openapi.json

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

rm -rf ../../cli/Composio.CLI

autosdk cli-project openapi.json \
  --output ../../cli/Composio.CLI \
  --sdk-project ../../libs/Composio/Composio.csproj \
  --targetFramework net10.0 \
  --namespace Composio \
  --clientClassName ComposioClient \
  --package-id Composio.CLI \
  --tool-command-name composio \
  --user-secrets-id Composio.CLI \
  --api-key-env-var COMPOSIO_API_KEY \
  --base-url-env-var COMPOSIO_BASE_URL \
  --cli-credential-file \
  --cli-keep-api-group \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
