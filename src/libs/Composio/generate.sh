dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.json https://backend.composio.dev/api/v3/openapi.json

# Fix auth: convert apiKey header auth to http/bearer and add top-level security
# Fix connection_data: replace 74-variant anyOf with generic object to avoid CS7013 metadata length limit
jq '
  .components.securitySchemes.ApiKeyAuth = {"type": "http", "scheme": "bearer"} |
  del(.components.securitySchemes.UserApiKeyAuth) |
  del(.components.securitySchemes.CookieAuth) |
  del(.components.securitySchemes.OrgApiKeyAuth) |
  .security = [{"ApiKeyAuth": []}] |
  (.paths["/api/v3/connected_accounts/link"].post.requestBody.content["application/json"].schema.properties.connection_data) = {"type": "object", "description": "Connection data for the linked account (provider-specific key-value pairs)"}
' openapi.json > fixed.json && mv fixed.json openapi.json

autosdk generate openapi.json \
  --namespace Composio \
  --clientClassName ComposioClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
