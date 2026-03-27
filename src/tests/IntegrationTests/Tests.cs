namespace Composio.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static ComposioClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("COMPOSIO_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("COMPOSIO_API_KEY environment variable is not found.");

        var client = new ComposioClient(apiKey);
        
        return client;
    }
}
