#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class TriggersPatchTriggerInstancesManageByTriggerIdCommandApiCommand
{
    private static Argument<string> TriggerId { get; } = new(
        name: @"trigger-id")
    {
        Description = @"The ID of the trigger instance to update",
    };

    private static Option<global::Composio.PatchTriggerInstancesManageByTriggerIdRequestStatus> Status { get; } = new(
        name: @"--status")
    {
        Description = @"",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Composio.PatchTriggerInstancesManageByTriggerIdResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.PatchTriggerInstancesManageByTriggerIdResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"patch-trigger-instances-manage-by-trigger-id", @"Enable or disable a trigger
Updates the status of a trigger instance to enable or disable it. Disabling a trigger pauses event listening without deleting the trigger configuration. Re-enabling restores the trigger to its active state. Use this for temporary maintenance or to control trigger execution.");
                        command.Arguments.Add(TriggerId);
                        command.Options.Add(Status);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var triggerId = parseResult.GetRequiredValue(TriggerId);
                        var status = parseResult.GetRequiredValue(Status);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Triggers.PatchTriggerInstancesManageByTriggerIdAsync(
                                    triggerId: triggerId,
                                    status: status,
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