#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class McpGetMcpAppByAppKeyCommandApiCommand
{
    private static Argument<string> AppKey { get; } = new(
        name: @"app-key")
    {
        Description = @"The key of the app to find MCP servers for",
    };

    private static Option<string?> NameOption { get; } = new(
        name: @"--name")
    {
        Description = @"Filter MCP servers by name (case-insensitive partial match)",
    };

    private static Option<string?> Toolkits { get; } = new(
        name: @"--toolkits")
    {
        Description = @"Comma-separated list of toolkit slugs to filter servers by",
    };

    private static Option<string?> AuthConfigIds { get; } = new(
        name: @"--auth-config-ids")
    {
        Description = @"Comma-separated list of auth config IDs to filter servers by",
    };

    private static Option<global::Composio.GetMcpAppByAppKeyOrderBy?> OrderBy { get; } = new(
        name: @"--order-by")
    {
        Description = @"Field to order results by",
    };

    private static Option<global::Composio.GetMcpAppByAppKeyOrderDirection?> OrderDirection { get; } = new(
        name: @"--order-direction")
    {
        Description = @"Direction of ordering",
    };

    private static Option<double?> PageNo { get; } = new(
        name: @"--page-no")
    {
        Description = @"Page number for pagination (1-based)",
    };

    private static Option<double?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Number of items per page (default: 10)",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Composio.GetMcpAppByAppKeyResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.GetMcpAppByAppKeyResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-mcp-app-by-app-key", @"List MCP servers for a specific app
Retrieves a paginated list of Model Control Protocol (MCP) servers that are configured for a specific application or toolkit. This endpoint allows you to find all MCP server instances that have access to a particular application, such as GitHub, Slack, or Jira.");
                        command.Arguments.Add(AppKey);
                        command.Options.Add(NameOption);
                        command.Options.Add(Toolkits);
                        command.Options.Add(AuthConfigIds);
                        command.Options.Add(OrderBy);
                        command.Options.Add(OrderDirection);
                        command.Options.Add(PageNo);
                        command.Options.Add(Limit);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var appKey = parseResult.GetRequiredValue(AppKey);
                        var name = parseResult.GetValue(NameOption);
                        var toolkits = parseResult.GetValue(Toolkits);
                        var authConfigIds = parseResult.GetValue(AuthConfigIds);
                        var orderBy = parseResult.GetValue(OrderBy);
                        var orderDirection = parseResult.GetValue(OrderDirection);
                        var pageNo = parseResult.GetValue(PageNo);
                        var limit = parseResult.GetValue(Limit);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Mcp.GetMcpAppByAppKeyAsync(
                                    appKey: appKey,
                                    name: name,
                                    toolkits: toolkits,
                                    authConfigIds: authConfigIds,
                                    orderBy: orderBy,
                                    orderDirection: orderDirection,
                                    pageNo: pageNo,
                                    limit: limit,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Composio.SourceGenerationContext.Default,
                                        @"Items",
                                        cancellationToken).ConfigureAwait(false))
                                {
                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Composio.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}