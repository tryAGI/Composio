#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class ToolRouterPostToolRouterSessionBySessionIdLinkCommandApiCommand
{
    private static Argument<string> SessionId { get; } = new(
        name: @"session-id")
    {
        Description = @"The unique identifier of the tool router session",
    };

    private static Option<string> Toolkit { get; } = new(
        name: @"--toolkit")
    {
        Description = @"The unique slug identifier of the toolkit to connect",
        Required = true,
    };

    private static Option<string?> Alias { get; } = new(
        name: @"--alias")
    {
        Description = @"A human-readable alias for this connected account. Must be unique per entity and toolkit within the project.",
    };

    private static Option<string?> CallbackUrl { get; } = new(
        name: @"--callback-url")
    {
        Description = @"URL where users will be redirected after completing auth",
    };

    private static Option<global::Composio.PostToolRouterSessionBySessionIdLinkRequestExperimental?> Experimental { get; } = new(
        name: @"--experimental")
    {
        Description = @"Experimental features - not stable, may be modified or removed in future versions.",
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

                    private static string FormatResponse(ParseResult parseResult, global::Composio.PostToolRouterSessionBySessionIdLinkResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.PostToolRouterSessionBySessionIdLinkResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"post-tool-router-session-by-session-id-link", @"Create a link session for a toolkit in a tool router session
Initiates an authentication link session for a specific toolkit within a tool router session. Returns a link token and redirect URL that users can use to complete the OAuth flow.");
                        command.Arguments.Add(SessionId);
                        command.Options.Add(Toolkit);
                        command.Options.Add(Alias);
                        command.Options.Add(CallbackUrl);
                        command.Options.Add(Experimental);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Composio.PostToolRouterSessionBySessionIdLinkRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Composio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var sessionId = parseResult.GetRequiredValue(SessionId);
                        var toolkit = parseResult.GetRequiredValue(Toolkit);
                        var alias = CliRuntime.WasSpecified(parseResult, Alias) ? parseResult.GetValue(Alias) : (__requestBase is { } __AliasBaseValue ? __AliasBaseValue.Alias : default);
                        var callbackUrl = CliRuntime.WasSpecified(parseResult, CallbackUrl) ? parseResult.GetValue(CallbackUrl) : (__requestBase is { } __CallbackUrlBaseValue ? __CallbackUrlBaseValue.CallbackUrl : default);
                        var experimental = CliRuntime.WasSpecified(parseResult, Experimental) ? parseResult.GetValue(Experimental) : (__requestBase is { } __ExperimentalBaseValue ? __ExperimentalBaseValue.Experimental : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ToolRouter.PostToolRouterSessionBySessionIdLinkAsync(
                                    sessionId: sessionId,
                                    toolkit: toolkit,
                                    alias: alias,
                                    callbackUrl: callbackUrl,
                                    experimental: experimental,
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