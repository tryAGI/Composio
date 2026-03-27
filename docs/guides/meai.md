# Microsoft.Extensions.AI Integration

Composio provides `AIFunction` tools compatible with
[Microsoft.Extensions.AI](https://www.nuget.org/packages/Microsoft.Extensions.AI),
allowing any `IChatClient` to execute 250+ integrations, list tools, and manage connected accounts.

## Available Tools

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsExecuteToolTool()` | `ExecuteComposioTool` | Executes any Composio tool by slug with arguments or natural language. |
| `AsListToolsTool()` | `ListComposioTools` | Lists available tools with optional toolkit/search filtering. |
| `AsListToolkitsTool()` | `ListComposioToolkits` | Lists available integrations (GitHub, Gmail, Slack, etc.). |
| `AsListConnectedAccountsTool()` | `ListConnectedAccounts` | Lists authenticated user connections to external services. |

## Usage

```csharp
using Composio;
using Microsoft.Extensions.AI;

var composio = new ComposioClient(apiKey);

// Create tools
var tools = new[]
{
    composio.AsExecuteToolTool(),
    composio.AsListToolsTool(),
    composio.AsListToolkitsTool(),
    composio.AsListConnectedAccountsTool(),
};

// Use with any IChatClient
var response = await chatClient.GetResponseAsync(
    "List available GitHub tools and execute one to list my repositories",
    new ChatOptions { Tools = tools });
```

## Tool Details

### ExecuteComposioTool

Executes a specific tool by its slug (e.g., `github-actions`, `gmail-send-email`).
Accepts either structured JSON arguments or a natural language text description.
Requires a `connectedAccountId` for authenticated tools.

```csharp
var tool = composio.AsExecuteToolTool();
```

### ListComposioTools

Lists available tools with optional filtering by toolkit slug or search query.
Returns tool slugs, names, descriptions, and authentication requirements.

```csharp
var tool = composio.AsListToolsTool();
```

### ListComposioToolkits

Lists available integrations (toolkits) like GitHub, Gmail, Slack.
Optionally filter by search query or category.

### ListConnectedAccounts

Lists all authenticated integration accounts for the current project.
Returns account IDs needed for executing tools.
