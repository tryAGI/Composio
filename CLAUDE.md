# CLAUDE.md — Composio SDK

## Overview

Auto-generated C# SDK for [Composio](https://composio.dev/) — AI agent integration platform with 250+ tools including GitHub, Gmail, Slack, and more.
OpenAPI spec from `https://backend.composio.dev/api/v3/openapi.json`.

## Build & Test

```bash
dotnet build Composio.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth (API key from Composio dashboard):

```csharp
var client = new ComposioClient(apiKey); // COMPOSIO_API_KEY env var
```

## Key Files

- `src/libs/Composio/openapi.json` — OpenAPI spec (downloaded from backend.composio.dev)
- `src/libs/Composio/generate.sh` — Downloads spec, fixes auth scheme, runs autosdk
- `src/libs/Composio/Generated/` — **Never edit** — auto-generated code
- `src/libs/Composio/Extensions/ComposioClient.AsTool.cs` — MEAI AIFunction tools
- `src/tests/IntegrationTests/Tests.cs` — Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` — Example tests (also generate docs)

## Sub-Clients

The generated client uses sub-client accessors:

- `client.Tools.*` — Tool execution and listing
- `client.Toolkits.*` — Integration/toolkit management
- `client.ConnectedAccounts.*` — Connected account management
- `client.Triggers.*` — Trigger management
- `client.AuthConfigs.*` — Auth configuration
- `client.Projects.*` — Project management
- `client.Mcp.*` — MCP server management

## Spec Fixes

The `generate.sh` applies these fixes:
- Converts `apiKey` header auth → `http/bearer` and adds top-level `security` array
- Removes extra security schemes (`UserApiKeyAuth`, `CookieAuth`, `OrgApiKeyAuth`)
- Replaces 74-variant `anyOf` on `connection_data` with generic `object` to avoid CS7013 metadata length limit
