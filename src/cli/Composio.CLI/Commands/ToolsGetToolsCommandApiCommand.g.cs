#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class ToolsGetToolsCommandApiCommand
{
    private static Option<string?> ToolkitSlug { get; } = new(
        name: @"--toolkit-slug")
    {
        Description = @"The slug of the toolkit to filter by",
    };

    private static Option<string?> ToolSlugs { get; } = new(
        name: @"--tool-slugs")
    {
        Description = @"Comma-separated list of specific tool slugs to retrieve (overrides other filters)",
    };

    private static Option<global::Composio.OneOf<string, global::System.Collections.Generic.IList<string>>?> AuthConfigIds { get; } = new(
        name: @"--auth-config-ids")
    {
        Description = @"Comma-separated list of auth config IDs to filter tools by",
    };

    private static Option<global::Composio.GetToolsImportant?> Important { get; } = new(
        name: @"--important")
    {
        Description = @"Filter to only show important/featured tools (set to ""true"" to enable)",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> Tags { get; } = new(
        name: @"--tags")
    {
        Description = @"Filter tools by one or more tags (can be specified multiple times)",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> Scopes { get; } = new(
        name: @"--scopes")
    {
        Description = @"Array of scopes to filter tools by)",
    };

    private static Option<string?> Query { get; } = new(
        name: @"--query")
    {
        Description = @"Full-text search query to filter tools by name, slug, or description. Applied as a soft filter on top of other filters.",
    };

    private static Option<string?> Search { get; } = new(
        name: @"--search")
    {
        Description = @"Deprecated: use ""query"" instead. Free-text search query to find tools by name, description, or functionality.",
    };

    private static Option<bool?> IncludeDeprecated { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--include-deprecated",
        description: @"Include deprecated tools in the response");

    private static Option<global::Composio.OneOf<object, string, global::System.Collections.Generic.Dictionary<string, string>>?> ToolkitVersions { get; } = new(
        name: @"--toolkit-versions")
    {
        Description = @"Toolkit version specification. Use ""latest"" for latest versions or bracket notation for specific versions per toolkit. Defaults to the pinned version (""00000000_00"") when omitted.",
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

                    private static string FormatResponse(ParseResult parseResult, global::Composio.ToolsPaginated value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.ToolsPaginated value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-tools", @"List available tools
Retrieve a paginated list of available tools with comprehensive filtering, sorting and search capabilities. Use query parameters to narrow down results by toolkit, tags, or search terms.");
                        command.Options.Add(ToolkitSlug);
                        command.Options.Add(ToolSlugs);
                        command.Options.Add(AuthConfigIds);
                        command.Options.Add(Important);
                        command.Options.Add(Tags);
                        command.Options.Add(Scopes);
                        command.Options.Add(Query);
                        command.Options.Add(Search);
                        command.Options.Add(IncludeDeprecated);
                        command.Options.Add(ToolkitVersions);
                        command.Options.Add(Limit);
                        command.Options.Add(Cursor);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var toolkitSlug = parseResult.GetValue(ToolkitSlug);
                        var toolSlugs = parseResult.GetValue(ToolSlugs);
                        var authConfigIds = parseResult.GetValue(AuthConfigIds);
                        var important = parseResult.GetValue(Important);
                        var tags = parseResult.GetValue(Tags);
                        var scopes = parseResult.GetValue(Scopes);
                        var query = parseResult.GetValue(Query);
                        var search = parseResult.GetValue(Search);
                        var includeDeprecated = parseResult.GetValue(IncludeDeprecated);
                        var toolkitVersions = parseResult.GetValue(ToolkitVersions);
                        var limit = parseResult.GetValue(Limit);
                        var cursor = parseResult.GetValue(Cursor);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Tools.GetToolsAsync(
                                    toolkitSlug: toolkitSlug,
                                    toolSlugs: toolSlugs,
                                    authConfigIds: authConfigIds,
                                    important: important,
                                    tags: tags,
                                    scopes: scopes,
                                    query: query,
                                    search: search,
                                    includeDeprecated: includeDeprecated,
                                    toolkitVersions: toolkitVersions,
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