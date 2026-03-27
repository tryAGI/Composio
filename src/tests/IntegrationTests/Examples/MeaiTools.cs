/* order: 10, title: MEAI Tools, slug: meai-tools */

using Microsoft.Extensions.AI;

namespace Composio.IntegrationTests;

public partial class Tests
{
    //// Composio provides AIFunction tools that can be used with any
    //// `Microsoft.Extensions.AI.IChatClient` to give AI agents access to
    //// 250+ integrations including GitHub, Gmail, Slack, and more.

    [TestMethod]
    public async Task Meai_AsExecuteToolTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool that executes any Composio tool by slug:
        var tool = client.AsExecuteToolTool();

        tool.Name.Should().Be("ExecuteComposioTool");
        tool.Description.Should().Contain("Composio tool");
    }

    [TestMethod]
    public async Task Meai_AsListToolsTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool that lists available tools:
        var tool = client.AsListToolsTool();

        tool.Name.Should().Be("ListComposioTools");
        tool.Description.Should().Contain("tools");

        //// The tool returns available tools with names, descriptions, and slugs.
        var result = await tool.InvokeAsync(
            new AIFunctionArguments
            {
                ["toolkitSlug"] = null,
                ["search"] = null,
            },
            cancellationToken: CancellationToken.None);

        result.Should().NotBeNull();
        Console.WriteLine($"ListTools result: {result}");
    }

    [TestMethod]
    public async Task Meai_AsListToolkitsTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool that lists available integrations:
        var tool = client.AsListToolkitsTool();

        tool.Name.Should().Be("ListComposioToolkits");
        tool.Description.Should().Contain("toolkit");

        //// The tool returns toolkits like GitHub, Gmail, Slack with auth info.
        var result = await tool.InvokeAsync(
            new AIFunctionArguments
            {
                ["search"] = null,
                ["category"] = null,
            },
            cancellationToken: CancellationToken.None);

        result.Should().NotBeNull();
        Console.WriteLine($"ListToolkits result: {result}");
    }

    [TestMethod]
    public async Task Meai_AsListConnectedAccountsTool()
    {
        using var client = GetAuthenticatedClient();

        //// Create a tool that lists connected accounts:
        var tool = client.AsListConnectedAccountsTool();

        tool.Name.Should().Be("ListConnectedAccounts");
        tool.Description.Should().Contain("connected");

        //// The tool returns authenticated integration accounts.
        var result = await tool.InvokeAsync(
            cancellationToken: CancellationToken.None);

        result.Should().NotBeNull();
        Console.WriteLine($"ListConnectedAccounts result: {result}");
    }
}
