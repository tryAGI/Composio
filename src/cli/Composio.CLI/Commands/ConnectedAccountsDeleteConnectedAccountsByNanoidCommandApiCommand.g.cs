#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class ConnectedAccountsDeleteConnectedAccountsByNanoidCommandApiCommand
{
    private static Argument<string> Nanoid { get; } = new(
        name: @"nanoid")
    {
        Description = @"The unique identifier (nanoid) of the connected account",
    };

    private static Option<bool?> RevokeOnDelete { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--revoke-on-delete",
        description: @"When `true`, the delete also starts a background job that revokes the upstream credentials of every connected account in scope, and the response carries a `revoke_job_id`. Defaults to `false`. Revocation is irreversible — recovering a deleted entity does not restore working credentials.");

                    private static string FormatResponse(ParseResult parseResult, global::Composio.DeleteConnectedAccountsByNanoidResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.DeleteConnectedAccountsByNanoidResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"delete-connected-accounts-by-nanoid", @"Delete a connected account
Soft-deletes a connected account by marking it as deleted in the database. This prevents the account from being used for API calls but preserves the record for audit purposes. Pass `?revoke_on_delete=true` to also revoke the account's upstream credentials via a background job.");
                        command.Arguments.Add(Nanoid);
                        command.Options.Add(RevokeOnDelete);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var nanoid = parseResult.GetRequiredValue(Nanoid);
                        var revokeOnDelete = parseResult.GetValue(RevokeOnDelete);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ConnectedAccounts.DeleteConnectedAccountsByNanoidAsync(
                                    nanoid: nanoid,
                                    revokeOnDelete: revokeOnDelete,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Composio.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}