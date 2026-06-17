#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class ConnectedAccountsGetConnectedAccountsCommandApiCommand
{
    private static Option<global::System.Collections.Generic.IList<string>?> ToolkitSlugs { get; } = new(
        name: @"--toolkit-slugs")
    {
        Description = @"The toolkit slugs of the connected accounts",
    };

    private static Option<global::System.Collections.Generic.IList<global::Composio.GetConnectedAccountsStatuse>?> Statuses { get; } = new(
        name: @"--statuses")
    {
        Description = @"The status of the connected account",
    };

    private static Option<string?> Cursor { get; } = new(
        name: @"--cursor")
    {
        Description = @"The cursor to paginate through the connected accounts",
    };

    private static Option<double?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"The limit of the connected accounts to return",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> UserIds { get; } = new(
        name: @"--user-ids")
    {
        Description = @"The user ids of the connected accounts",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> AuthConfigIds { get; } = new(
        name: @"--auth-config-ids")
    {
        Description = @"The auth config ids of the connected accounts",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> ConnectedAccountIds { get; } = new(
        name: @"--connected-account-ids")
    {
        Description = @"The connected account ids to filter by",
    };

    private static Option<global::Composio.GetConnectedAccountsOrderBy?> OrderBy { get; } = new(
        name: @"--order-by")
    {
        Description = @"The order by of the connected accounts",
    };

    private static Option<global::Composio.GetConnectedAccountsOrderDirection?> OrderDirection { get; } = new(
        name: @"--order-direction")
    {
        Description = @"The order direction of the connected accounts",
    };

    private static Option<global::Composio.GetConnectedAccountsAccountType?> AccountType { get; } = new(
        name: @"--account-type")
    {
        Description = @"[Experimental] Filter by sharing model. Default (omitted) returns PRIVATE only — shared accounts must be requested explicitly. Pass SHARED for only shared accounts, or ALL for PRIVATE + SHARED.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Composio.GetConnectedAccountsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.GetConnectedAccountsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-connected-accounts", @"List connected accounts with optional filters
Retrieves all connected accounts for your project. Connected accounts represent authenticated user connections to external services (e.g., a user's Gmail account, Slack workspace). Filter by toolkit, status, user ID, or auth config to find specific connections.");
                        command.Options.Add(ToolkitSlugs);
                        command.Options.Add(Statuses);
                        command.Options.Add(Cursor);
                        command.Options.Add(Limit);
                        command.Options.Add(UserIds);
                        command.Options.Add(AuthConfigIds);
                        command.Options.Add(ConnectedAccountIds);
                        command.Options.Add(OrderBy);
                        command.Options.Add(OrderDirection);
                        command.Options.Add(AccountType);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var toolkitSlugs = parseResult.GetValue(ToolkitSlugs);
                        var statuses = parseResult.GetValue(Statuses);
                        var cursor = parseResult.GetValue(Cursor);
                        var limit = parseResult.GetValue(Limit);
                        var userIds = parseResult.GetValue(UserIds);
                        var authConfigIds = parseResult.GetValue(AuthConfigIds);
                        var connectedAccountIds = parseResult.GetValue(ConnectedAccountIds);
                        var orderBy = parseResult.GetValue(OrderBy);
                        var orderDirection = parseResult.GetValue(OrderDirection);
                        var accountType = parseResult.GetValue(AccountType);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ConnectedAccounts.GetConnectedAccountsAsync(
                                    toolkitSlugs: toolkitSlugs,
                                    statuses: statuses,
                                    cursor: cursor,
                                    limit: limit,
                                    userIds: userIds,
                                    authConfigIds: authConfigIds,
                                    connectedAccountIds: connectedAccountIds,
                                    orderBy: orderBy,
                                    orderDirection: orderDirection,
                                    accountType: accountType,
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