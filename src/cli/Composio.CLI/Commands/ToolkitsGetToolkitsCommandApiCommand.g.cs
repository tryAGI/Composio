#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class ToolkitsGetToolkitsCommandApiCommand
{
    private static Option<string?> Category { get; } = new(
        name: @"--category")
    {
        Description = @"Filter toolkits by category",
    };

    private static Option<global::Composio.GetToolkitsManagedBy?> ManagedBy { get; } = new(
        name: @"--managed-by")
    {
        Description = @"Filter toolkits by who manages them",
    };

    private static Option<global::Composio.GetToolkitsSortBy?> SortBy { get; } = new(
        name: @"--sort-by")
    {
        Description = @"Sort order for returned toolkits",
    };

    private static Option<bool?> IncludeDeprecated { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--include-deprecated",
        description: @"Include deprecated toolkits in the response");

    private static Option<string?> Search { get; } = new(
        name: @"--search")
    {
        Description = @"Search query to filter toolkits by name, slug, or description",
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

                    private static string FormatResponse(ParseResult parseResult, global::Composio.GetToolkitsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.GetToolkitsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-toolkits", @"List available toolkits
Retrieves a comprehensive list of toolkits of their latest versions that are available to the authenticated project. Toolkits represent integration points with external services and applications, each containing a collection of tools and triggers. This endpoint supports filtering by category and management type, as well as different sorting options.");
                        command.Options.Add(Category);
                        command.Options.Add(ManagedBy);
                        command.Options.Add(SortBy);
                        command.Options.Add(IncludeDeprecated);
                        command.Options.Add(Search);
                        command.Options.Add(Limit);
                        command.Options.Add(Cursor);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var category = parseResult.GetValue(Category);
                        var managedBy = parseResult.GetValue(ManagedBy);
                        var sortBy = parseResult.GetValue(SortBy);
                        var includeDeprecated = parseResult.GetValue(IncludeDeprecated);
                        var search = parseResult.GetValue(Search);
                        var limit = parseResult.GetValue(Limit);
                        var cursor = parseResult.GetValue(Cursor);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Toolkits.GetToolkitsAsync(
                                    category: category,
                                    managedBy: managedBy,
                                    sortBy: sortBy,
                                    includeDeprecated: includeDeprecated,
                                    search: search,
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