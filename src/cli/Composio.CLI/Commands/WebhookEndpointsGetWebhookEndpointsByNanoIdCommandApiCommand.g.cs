#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class WebhookEndpointsGetWebhookEndpointsByNanoIdCommandApiCommand
{
    private static Argument<string> NanoId { get; } = new(
        name: @"nano-id")
    {
        Description = @"Webhook endpoint nano ID (e.g., we_abc123)",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Composio.GetWebhookEndpointsByNanoIdResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.GetWebhookEndpointsByNanoIdResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-webhook-endpoints-by-nano-id", @"Get webhook endpoint
Retrieves a single webhook endpoint. Secret values are redacted. Use GET /webhook_endpoints/schema to discover field definitions.");
                        command.Arguments.Add(NanoId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var nanoId = parseResult.GetRequiredValue(NanoId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.WebhookEndpoints.GetWebhookEndpointsByNanoIdAsync(
                                    nanoId: nanoId,
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