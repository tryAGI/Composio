#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class ToolsPostToolsExecuteByToolSlugCommandApiCommand
{
    private static Argument<string> ToolSlug { get; } = new(
        name: @"tool-slug")
    {
        Description = @"The tool slug to execute",
    };

    private static Option<string?> XLlmGatewayHeaders { get; } = new(
        name: @"--x-llm-gateway-headers")
    {
        Description = @"JSON object containing custom headers to pass to LLM providers (OpenAI, Bedrock, etc.)",
    };

    private static Option<string?> ConnectedAccountId { get; } = new(
        name: @"--connected-account-id")
    {
        Description = @"Unique identifier for the connected account to use for authentication",
    };

    private static Option<string?> UserId { get; } = new(
        name: @"--user-id")
    {
        Description = @"User id for multi-user connected accounts (e.g. multiple users, organizations)",
    };

    private static Option<string?> Version { get; } = new(
        name: @"--version")
    {
        Description = @"Tool version to execute (defaults to ""00000000_00"" if not specified)",
    };

    private static Option<global::Composio.PostToolsExecuteByToolSlugRequestCustomAuthParams?> CustomAuthParams { get; } = new(
        name: @"--custom-auth-params")
    {
        Description = @"Custom authentication parameters for tools that support parameterized authentication",
    };

    private static Option<global::Composio.OneOf<global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant1, global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant2, global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant3, global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant4, global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant5, global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant6, global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant7, global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant8, global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant9, global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant10, global::Composio.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant11>?> CustomConnectionData { get; } = new(
        name: @"--custom-connection-data")
    {
        Description = @"Custom connection data for tools that support custom connection data",
    };

    private static Option<global::System.Collections.Generic.Dictionary<string, object?>?> ArgumentsOption { get; } = new(
        name: @"--arguments")
    {
        Description = @"Key-value pairs of arguments required by the tool (mutually exclusive with text)",
    };

    private static Option<string?> Text { get; } = new(
        name: @"--text")
    {
        Description = @"Natural language description of the task to perform (mutually exclusive with arguments)",
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

                    private static string FormatResponse(ParseResult parseResult, global::Composio.PostToolsExecuteByToolSlugResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.PostToolsExecuteByToolSlugResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"post-tools-execute-by-tool-slug", @"Execute tool
Execute a specific tool operation with provided arguments and authentication. This is the primary endpoint for integrating with third-party services and executing tools. You can provide structured arguments or use natural language processing by providing a text description of what you want to accomplish.");
                        command.Arguments.Add(ToolSlug);
                        command.Options.Add(XLlmGatewayHeaders);
                        command.Options.Add(ConnectedAccountId);
                        command.Options.Add(UserId);
                        command.Options.Add(Version);
                        command.Options.Add(CustomAuthParams);
                        command.Options.Add(CustomConnectionData);
                        command.Options.Add(ArgumentsOption);
                        command.Options.Add(Text);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Composio.PostToolsExecuteByToolSlugRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Composio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var toolSlug = parseResult.GetRequiredValue(ToolSlug);
                        var xLlmGatewayHeaders = parseResult.GetValue(XLlmGatewayHeaders);
                        var connectedAccountId = CliRuntime.WasSpecified(parseResult, ConnectedAccountId) ? parseResult.GetValue(ConnectedAccountId) : (__requestBase is { } __ConnectedAccountIdBaseValue ? __ConnectedAccountIdBaseValue.ConnectedAccountId : default);
                        var userId = CliRuntime.WasSpecified(parseResult, UserId) ? parseResult.GetValue(UserId) : (__requestBase is { } __UserIdBaseValue ? __UserIdBaseValue.UserId : default);
                        var version = CliRuntime.WasSpecified(parseResult, Version) ? parseResult.GetValue(Version) : (__requestBase is { } __VersionBaseValue ? __VersionBaseValue.Version : default);
                        var customAuthParams = CliRuntime.WasSpecified(parseResult, CustomAuthParams) ? parseResult.GetValue(CustomAuthParams) : (__requestBase is { } __CustomAuthParamsBaseValue ? __CustomAuthParamsBaseValue.CustomAuthParams : default);
                        var customConnectionData = CliRuntime.WasSpecified(parseResult, CustomConnectionData) ? parseResult.GetValue(CustomConnectionData) : (__requestBase is { } __CustomConnectionDataBaseValue ? __CustomConnectionDataBaseValue.CustomConnectionData : default);
                        var arguments = CliRuntime.WasSpecified(parseResult, ArgumentsOption) ? parseResult.GetValue(ArgumentsOption) : (__requestBase is { } __ArgumentsBaseValue ? __ArgumentsBaseValue.Arguments : default);
                        var text = CliRuntime.WasSpecified(parseResult, Text) ? parseResult.GetValue(Text) : (__requestBase is { } __TextBaseValue ? __TextBaseValue.Text : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Tools.PostToolsExecuteByToolSlugAsync(
                                    toolSlug: toolSlug,
                                    xLlmGatewayHeaders: xLlmGatewayHeaders,
                                    connectedAccountId: connectedAccountId,
                                    userId: userId,
                                    version: version,
                                    customAuthParams: customAuthParams,
                                    customConnectionData: customConnectionData,
                                    arguments: arguments,
                                    text: text,
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