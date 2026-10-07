#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class ToolRouterPostToolRouterSessionBySessionIdExecuteMetaCommandApiCommand
{
    private static Argument<string?> SessionId { get; } = new(
        name: @"session-id")
    {
        Description = @"Tool router session ID (required for public API, optional for internal - injected by middleware)",
    };

    private static Option<global::Composio.PostToolRouterSessionBySessionIdExecuteMetaRequestSlug> Slug { get; } = new(
        name: @"--slug")
    {
        Description = @"The unique slug identifier of the meta tool to execute",
        Required = true,
    };

    private static Option<global::System.Collections.Generic.Dictionary<string, object?>?> ArgumentsOption { get; } = new(
        name: @"--arguments")
    {
        Description = @"The arguments required by the meta tool",
    };

    private static Option<global::System.Collections.Generic.Dictionary<string, global::Composio.UserInputResponse>?> InputResponses { get; } = new(
        name: @"--input-responses")
    {
        Description = @"The user's answers to an `input_required` response, keyed by the ids in its `input_requests`. Send them by repeating the same call (same tool and arguments) with this field added, along with the response's `request_state` if present. An approved call runs; a denied or declined one returns `failed`.",
    };

    private static Option<string?> RequestState { get; } = new(
        name: @"--request-state")
    {
        Description = @"The `request_state` from the `input_required` response, sent back unchanged with `input_responses`.",
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

                    private static string FormatResponse(ParseResult parseResult, global::Composio.PostToolRouterSessionBySessionIdExecuteMetaResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.PostToolRouterSessionBySessionIdExecuteMetaResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"post-tool-router-session-by-session-id-execute-meta", @"Execute a meta tool within a tool router session
Executes a Composio meta tool (COMPOSIO_*) within a tool router session. This endpoint is kept for meta-tool compatibility; clients can also use the primary /execute endpoint.");
                        command.Arguments.Add(SessionId);
                        command.Options.Add(Slug);
                        command.Options.Add(ArgumentsOption);
                        command.Options.Add(InputResponses);
                        command.Options.Add(RequestState);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Composio.PostToolRouterSessionBySessionIdExecuteMetaRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Composio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var sessionId = parseResult.GetRequiredValue(SessionId);
                        var slug = parseResult.GetRequiredValue(Slug);
                        var arguments = CliRuntime.WasSpecified(parseResult, ArgumentsOption) ? parseResult.GetValue(ArgumentsOption) : (__requestBase is { } __ArgumentsBaseValue ? __ArgumentsBaseValue.Arguments : default);
                        var inputResponses = CliRuntime.WasSpecified(parseResult, InputResponses) ? parseResult.GetValue(InputResponses) : (__requestBase is { } __InputResponsesBaseValue ? __InputResponsesBaseValue.InputResponses : default);
                        var requestState = CliRuntime.WasSpecified(parseResult, RequestState) ? parseResult.GetValue(RequestState) : (__requestBase is { } __RequestStateBaseValue ? __RequestStateBaseValue.RequestState : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ToolRouter.PostToolRouterSessionBySessionIdExecuteMetaAsync(
                                    sessionId: sessionId,
                                    slug: slug,
                                    arguments: arguments,
                                    inputResponses: inputResponses,
                                    requestState: requestState,
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