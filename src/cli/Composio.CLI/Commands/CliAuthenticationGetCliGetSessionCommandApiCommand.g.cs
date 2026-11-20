#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class CliAuthenticationGetCliGetSessionCommandApiCommand
{
    private static Option<global::System.Guid> Id { get; } = new(
        name: @"--id")
    {
        Description = @"CLI session ID (UUID format) to check.",
        Required = true,
    };

    private static Option<string?> XCliSessionSecret { get; } = new(
        name: @"--x-cli-session-secret")
    {
        Description = @"The code_verifier whose S256 hash is the session's code_challenge. Required on every UUID lookup of a session created with a code_challenge; omit it for a session created without one.",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Composio.GetCliGetSessionResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.GetCliGetSessionResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"get-cli-get-session", @"Get CLI session details by ID
Retrieves the current state of a CLI session using its session ID (UUID v4). The first lookup after the session is linked returns its API key; each session issues one key. Display codes are not accepted. For a session created with a code_challenge, every lookup must send the verifier in the x-cli-session-secret header; a session created without one rejects any lookup that sends the header.");
                        command.Options.Add(Id);
                        command.Options.Add(XCliSessionSecret);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var id = parseResult.GetRequiredValue(Id);
                        var xCliSessionSecret = parseResult.GetValue(XCliSessionSecret);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CliAuthentication.GetCliGetSessionAsync(
                                    id: id,
                                    xCliSessionSecret: xCliSessionSecret,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Composio.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
            }, cancellationToken).ConfigureAwait(false));
        CustomizeCommand(ref command);
        return command;
    }
}