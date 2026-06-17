#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class WebhookSubscriptionsPostWebhookSubscriptionsCommandApiCommand
{
    private static Option<string> WebhookUrl { get; } = new(
        name: @"--webhook-url")
    {
        Description = @"HTTPS URL to receive webhook events",
        Required = true,
    };

    private static Option<global::System.Collections.Generic.IList<string>> EnabledEvents { get; } = new(
        name: @"--enabled-events")
    {
        Description = @"Array of event types to subscribe to",
        Required = true,
    };

    private static Option<global::Composio.PostWebhookSubscriptionsRequestVersion?> Version { get; } = new(
        name: @"--version")
    {
        Description = @"Webhook payload version",
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

                    private static string FormatResponse(ParseResult parseResult, global::Composio.PostWebhookSubscriptionsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.PostWebhookSubscriptionsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"post-webhook-subscriptions", @"Create webhook subscription
Creates a webhook subscription for the authenticated project. Only one subscription is allowed per project. The signing secret is returned in subscription responses.");
                        command.Options.Add(WebhookUrl);
                        command.Options.Add(EnabledEvents);
                        command.Options.Add(Version);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Composio.PostWebhookSubscriptionsRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Composio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var webhookUrl = parseResult.GetRequiredValue(WebhookUrl);
                        var enabledEvents = parseResult.GetRequiredValue(EnabledEvents);
                        var version = CliRuntime.WasSpecified(parseResult, Version) ? parseResult.GetValue(Version) : (__requestBase is { } __VersionBaseValue ? __VersionBaseValue.Version : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.WebhookSubscriptions.PostWebhookSubscriptionsAsync(
                                    webhookUrl: webhookUrl,
                                    enabledEvents: enabledEvents,
                                    version: version,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Composio.SourceGenerationContext.Default,
                                        @"EnabledEvents",
                                        cancellationToken).ConfigureAwait(false))
                                {
                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Composio.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}