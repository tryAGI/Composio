#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class McpGetMcpServersCommandApiCommand
{
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

    private static Option<global::Composio.GetMcpServersOrderBy?> OrderBy { get; } = new(
        name: @"--order-by")
    {
        Description = @"Field to order results by",
    };

    private static Option<global::Composio.GetMcpServersOrderDirection?> OrderDirection { get; } = new(
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

                    private static string FormatResponse(ParseResult parseResult, global::Composio.GetMcpServersResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.GetMcpServersResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-mcp-servers", @"List MCP servers with optional filters and pagination
Retrieves a paginated list of MCP servers associated with the authenticated project. Results can be filtered by name, toolkit, or authentication configuration ID. MCP servers are used to provide Model Control Protocol integration points for connecting AI assistants to your applications and services.");
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
                        var name = parseResult.GetValue(NameOption);
                        var toolkits = parseResult.GetValue(Toolkits);
                        var authConfigIds = parseResult.GetValue(AuthConfigIds);
                        var orderBy = parseResult.GetValue(OrderBy);
                        var orderDirection = parseResult.GetValue(OrderDirection);
                        var pageNo = parseResult.GetValue(PageNo);
                        var limit = parseResult.GetValue(Limit);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Mcp.GetMcpServersAsync(
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