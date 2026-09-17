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

    private static Option<global::Composio.PatchTriggerInstancesManageByTriggerIdRequestStatus?> Status { get; } = new(
        name: @"--status")
    {
        Description = @"Enable or disable the trigger instance.",
    };

    private static Option<string?> UserId { get; } = new(
        name: @"--user-id")
    {
        Description = @"The user id that owns the connected account behind this trigger. Optional: when sent on a project with 2FA enabled it must be the owner of a private connection or allowed on a shared one, whatever is being updated. Required to set egress_url when 2FA is enabled. Ignored when 2FA is disabled.",
    };

    private static Option<string?> EgressUrl { get; } = new(
        name: @"--egress-url")
    {
        Description = @"Overrides the delivery URL for this trigger instance only: its events are sent to this HTTPS URL instead of the project webhook URL. Your project webhook subscription is still required and still controls signing (the webhook secret), the payload version and which events are enabled; only the destination changes for this instance. Omit to leave the current value unchanged; pass null to remove the override and deliver to the project webhook URL again.",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
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
        var command = new Command(@"patch-trigger-instances-manage-by-trigger-id", @"Update a trigger
Updates a trigger instance. Pass status to enable or disable it: disabling pauses event listening without deleting the trigger configuration, and re-enabling restores it. Pass egress_url to override where this instance delivers its events (null removes the override); the project webhook subscription is still required and still controls signing, the payload version and which events are enabled. Send either field or both. On a project with 2FA enabled, user_id is required to set egress_url and, whenever sent, must own the connected account behind the trigger.");
                        command.Arguments.Add(TriggerId);
                        command.Options.Add(Status);
                        command.Options.Add(UserId);
                        command.Options.Add(EgressUrl);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Composio.PatchTriggerInstancesManageByTriggerIdRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Composio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var triggerId = parseResult.GetRequiredValue(TriggerId);
                        var status = CliRuntime.WasSpecified(parseResult, Status) ? parseResult.GetValue(Status) : (__requestBase is { } __StatusBaseValue ? __StatusBaseValue.Status : default);
                        var userId = CliRuntime.WasSpecified(parseResult, UserId) ? parseResult.GetValue(UserId) : (__requestBase is { } __UserIdBaseValue ? __UserIdBaseValue.UserId : default);
                        var egressUrl = CliRuntime.WasSpecified(parseResult, EgressUrl) ? parseResult.GetValue(EgressUrl) : (__requestBase is { } __EgressUrlBaseValue ? __EgressUrlBaseValue.EgressUrl : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Triggers.PatchTriggerInstancesManageByTriggerIdAsync(
                                    triggerId: triggerId,
                                    status: status,
                                    userId: userId,
                                    egressUrl: egressUrl,
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