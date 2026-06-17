#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class McpPostMcpServersGenerateCommandApiCommand
{
    private static Option<string> McpServerId { get; } = new(
        name: @"--mcp-server-id")
    {
        Description = @"Unique identifier of the MCP server to generate URL for",
        Required = true,
    };

    private static Option<bool?> ManagedAuthByComposio { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--managed-auth-by-composio",
        description: @"Flag indicating if Composio manages authentication");

    private static Option<global::System.Collections.Generic.IList<string>?> UserIds { get; } = new(
        name: @"--user-ids")
    {
        Description = @"List of user identifiers for whom the URL is generated",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> ConnectedAccountIds { get; } = new(
        name: @"--connected-account-ids")
    {
        Description = @"List of connected account identifiers",
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

                    private static string FormatResponse(ParseResult parseResult, global::Composio.PostMcpServersGenerateResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.PostMcpServersGenerateResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"post-mcp-servers-generate", @"Generate MCP URL with custom parameters
Generates a Model Control Protocol (MCP) URL for an existing server with custom query parameters. The URL includes user-specific parameters and configuration flags that control the behavior of the MCP connection.");
                        command.Options.Add(McpServerId);
                        command.Options.Add(ManagedAuthByComposio);
                        command.Options.Add(UserIds);
                        command.Options.Add(ConnectedAccountIds);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Composio.PostMcpServersGenerateRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Composio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var mcpServerId = parseResult.GetRequiredValue(McpServerId);
                        var managedAuthByComposio = CliRuntime.WasSpecified(parseResult, ManagedAuthByComposio) ? parseResult.GetValue(ManagedAuthByComposio) : (__requestBase is { } __ManagedAuthByComposioBaseValue ? __ManagedAuthByComposioBaseValue.ManagedAuthByComposio : default);
                        var userIds = CliRuntime.WasSpecified(parseResult, UserIds) ? parseResult.GetValue(UserIds) : (__requestBase is { } __UserIdsBaseValue ? __UserIdsBaseValue.UserIds : default);
                        var connectedAccountIds = CliRuntime.WasSpecified(parseResult, ConnectedAccountIds) ? parseResult.GetValue(ConnectedAccountIds) : (__requestBase is { } __ConnectedAccountIdsBaseValue ? __ConnectedAccountIdsBaseValue.ConnectedAccountIds : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Mcp.PostMcpServersGenerateAsync(
                                    mcpServerId: mcpServerId,
                                    managedAuthByComposio: managedAuthByComposio,
                                    userIds: userIds,
                                    connectedAccountIds: connectedAccountIds,
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