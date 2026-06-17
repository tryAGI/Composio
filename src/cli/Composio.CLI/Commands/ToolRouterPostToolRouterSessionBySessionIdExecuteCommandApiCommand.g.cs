#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class ToolRouterPostToolRouterSessionBySessionIdExecuteCommandApiCommand
{
    private static Argument<string?> SessionId { get; } = new(
        name: @"session-id")
    {
        Description = @"Tool router session ID (required for public API, optional for internal - injected by middleware)",
    };

    private static Option<string> ToolSlug { get; } = new(
        name: @"--tool-slug")
    {
        Description = @"The unique slug identifier of the tool to execute. Supports both meta tools and app tools exposed by the session.",
        Required = true,
    };

    private static Option<global::System.Collections.Generic.Dictionary<string, object?>?> ArgumentsOption { get; } = new(
        name: @"--arguments")
    {
        Description = @"The arguments required by the tool",
    };

    private static Option<string?> Account { get; } = new(
        name: @"--account")
    {
        Description = @"Account identifier to specify which connected account to use for direct tool execution. Use the account ID (e.g. ""coup_hurricane_dal_analytical"") or an alias. When omitted with a single account, the default is used. When omitted with multiple accounts, an error lists available accounts. Meta/helper tools either ignore this top-level field or define their own account-selection fields, for example COMPOSIO_MULTI_EXECUTE_TOOL.tools[].account.",
    };

    private static Option<bool?> EnableAutoWorkbenchOffload { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--enable-auto-workbench-offload",
        description: @"When true, direct non-meta tool execution may return a workbench offload preview if the response exceeds the configured threshold and the session workbench is enabled. When omitted or false, direct tool execution returns the normal inline response. Meta/helper tools are unaffected, and COMPOSIO_MULTI_EXECUTE_TOOL uses session.workbench configuration for its own batch-level offload behavior.");
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

                    private static string FormatResponse(ParseResult parseResult, global::Composio.PostToolRouterSessionBySessionIdExecuteResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.PostToolRouterSessionBySessionIdExecuteResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"post-tool-router-session-by-session-id-execute", @"Execute a tool within a tool router session
Executes a specific tool within a tool router session. This is the primary execution endpoint for both meta tools and app tools exposed by the session. The toolkit is automatically inferred from the tool slug. For app tools, the tool must belong to an allowed toolkit and must not be disabled in the session configuration. The endpoint validates permissions, resolves connected accounts when needed, and executes the tool with the session context. The top-level account field applies only to direct app tool execution in multi-account sessions. Meta/helper tools either ignore it or define their own account-selection fields, for example COMPOSIO_MULTI_EXECUTE_TOOL.tools[].account.");
                        command.Arguments.Add(SessionId);
                        command.Options.Add(ToolSlug);
                        command.Options.Add(ArgumentsOption);
                        command.Options.Add(Account);
                        command.Options.Add(EnableAutoWorkbenchOffload);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Composio.PostToolRouterSessionBySessionIdExecuteRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Composio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var sessionId = parseResult.GetRequiredValue(SessionId);
                        var toolSlug = parseResult.GetRequiredValue(ToolSlug);
                        var arguments = CliRuntime.WasSpecified(parseResult, ArgumentsOption) ? parseResult.GetValue(ArgumentsOption) : (__requestBase is { } __ArgumentsBaseValue ? __ArgumentsBaseValue.Arguments : default);
                        var account = CliRuntime.WasSpecified(parseResult, Account) ? parseResult.GetValue(Account) : (__requestBase is { } __AccountBaseValue ? __AccountBaseValue.Account : default);
                        var enableAutoWorkbenchOffload = CliRuntime.WasSpecified(parseResult, EnableAutoWorkbenchOffload) ? parseResult.GetValue(EnableAutoWorkbenchOffload) : (__requestBase is { } __EnableAutoWorkbenchOffloadBaseValue ? __EnableAutoWorkbenchOffloadBaseValue.EnableAutoWorkbenchOffload : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ToolRouter.PostToolRouterSessionBySessionIdExecuteAsync(
                                    sessionId: sessionId,
                                    toolSlug: toolSlug,
                                    arguments: arguments,
                                    account: account,
                                    enableAutoWorkbenchOffload: enableAutoWorkbenchOffload,
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