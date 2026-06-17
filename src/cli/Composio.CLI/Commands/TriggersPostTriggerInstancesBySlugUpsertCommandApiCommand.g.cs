#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class TriggersPostTriggerInstancesBySlugUpsertCommandApiCommand
{
    private static Argument<string> Slug { get; } = new(
        name: @"slug")
    {
        Description = @"The slug of the trigger instance. Case-insensitive (internally normalized to uppercase).",
    };

    private static Option<string?> ConnectedAccountId { get; } = new(
        name: @"--connected-account-id")
    {
        Description = @"Connected account nanoid",
    };

    private static Option<string?> UserId { get; } = new(
        name: @"--user-id")
    {
        Description = @"The user id (entity id) that owns the connected account. When the project has 2FA enabled, this is validated against the owner of connected_account_id.",
    };

    private static Option<global::System.Collections.Generic.Dictionary<string, object?>?> TriggerConfig2 { get; } = new(
        name: @"--trigger-config")
    {
        Description = @"Trigger configuration",
    };

    private static Option<global::Composio.AnyOf<string, global::System.Collections.Generic.Dictionary<string, string>, object>?> ToolkitVersions { get; } = new(
        name: @"--toolkit-versions")
    {
        Description = @"Toolkit version specification. Supports ""latest"" string or a record mapping toolkit slugs to specific versions.",
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

                    private static string FormatResponse(ParseResult parseResult, global::Composio.PostTriggerInstancesBySlugUpsertResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.PostTriggerInstancesBySlugUpsertResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"post-trigger-instances-by-slug-upsert", @"Create or update a trigger
Creates a new trigger instance or updates an existing one with the same configuration. Triggers listen for events from external services (webhooks or polling) and can invoke your workflows. If a matching trigger already exists and is disabled, it will be re-enabled. Requires a connected account ID to associate the trigger with a specific user connection.");
                        command.Arguments.Add(Slug);
                        command.Options.Add(ConnectedAccountId);
                        command.Options.Add(UserId);
                        command.Options.Add(TriggerConfig2);
                        command.Options.Add(ToolkitVersions);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Composio.PostTriggerInstancesBySlugUpsertRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Composio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var slug = parseResult.GetRequiredValue(Slug);
                        var connectedAccountId = CliRuntime.WasSpecified(parseResult, ConnectedAccountId) ? parseResult.GetValue(ConnectedAccountId) : (__requestBase is { } __ConnectedAccountIdBaseValue ? __ConnectedAccountIdBaseValue.ConnectedAccountId : default);
                        var userId = CliRuntime.WasSpecified(parseResult, UserId) ? parseResult.GetValue(UserId) : (__requestBase is { } __UserIdBaseValue ? __UserIdBaseValue.UserId : default);
                        var triggerConfig2 = CliRuntime.WasSpecified(parseResult, TriggerConfig2) ? parseResult.GetValue(TriggerConfig2) : (__requestBase is { } __TriggerConfig2BaseValue ? __TriggerConfig2BaseValue.TriggerConfig2 : default);
                        var toolkitVersions = CliRuntime.WasSpecified(parseResult, ToolkitVersions) ? parseResult.GetValue(ToolkitVersions) : (__requestBase is { } __ToolkitVersionsBaseValue ? __ToolkitVersionsBaseValue.ToolkitVersions : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Triggers.PostTriggerInstancesBySlugUpsertAsync(
                                    slug: slug,
                                    connectedAccountId: connectedAccountId,
                                    userId: userId,
                                    triggerConfig2: triggerConfig2,
                                    toolkitVersions: toolkitVersions,
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