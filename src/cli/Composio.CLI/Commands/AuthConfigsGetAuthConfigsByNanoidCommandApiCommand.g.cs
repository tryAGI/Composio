#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class AuthConfigsGetAuthConfigsByNanoidCommandApiCommand
{
    private static Argument<string> Nanoid { get; } = new(
        name: @"nanoid")
    {
        Description = @"The unique identifier of the authentication configuration to retrieve",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Composio.GetAuthConfigsByNanoidResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.GetAuthConfigsByNanoidResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-auth-configs-by-nanoid", @"Get single authentication configuration by ID
Retrieves detailed information about a specific authentication configuration using its unique identifier.");
                        command.Arguments.Add(Nanoid);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var nanoid = parseResult.GetRequiredValue(Nanoid);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.AuthConfigs.GetAuthConfigsByNanoidAsync(
                                    nanoid: nanoid,
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