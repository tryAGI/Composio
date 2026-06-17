#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class CliPostCliCodactFailuresCommandApiCommand
{
    private static Option<string> XUserApiKey { get; } = new(
        name: @"--x-user-api-key")
    {
        Description = @"User API key used to authenticate the CLI codact failure.",
        Required = true,
    };

    private static Option<global::Composio.PostCliCodactFailuresRequestFailureType> FailureType { get; } = new(
        name: @"--failure-type")
    {
        Description = @"Type of codact failure being recorded.",
        Required = true,
    };

    private static Option<global::Composio.PostCliCodactFailuresRequestToolInfo?> ToolInfo { get; } = new(
        name: @"--tool-info")
    {
        Description = @"Optional tool metadata when the failure can be tied to a toolkit or concrete tool version.",
    };

    private static Option<global::System.Collections.Generic.Dictionary<string, object?>> Ctx { get; } = new(
        name: @"--ctx")
    {
        Description = @"Arbitrary failure context from the CLI.",
        Required = true,
    };

    private static Option<global::System.Collections.Generic.Dictionary<string, object?>> Session { get; } = new(
        name: @"--session")
    {
        Description = @"Arbitrary session payload from the CLI.",
        Required = true,
    };

    private static Option<string?> RequestId { get; } = new(
        name: @"--request-id")
    {
        Description = @"Optional request identifier associated with the failure.",
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

                    private static string FormatResponse(ParseResult parseResult, global::Composio.PostCliCodactFailuresResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.PostCliCodactFailuresResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"post-cli-codact-failures", @"Ingest CLI codact failures
Accepts CLI-reported codact failures authenticated by user API key and stores them in ClickHouse for later analysis.");
                        command.Options.Add(XUserApiKey);
                        command.Options.Add(FailureType);
                        command.Options.Add(ToolInfo);
                        command.Options.Add(Ctx);
                        command.Options.Add(Session);
                        command.Options.Add(RequestId);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Composio.PostCliCodactFailuresRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Composio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var xUserApiKey = parseResult.GetRequiredValue(XUserApiKey);
                        var failureType = parseResult.GetRequiredValue(FailureType);
                        var toolInfo = CliRuntime.WasSpecified(parseResult, ToolInfo) ? parseResult.GetValue(ToolInfo) : (__requestBase is { } __ToolInfoBaseValue ? __ToolInfoBaseValue.ToolInfo : default);
                        var ctx = parseResult.GetRequiredValue(Ctx);
                        var session = parseResult.GetRequiredValue(Session);
                        var requestId = CliRuntime.WasSpecified(parseResult, RequestId) ? parseResult.GetValue(RequestId) : (__requestBase is { } __RequestIdBaseValue ? __RequestIdBaseValue.RequestId : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Cli.PostCliCodactFailuresAsync(
                                    xUserApiKey: xUserApiKey,
                                    failureType: failureType,
                                    toolInfo: toolInfo,
                                    ctx: ctx,
                                    session: session,
                                    requestId: requestId,
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