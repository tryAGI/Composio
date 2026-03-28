dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.json https://backend.composio.dev/api/v3/openapi.json

# Fix auth: convert apiKey header auth to http/bearer and add top-level security
# Fix connection_data: replace 74-variant anyOf with generic object to avoid CS7013 metadata length limit
# Fix CS0100: remove deprecated duplicate query parameters on /api/v3/trigger_instances/active
#   The spec has both snake_case (non-deprecated) and camelCase (deprecated) versions of the same params.
#   AutoSDK normalizes both to the same C# parameter name, causing CS0100 duplicate parameter errors.
jq '
  .components.securitySchemes.ApiKeyAuth = {"type": "http", "scheme": "bearer"} |
  del(.components.securitySchemes.UserApiKeyAuth) |
  del(.components.securitySchemes.CookieAuth) |
  del(.components.securitySchemes.OrgApiKeyAuth) |
  .security = [{"ApiKeyAuth": []}] |
  (.paths["/api/v3/connected_accounts/link"].post.requestBody.content["application/json"].schema.properties.connection_data) = {"type": "object", "description": "Connection data for the linked account (provider-specific key-value pairs)"} |
  (.paths["/api/v3/trigger_instances/active"].get.parameters) |= [.[] | select(.deprecated != true)]
' openapi.json > fixed.json && mv fixed.json openapi.json

autosdk generate openapi.json \
  --namespace Composio \
  --clientClassName ComposioClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations

# Fix CS0618: generated code references [Obsolete] types from non-deprecated parent models.
# AutoSDK marks deprecated schemas with [Obsolete], but non-deprecated models that reference them
# produce CS0618 errors. Insert #pragma warning disable CS0618 at the top of affected files.
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
