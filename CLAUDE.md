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

The `generate.sh` applies these fixes via `jq` (pre-generation) and `sed` (post-generation):

**Pre-generation (`jq`):**
1. **connection_data simplification:** Replaces 74-variant `anyOf` on `/api/v3/connected_accounts/link` `connection_data` with generic `object` to avoid CS7013 metadata length limit
2. **Deprecated parameter dedup:** Removes deprecated camelCase query params from `GET /api/v3/trigger_instances/active` — spec has both snake_case (current) and camelCase (deprecated) versions that normalize to identical C# names, causing CS0100

**Auth:** `--security-scheme Http:Header:Bearer` overrides the spec's apiKey auth at generation time (no jq auth patching needed).

**Post-generation (`sed`):**
3. **CS0618 pragma suppression:** Adds `#pragma warning disable CS0618` to 7 generated files where non-deprecated models reference `[Obsolete]`-marked types

Uses `--exclude-deprecated-operations` flag.
