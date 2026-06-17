#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class McpPostMcpServersCustomCommandApiCommand
{
    private static Argument<string> NameOption { get; } = new(
        name: @"name")
    {
        Description = @"Human-readable name to identify this custom MCP server (4-30 characters, alphanumeric, spaces, and hyphens only)",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> AuthConfigIds { get; } = new(
        name: @"--auth-config-ids")
    {
        Description = @"ID references to existing authentication configurations",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> Toolkits { get; } = new(
        name: @"--toolkits")
    {
        Description = @"List of application/toolkit identifiers to enable for this server",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> AllowedTools { get; } = new(
        name: @"--allowed-tools")
    {
        Description = @"Tool identifiers to enable that aren't part of standard toolkits",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> CustomTools { get; } = new(
        name: @"--custom-tools")
    {
        Description = @"DEPRECATED: Use allowed_tools instead. Tool identifiers to enable that aren't part of standard toolkits",
    };

    private static Option<bool?> ManagedAuthViaComposio { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--managed-auth-via-composio",
        description: @"Whether to manage authentication via Composio");
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

                    private static string FormatResponse(ParseResult parseResult, global::Composio.PostMcpServersCustomResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.PostMcpServersCustomResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"post-mcp-servers-custom", @"Create a new custom MCP server with multiple apps
Creates a new Model Control Protocol (MCP) server instance that can integrate with multiple applications or toolkits simultaneously. This endpoint allows you to create a server that can access tools from different applications, making it suitable for complex workflows that span multiple services.");
                        command.Arguments.Add(NameOption);
                        command.Options.Add(AuthConfigIds);
                        command.Options.Add(Toolkits);
                        command.Options.Add(AllowedTools);
                        command.Options.Add(CustomTools);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Composio.PostMcpServersCustomRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Composio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var name = parseResult.GetRequiredValue(NameOption);
                        var authConfigIds = CliRuntime.WasSpecified(parseResult, AuthConfigIds) ? parseResult.GetValue(AuthConfigIds) : (__requestBase is { } __AuthConfigIdsBaseValue ? __AuthConfigIdsBaseValue.AuthConfigIds : default);
                        var toolkits = CliRuntime.WasSpecified(parseResult, Toolkits) ? parseResult.GetValue(Toolkits) : (__requestBase is { } __ToolkitsBaseValue ? __ToolkitsBaseValue.Toolkits : default);
                        var allowedTools = CliRuntime.WasSpecified(parseResult, AllowedTools) ? parseResult.GetValue(AllowedTools) : (__requestBase is { } __AllowedToolsBaseValue ? __AllowedToolsBaseValue.AllowedTools : default);
                        var customTools = CliRuntime.WasSpecified(parseResult, CustomTools) ? parseResult.GetValue(CustomTools) : (__requestBase is { } __CustomToolsBaseValue ? __CustomToolsBaseValue.CustomTools : default);
                        var managedAuthViaComposio = CliRuntime.WasSpecified(parseResult, ManagedAuthViaComposio) ? parseResult.GetValue(ManagedAuthViaComposio) : (__requestBase is { } __ManagedAuthViaComposioBaseValue ? __ManagedAuthViaComposioBaseValue.ManagedAuthViaComposio : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Mcp.PostMcpServersCustomAsync(
                                    name: name,
                                    authConfigIds: authConfigIds,
                                    toolkits: toolkits,
                                    allowedTools: allowedTools,
                                    customTools: customTools,
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