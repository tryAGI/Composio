#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class ToolRouterGetToolRouterSessionBySessionIdToolkitsCommandApiCommand
{
    private static Argument<string> SessionId { get; } = new(
        name: @"session-id")
    {
        Description = @"The unique identifier of the tool router session",
    };

    private static Option<int?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Number of items per page, max allowed is 50",
    };

    private static Option<string?> Cursor { get; } = new(
        name: @"--cursor")
    {
        Description = @"Cursor for pagination. The cursor is a base64 encoded string of the page and limit. The page is the page number and the limit is the number of items per page. The cursor is used to paginate through the items. The cursor is not required for the first page.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> Toolkits { get; } = new(
        name: @"--toolkits")
    {
        Description = @"Optional comma-separated list of toolkit slugs to filter by. If provided, only these toolkits will be returned, overriding the session configuration.",
    };

    private static Option<bool?> IsConnected { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--is-connected",
        description: @"Whether to filter by connected toolkits. If provided, only connected toolkits will be returned.");

    private static Option<string?> Search { get; } = new(
        name: @"--search")
    {
        Description = @"Search query to filter toolkits by name, slug, or description",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Composio.ToolRouterToolkitsListResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.ToolRouterToolkitsListResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-tool-router-session-by-session-id-toolkits", @"Get toolkits for a tool router session
Retrieves a cursor-paginated list of toolkits available in the tool router session. Includes toolkit metadata, composio-managed auth schemes, and connected accounts if available. Optionally filter by specific toolkit slugs.");
                        command.Arguments.Add(SessionId);
                        command.Options.Add(Limit);
                        command.Options.Add(Cursor);
                        command.Options.Add(Toolkits);
                        command.Options.Add(IsConnected);
                        command.Options.Add(Search);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var sessionId = parseResult.GetRequiredValue(SessionId);
                        var limit = parseResult.GetValue(Limit);
                        var cursor = parseResult.GetValue(Cursor);
                        var toolkits = parseResult.GetValue(Toolkits);
                        var isConnected = parseResult.GetValue(IsConnected);
                        var search = parseResult.GetValue(Search);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ToolRouter.GetToolRouterSessionBySessionIdToolkitsAsync(
                                    sessionId: sessionId,
                                    limit: limit,
                                    cursor: cursor,
                                    toolkits: toolkits,
                                    isConnected: isConnected,
                                    search: search,
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