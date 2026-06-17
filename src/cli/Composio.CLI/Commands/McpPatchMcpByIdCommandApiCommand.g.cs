#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class McpPatchMcpByIdCommandApiCommand
{
    private static Argument<string> Id { get; } = new(
        name: @"id")
    {
        Description = @"The ID of the MCP server",
    };

    private static Option<string?> NameOption { get; } = new(
        name: @"--name")
    {
        Description = @"Human-readable name to identify this MCP server instance (4-30 characters, alphanumeric, spaces, and hyphens only)",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> Toolkits { get; } = new(
        name: @"--toolkits")
    {
        Description = @"List of toolkit slugs this server should be configured to work with.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> AllowedTools { get; } = new(
        name: @"--allowed-tools")
    {
        Description = @"List of action identifiers that should be enabled for this server",
    };

    private static Option<bool?> ManagedAuthViaComposio { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--managed-auth-via-composio",
        description: @"Whether the MCP server is managed by Composio");

    private static Option<global::System.Collections.Generic.IList<string>?> AuthConfigIds { get; } = new(
        name: @"--auth-config-ids")
    {
        Description = @"List of auth config IDs to use for this MCP server.",
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

                    private static string FormatResponse(ParseResult parseResult, global::Composio.PatchMcpByIdResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.PatchMcpByIdResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"patch-mcp-by-id", @"Update MCP server configuration
Updates the configuration of an existing Model Control Protocol (MCP) server. You can modify the server name, associated applications, and enabled tools. Only the fields included in the request will be updated.");
                        command.Arguments.Add(Id);
                        command.Options.Add(NameOption);
                        command.Options.Add(Toolkits);
                        command.Options.Add(AllowedTools);
                        command.Options.Add(ManagedAuthViaComposio);
                        command.Options.Add(AuthConfigIds);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Composio.PatchMcpByIdRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Composio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var id = parseResult.GetRequiredValue(Id);
                        var name = CliRuntime.WasSpecified(parseResult, NameOption) ? parseResult.GetValue(NameOption) : (__requestBase is { } __NameBaseValue ? __NameBaseValue.Name : default);
                        var toolkits = CliRuntime.WasSpecified(parseResult, Toolkits) ? parseResult.GetValue(Toolkits) : (__requestBase is { } __ToolkitsBaseValue ? __ToolkitsBaseValue.Toolkits : default);
                        var allowedTools = CliRuntime.WasSpecified(parseResult, AllowedTools) ? parseResult.GetValue(AllowedTools) : (__requestBase is { } __AllowedToolsBaseValue ? __AllowedToolsBaseValue.AllowedTools : default);
                        var managedAuthViaComposio = CliRuntime.WasSpecified(parseResult, ManagedAuthViaComposio) ? parseResult.GetValue(ManagedAuthViaComposio) : (__requestBase is { } __ManagedAuthViaComposioBaseValue ? __ManagedAuthViaComposioBaseValue.ManagedAuthViaComposio : default);
                        var authConfigIds = CliRuntime.WasSpecified(parseResult, AuthConfigIds) ? parseResult.GetValue(AuthConfigIds) : (__requestBase is { } __AuthConfigIdsBaseValue ? __AuthConfigIdsBaseValue.AuthConfigIds : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Mcp.PatchMcpByIdAsync(
                                    id: id,
                                    name: name,
                                    toolkits: toolkits,
                                    allowedTools: allowedTools,
                                    managedAuthViaComposio: managedAuthViaComposio,
                                    authConfigIds: authConfigIds,
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