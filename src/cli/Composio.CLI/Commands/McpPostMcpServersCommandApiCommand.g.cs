#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class McpPostMcpServersCommandApiCommand
{
    private static Argument<string> NameOption { get; } = new(
        name: @"name")
    {
        Description = @"Human-readable name to identify this MCP server instance (4-30 characters, alphanumeric, spaces, and hyphens only)",
    };

    private static Option<global::System.Collections.Generic.IList<string>> AuthConfigIds { get; } = new(
        name: @"--auth-config-ids")
    {
        Description = @"ID references to existing authentication configurations",
        Required = true,
    };

    private static Option<global::System.Collections.Generic.IList<string>?> NoAuthApps { get; } = new(
        name: @"--no-auth-apps")
    {
        Description = @"List of NO_AUTH apps to enable for this MCP server",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> AllowedTools { get; } = new(
        name: @"--allowed-tools")
    {
        Description = @"List of tool slugs that should be allowed for this server. If not provided, all available tools for the authentication configuration will be enabled.",
    };

    private static Option<bool?> ManagedAuthViaComposio { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--managed-auth-via-composio",
        description: @"Whether the MCP server is managed by Composio");
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

                    private static string FormatResponse(ParseResult parseResult, global::Composio.PostMcpServersResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.PostMcpServersResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"post-mcp-servers", @"Create a new MCP server
Creates a new Model Control Protocol (MCP) server instance for the authenticated project. An MCP server provides a connection point for AI assistants to access your applications and services. The server is configured with specific authentication and tool permissions that determine what actions the connected assistants can perform.");
                        command.Arguments.Add(NameOption);
                        command.Options.Add(AuthConfigIds);
                        command.Options.Add(NoAuthApps);
                        command.Options.Add(AllowedTools);
                        command.Options.Add(ManagedAuthViaComposio);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Composio.PostMcpServersRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Composio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var name = parseResult.GetRequiredValue(NameOption);
                        var authConfigIds = parseResult.GetRequiredValue(AuthConfigIds);
                        var noAuthApps = CliRuntime.WasSpecified(parseResult, NoAuthApps) ? parseResult.GetValue(NoAuthApps) : (__requestBase is { } __NoAuthAppsBaseValue ? __NoAuthAppsBaseValue.NoAuthApps : default);
                        var allowedTools = CliRuntime.WasSpecified(parseResult, AllowedTools) ? parseResult.GetValue(AllowedTools) : (__requestBase is { } __AllowedToolsBaseValue ? __AllowedToolsBaseValue.AllowedTools : default);
                        var managedAuthViaComposio = CliRuntime.WasSpecified(parseResult, ManagedAuthViaComposio) ? parseResult.GetValue(ManagedAuthViaComposio) : (__requestBase is { } __ManagedAuthViaComposioBaseValue ? __ManagedAuthViaComposioBaseValue.ManagedAuthViaComposio : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Mcp.PostMcpServersAsync(
                                    name: name,
                                    authConfigIds: authConfigIds,
                                    noAuthApps: noAuthApps,
                                    allowedTools: allowedTools,
                                    managedAuthViaComposio: managedAuthViaComposio,
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