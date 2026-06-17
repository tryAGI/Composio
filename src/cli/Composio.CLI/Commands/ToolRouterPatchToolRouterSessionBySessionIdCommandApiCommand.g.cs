#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class ToolRouterPatchToolRouterSessionBySessionIdCommandApiCommand
{
    private static Argument<string> SessionId { get; } = new(
        name: @"session-id")
    {
        Description = @"The unique identifier of the tool router session",
    };

    private static Option<global::Composio.AnyOf<global::Composio.PatchToolRouterSessionBySessionIdRequestToolkitsVariant1, global::Composio.PatchToolRouterSessionBySessionIdRequestToolkitsVariant2>?> Toolkits { get; } = new(
        name: @"--toolkits")
    {
        Description = @"Toolkit configuration - specify either enable toolkits (allowlist) or disable toolkits (denylist). Mutually exclusive.",
    };

    private static Option<global::System.Collections.Generic.Dictionary<string, string>?> AuthConfigs { get; } = new(
        name: @"--auth-configs")
    {
        Description = @"The auth configs to use for the session. This will override the default behavior and use the given auth config when specific toolkits are being executed",
    };

    private static Option<global::System.Collections.Generic.Dictionary<string, string>?> ConnectedAccounts { get; } = new(
        name: @"--connected-accounts")
    {
        Description = @"Per-toolkit connected account override (single nano-ID). Each connected account must exist (not deleted or disabled) and belong to the same `user_id` as the session.",
    };

    private static Option<global::Composio.PatchToolRouterSessionBySessionIdRequestManageConnections?> ManageConnections { get; } = new(
        name: @"--manage-connections")
    {
        Description = @"",
    };

    private static Option<object?> Tools { get; } = new(
        name: @"--tools")
    {
        Description = @"Tool-level configuration per toolkit. Allows you to enable, disable, or filter by tags for specific tools within each toolkit. Every slug passed in `enable` / `disable` must be a valid Composio tool slug for that toolkit — invalid or typo'd slugs fail session creation with a clear error listing which ones didn't match.",
    };

    private static Option<global::Composio.AnyOf<global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdRequestTag>, global::Composio.PatchToolRouterSessionBySessionIdRequestTags>?> Tags { get; } = new(
        name: @"--tags")
    {
        Description = @"Global MCP tool annotation hints for filtering. Array format is treated as enabled list. Object format supports both enabled (tool must have at least one) and disabled (tool must NOT have any) lists. Toolkit-level tags override this. Toolkit enabled/disabled lists take precedence over tag filtering.",
    };

    private static Option<global::Composio.PatchToolRouterSessionBySessionIdRequestWorkbench?> Workbench { get; } = new(
        name: @"--workbench")
    {
        Description = @"",
    };

    private static Option<global::Composio.PatchToolRouterSessionBySessionIdRequestMultiAccount?> MultiAccount { get; } = new(
        name: @"--multi-account")
    {
        Description = @"",
    };

    private static Option<global::Composio.PatchToolRouterSessionBySessionIdRequestPreload?> Preload { get; } = new(
        name: @"--preload")
    {
        Description = @"Preload configuration for Composio tools. Controls which tools appear in `session.tools` and the MCP server tool list so the agent can call them directly without going through search first. Custom tools use `preload` on the custom tool/toolkit definition instead. Not supported when multi-account is enabled. Each preloaded tool adds to the agent context window, so keep the list at or under ~20 tools.",
    };

    private static Option<global::Composio.PatchToolRouterSessionBySessionIdRequestExperimental?> Experimental { get; } = new(
        name: @"--experimental")
    {
        Description = @"",
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

                    private static string FormatResponse(ParseResult parseResult, global::Composio.PatchToolRouterSessionBySessionIdResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.PatchToolRouterSessionBySessionIdResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"patch-tool-router-session-by-session-id", @"Patch a tool router session config
Partially updates the configuration of an existing tool router session. Only the fields provided in the request body will be updated. Uses optimistic concurrency control to prevent lost updates. The previous config is stored in config history.");
                        command.Arguments.Add(SessionId);
                        command.Options.Add(Toolkits);
                        command.Options.Add(AuthConfigs);
                        command.Options.Add(ConnectedAccounts);
                        command.Options.Add(ManageConnections);
                        command.Options.Add(Tools);
                        command.Options.Add(Tags);
                        command.Options.Add(Workbench);
                        command.Options.Add(MultiAccount);
                        command.Options.Add(Preload);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Composio.PatchToolRouterSessionBySessionIdRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Composio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var sessionId = parseResult.GetRequiredValue(SessionId);
                        var toolkits = CliRuntime.WasSpecified(parseResult, Toolkits) ? parseResult.GetValue(Toolkits) : (__requestBase is { } __ToolkitsBaseValue ? __ToolkitsBaseValue.Toolkits : default);
                        var authConfigs = CliRuntime.WasSpecified(parseResult, AuthConfigs) ? parseResult.GetValue(AuthConfigs) : (__requestBase is { } __AuthConfigsBaseValue ? __AuthConfigsBaseValue.AuthConfigs : default);
                        var connectedAccounts = CliRuntime.WasSpecified(parseResult, ConnectedAccounts) ? parseResult.GetValue(ConnectedAccounts) : (__requestBase is { } __ConnectedAccountsBaseValue ? __ConnectedAccountsBaseValue.ConnectedAccounts : default);
                        var manageConnections = CliRuntime.WasSpecified(parseResult, ManageConnections) ? parseResult.GetValue(ManageConnections) : (__requestBase is { } __ManageConnectionsBaseValue ? __ManageConnectionsBaseValue.ManageConnections : default);
                        var tools = CliRuntime.WasSpecified(parseResult, Tools) ? parseResult.GetValue(Tools) : (__requestBase is { } __ToolsBaseValue ? __ToolsBaseValue.Tools : default);
                        var tags = CliRuntime.WasSpecified(parseResult, Tags) ? parseResult.GetValue(Tags) : (__requestBase is { } __TagsBaseValue ? __TagsBaseValue.Tags : default);
                        var workbench = CliRuntime.WasSpecified(parseResult, Workbench) ? parseResult.GetValue(Workbench) : (__requestBase is { } __WorkbenchBaseValue ? __WorkbenchBaseValue.Workbench : default);
                        var multiAccount = CliRuntime.WasSpecified(parseResult, MultiAccount) ? parseResult.GetValue(MultiAccount) : (__requestBase is { } __MultiAccountBaseValue ? __MultiAccountBaseValue.MultiAccount : default);
                        var preload = CliRuntime.WasSpecified(parseResult, Preload) ? parseResult.GetValue(Preload) : (__requestBase is { } __PreloadBaseValue ? __PreloadBaseValue.Preload : default);
                        var experimental = CliRuntime.WasSpecified(parseResult, Experimental) ? parseResult.GetValue(Experimental) : (__requestBase is { } __ExperimentalBaseValue ? __ExperimentalBaseValue.Experimental : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ToolRouter.PatchToolRouterSessionBySessionIdAsync(
                                    sessionId: sessionId,
                                    toolkits: toolkits,
                                    authConfigs: authConfigs,
                                    connectedAccounts: connectedAccounts,
                                    manageConnections: manageConnections,
                                    tools: tools,
                                    tags: tags,
                                    workbench: workbench,
                                    multiAccount: multiAccount,
                                    preload: preload,
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