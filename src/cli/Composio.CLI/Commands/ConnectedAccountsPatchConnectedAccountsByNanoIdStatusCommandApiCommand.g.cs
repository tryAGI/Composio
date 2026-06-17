#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class ConnectedAccountsPatchConnectedAccountsByNanoIdStatusCommandApiCommand
{
    private static Argument<string> NanoId { get; } = new(
        name: @"nano-id")
    {
        Description = @"The unique identifier of the connected account",
    };

    private static Option<bool> Enabled { get; } = new(
        name: @"--enabled")
    {
        Description = @"Set to true to enable the account or false to disable it",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Composio.PatchConnectedAccountsByNanoIdStatusResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.PatchConnectedAccountsByNanoIdStatusResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"patch-connected-accounts-by-nano-id-status", @"Enable or disable a connected account
Updates the status of a connected account to either enabled (active) or disabled (inactive). Disabled accounts cannot be used for API calls but remain in the database.");
                        command.Arguments.Add(NanoId);
                        command.Options.Add(Enabled);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var nanoId = parseResult.GetRequiredValue(NanoId);
                        var enabled = parseResult.GetRequiredValue(Enabled);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ConnectedAccounts.PatchConnectedAccountsByNanoIdStatusAsync(
                                    nanoId: nanoId,
                                    enabled: enabled,
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