#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class TriggersGetTriggerInstancesActiveCommandApiCommand
{
    private static Option<global::System.Collections.Generic.IList<string>?> UserIds { get; } = new(
        name: @"--user-ids")
    {
        Description = @"Array of user IDs to filter triggers by",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> ConnectedAccountIds { get; } = new(
        name: @"--connected-account-ids")
    {
        Description = @"Array of connected account IDs to filter triggers by",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> AuthConfigIds { get; } = new(
        name: @"--auth-config-ids")
    {
        Description = @"Array of auth config IDs to filter triggers by",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> TriggerIds { get; } = new(
        name: @"--trigger-ids")
    {
        Description = @"Array of trigger IDs to filter triggers by",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> TriggerNames { get; } = new(
        name: @"--trigger-names")
    {
        Description = @"Array of trigger names to filter triggers by. Case-insensitive (internally normalized to uppercase).",
    };

    private static Option<bool?> ShowDisabled { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--show-disabled",
        description: @"When set to true, includes disabled triggers in the response.");

    private static Option<double?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Number of items per page, max allowed is 50",
    };

    private static Option<string?> Cursor { get; } = new(
        name: @"--cursor")
    {
        Description = @"Cursor for pagination. The cursor is a base64 encoded string of the page and limit. The page is the page number and the limit is the number of items per page. The cursor is used to paginate through the items. The cursor is not required for the first page.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Composio.GetTriggerInstancesActiveResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.GetTriggerInstancesActiveResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-trigger-instances-active", @"List active triggers
Retrieves all active trigger instances for your project. Triggers listen for events from connected accounts (e.g., new emails, Slack messages, GitHub commits) and can invoke webhooks or workflows. Use filters to find triggers for specific users, connected accounts, or trigger types.");
                        command.Options.Add(UserIds);
                        command.Options.Add(ConnectedAccountIds);
                        command.Options.Add(AuthConfigIds);
                        command.Options.Add(TriggerIds);
                        command.Options.Add(TriggerNames);
                        command.Options.Add(ShowDisabled);
                        command.Options.Add(Limit);
                        command.Options.Add(Cursor);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var userIds = parseResult.GetValue(UserIds);
                        var connectedAccountIds = parseResult.GetValue(ConnectedAccountIds);
                        var authConfigIds = parseResult.GetValue(AuthConfigIds);
                        var triggerIds = parseResult.GetValue(TriggerIds);
                        var triggerNames = parseResult.GetValue(TriggerNames);
                        var showDisabled = parseResult.GetValue(ShowDisabled);
                        var limit = parseResult.GetValue(Limit);
                        var cursor = parseResult.GetValue(Cursor);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Triggers.GetTriggerInstancesActiveAsync(
                                    userIds: userIds,
                                    connectedAccountIds: connectedAccountIds,
                                    authConfigIds: authConfigIds,
                                    triggerIds: triggerIds,
                                    triggerNames: triggerNames,
                                    showDisabled: showDisabled,
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