#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class TriggersDeleteTriggerInstancesManageByTriggerIdCommandApiCommand
{
    private static Argument<string> TriggerId { get; } = new(
        name: @"trigger-id")
    {
        Description = @"The ID of the trigger instance to delete",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Composio.DeleteTriggerInstancesManageByTriggerIdResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.DeleteTriggerInstancesManageByTriggerIdResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"delete-trigger-instances-manage-by-trigger-id", @"Delete a trigger
Permanently deletes a trigger instance. This stops the trigger from listening for events and removes it from your project. When a webhook trigger is deleted, Composio also attempts to remove the webhook it received events through at the provider, once no other active trigger uses it. This runs in the background after the response, with retries if the provider fails. Use the PATCH endpoint with status ""disable"" if you want to temporarily pause a trigger instead.");
                        command.Arguments.Add(TriggerId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var triggerId = parseResult.GetRequiredValue(TriggerId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Triggers.DeleteTriggerInstancesManageByTriggerIdAsync(
                                    triggerId: triggerId,
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