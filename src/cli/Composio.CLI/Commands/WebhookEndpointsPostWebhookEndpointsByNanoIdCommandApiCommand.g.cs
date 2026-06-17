#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class WebhookEndpointsPostWebhookEndpointsByNanoIdCommandApiCommand
{
    private static Argument<string> NanoId { get; } = new(
        name: @"nano-id")
    {
        Description = @"Webhook endpoint nano ID (e.g., we_abc123)",
    };

    private static Option<global::System.Collections.Generic.Dictionary<string, string>> Data { get; } = new(
        name: @"--data")
    {
        Description = @"Key-value pairs for ALL required setup_fields. Unlike PATCH, all required fields must be provided — this is initial configuration.",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Composio.PostWebhookEndpointsByNanoIdResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.PostWebhookEndpointsByNanoIdResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"post-webhook-endpoints-by-nano-id", @"Put webhook endpoint configuration
Full replacement of webhook endpoint configuration. All required setup fields must be provided. Use PATCH to update individual fields.");
                        command.Arguments.Add(NanoId);
                        command.Options.Add(Data);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var nanoId = parseResult.GetRequiredValue(NanoId);
                        var data = parseResult.GetRequiredValue(Data);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.WebhookEndpoints.PostWebhookEndpointsByNanoIdAsync(
                                    nanoId: nanoId,
                                    data: data,
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