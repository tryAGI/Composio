# Authentication

The Composio API uses Bearer token authentication.

## Getting an API Key

1. Sign up at [composio.dev](https://composio.dev/)
2. Navigate to your dashboard settings
3. Create a new API key

## Client Initialization

```csharp
using Composio;

var client = new ComposioClient(
    apiKey: Environment.GetEnvironmentVariable("COMPOSIO_API_KEY")!);
```

## Environment Variables

For integration tests, set the following environment variable:

```bash
export COMPOSIO_API_KEY=your-api-key-here
```
