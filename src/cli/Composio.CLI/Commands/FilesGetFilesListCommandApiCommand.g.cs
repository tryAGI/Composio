#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class FilesGetFilesListCommandApiCommand
{
    private static Option<string?> ToolkitSlug { get; } = new(
        name: @"--toolkit-slug")
    {
        Description = @"Filter files by app slug. Example: ""file-converter""",
    };

    private static Option<string?> ToolSlug { get; } = new(
        name: @"--tool-slug")
    {
        Description = @"Filter files by action slug. Example: ""convert-to-pdf""",
    };

    private static Option<double?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Number of items per page, max allowed is 1000",
    };

    private static Option<string?> Cursor { get; } = new(
        name: @"--cursor")
    {
        Description = @"Cursor for pagination. The cursor is a base64 encoded string of the page and limit. The page is the page number and the limit is the number of items per page. The cursor is used to paginate through the items. The cursor is not required for the first page.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Composio.GetFilesListResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.GetFilesListResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-files-list", @"List files with optional app and action filters
Retrieves a list of files associated with the authenticated project. Results can be filtered by toolkit and tool slugs.");
                        command.Options.Add(ToolkitSlug);
                        command.Options.Add(ToolSlug);
                        command.Options.Add(Limit);
                        command.Options.Add(Cursor);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var toolkitSlug = parseResult.GetValue(ToolkitSlug);
                        var toolSlug = parseResult.GetValue(ToolSlug);
                        var limit = parseResult.GetValue(Limit);
                        var cursor = parseResult.GetValue(Cursor);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Files.GetFilesListAsync(
                                    toolkitSlug: toolkitSlug,
                                    toolSlug: toolSlug,
                                    limit: limit,
                                    cursor: cursor,
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