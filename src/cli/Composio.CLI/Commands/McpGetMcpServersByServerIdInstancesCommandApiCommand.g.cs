#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class McpGetMcpServersByServerIdInstancesCommandApiCommand
{
    private static Argument<string> ServerId { get; } = new(
        name: @"server-id")
    {
        Description = @"The ID of the MCP server",
    };

    private static Option<double?> PageNo { get; } = new(
        name: @"--page-no")
    {
        Description = @"Page number for pagination (1-based)",
    };

    private static Option<double?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Number of items per page (default: 20)",
    };

    private static Option<string?> Search { get; } = new(
        name: @"--search")
    {
        Description = @"Search instances by user ID/instance ID",
    };

    private static Option<global::Composio.GetMcpServersByServerIdInstancesOrderBy?> OrderBy { get; } = new(
        name: @"--order-by")
    {
        Description = @"Field to order results by",
    };

    private static Option<global::Composio.GetMcpServersByServerIdInstancesOrderDirection?> OrderDirection { get; } = new(
        name: @"--order-direction")
    {
        Description = @"Direction of ordering",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Composio.GetMcpServersByServerIdInstancesResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.GetMcpServersByServerIdInstancesResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-mcp-servers-by-server-id-instances", @"List all instances for an MCP server
Retrieves a paginated list of user instances (user IDs) associated with a specific Model Control Protocol (MCP) server. This endpoint supports pagination to handle servers with many instances.");
                        command.Arguments.Add(ServerId);
                        command.Options.Add(PageNo);
                        command.Options.Add(Limit);
                        command.Options.Add(Search);
                        command.Options.Add(OrderBy);
                        command.Options.Add(OrderDirection);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var serverId = parseResult.GetRequiredValue(ServerId);
                        var pageNo = parseResult.GetValue(PageNo);
                        var limit = parseResult.GetValue(Limit);
                        var search = parseResult.GetValue(Search);
                        var orderBy = parseResult.GetValue(OrderBy);
                        var orderDirection = parseResult.GetValue(OrderDirection);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Mcp.GetMcpServersByServerIdInstancesAsync(
                                    serverId: serverId,
                                    pageNo: pageNo,
                                    limit: limit,
                                    search: search,
                                    orderBy: orderBy,
                                    orderDirection: orderDirection,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Composio.SourceGenerationContext.Default,
                                        @"Instances",
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