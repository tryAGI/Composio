#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class AuthConfigsGetAuthConfigsCommandApiCommand
{
    private static Option<global::Composio.AnyOf<string, bool?>?> IsComposioManaged { get; } = new(
        name: @"--is-composio-managed")
    {
        Description = @"Whether to filter by composio managed auth configs",
    };

    private static Option<string?> ToolkitSlug { get; } = new(
        name: @"--toolkit-slug")
    {
        Description = @"Comma-separated list of toolkit slugs to filter auth configs by",
    };

    private static Option<string?> DeprecatedAppId { get; } = new(
        name: @"--deprecated-app-id")
    {
        Description = @"The app id to filter by",
    };

    private static Option<string?> DeprecatedStatus { get; } = new(
        name: @"--deprecated-status")
    {
        Description = @"DEPRECATED: This parameter will be removed in a future version.",
    };

    private static Option<bool?> ShowDisabled { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--show-disabled",
        description: @"Show disabled auth configs");

    private static Option<string?> Search { get; } = new(
        name: @"--search")
    {
        Description = @"Search auth configs by name or id",
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

                    private static string FormatResponse(ParseResult parseResult, global::Composio.GetAuthConfigsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.GetAuthConfigsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-auth-configs", @"List authentication configurations with optional filters
Retrieves all auth configs for your project. Auth configs define how users authenticate with external services (OAuth, API keys, etc.). Use filters to find configs for specific toolkits or to distinguish between Composio-managed and custom configurations.");
                        command.Options.Add(IsComposioManaged);
                        command.Options.Add(ToolkitSlug);
                        command.Options.Add(DeprecatedAppId);
                        command.Options.Add(DeprecatedStatus);
                        command.Options.Add(ShowDisabled);
                        command.Options.Add(Search);
                        command.Options.Add(Limit);
                        command.Options.Add(Cursor);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var isComposioManaged = parseResult.GetValue(IsComposioManaged);
                        var toolkitSlug = parseResult.GetValue(ToolkitSlug);
                        var deprecatedAppId = parseResult.GetValue(DeprecatedAppId);
                        var deprecatedStatus = parseResult.GetValue(DeprecatedStatus);
                        var showDisabled = parseResult.GetValue(ShowDisabled);
                        var search = parseResult.GetValue(Search);
                        var limit = parseResult.GetValue(Limit);
                        var cursor = parseResult.GetValue(Cursor);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.AuthConfigs.GetAuthConfigsAsync(
                                    isComposioManaged: isComposioManaged,
                                    toolkitSlug: toolkitSlug,
                                    deprecatedAppId: deprecatedAppId,
                                    deprecatedStatus: deprecatedStatus,
                                    showDisabled: showDisabled,
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