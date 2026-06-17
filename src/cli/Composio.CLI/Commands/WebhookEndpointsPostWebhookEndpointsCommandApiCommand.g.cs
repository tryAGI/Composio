#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class WebhookEndpointsPostWebhookEndpointsCommandApiCommand
{
    private static Option<string> ToolkitSlug { get; } = new(
        name: @"--toolkit-slug")
    {
        Description = @"Toolkit identifier (e.g., slack, discord)",
        Required = true,
    };

    private static Option<string> ClientId { get; } = new(
        name: @"--client-id")
    {
        Description = @"OAuth app client ID — identifies which app this endpoint is for",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Composio.PostWebhookEndpointsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.PostWebhookEndpointsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"post-webhook-endpoints", @"Create webhook endpoint
Creates a shared webhook endpoint for a toolkit + OAuth app + project. Returns the webhook URL that the customer registers in their app dashboard. Idempotent — returns existing endpoint if one already exists for this toolkit + client_id + project.");
                        command.Options.Add(ToolkitSlug);
                        command.Options.Add(ClientId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var toolkitSlug = parseResult.GetRequiredValue(ToolkitSlug);
                        var clientId = parseResult.GetRequiredValue(ClientId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.WebhookEndpoints.PostWebhookEndpointsAsync(
                                    toolkitSlug: toolkitSlug,
                                    clientId: clientId,
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