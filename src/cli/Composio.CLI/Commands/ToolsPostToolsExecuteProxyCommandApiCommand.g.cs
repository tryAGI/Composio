#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class ToolsPostToolsExecuteProxyCommandApiCommand
{
    private static Option<string?> ConnectedAccountId { get; } = new(
        name: @"--connected-account-id")
    {
        Description = @"The ID of the connected account to use for authentication (if not provided, will use the default account for the project)",
    };

    private static Option<string> Endpoint { get; } = new(
        name: @"--endpoint")
    {
        Description = @"The API endpoint to call (absolute URL or path relative to base URL of the connected account)",
        Required = true,
    };

    private static Option<global::Composio.PostToolsExecuteProxyRequestMethod> Method { get; } = new(
        name: @"--method")
    {
        Description = @"The HTTP method to use for the request",
        Required = true,
    };

    private static Option<object?> Body { get; } = new(
        name: @"--body")
    {
        Description = @"The request body (for POST, PUT, and PATCH requests)",
    };

    private static Option<global::Composio.AnyOf<global::Composio.PostToolsExecuteProxyRequestBinaryBodyVariant1, global::Composio.PostToolsExecuteProxyRequestBinaryBodyVariant2>?> BinaryBody { get; } = new(
        name: @"--binary-body")
    {
        Description = @"Binary body to send. For binary upload via URL: use {url: ""https://..."", content_type?: ""...""}. For binary upload via base64: use {base64: ""..."", content_type?: ""...""}.",
    };

    private static Option<global::System.Collections.Generic.IList<global::Composio.PostToolsExecuteProxyRequestParameter>?> Parameters { get; } = new(
        name: @"--parameters")
    {
        Description = @"Additional HTTP headers or query parameters to include in the request",
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

                    private static string FormatResponse(ParseResult parseResult, global::Composio.PostToolsExecuteProxyResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.PostToolsExecuteProxyResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"post-tools-execute-proxy", @"Execute proxy request
Proxy an HTTP request to a third-party API using connected account credentials. This endpoint allows making authenticated API calls to external services while abstracting away authentication details. The v3 endpoint is retired except for orgs explicitly allowlisted in LaunchDarkly during migration.");
                        command.Options.Add(ConnectedAccountId);
                        command.Options.Add(Endpoint);
                        command.Options.Add(Method);
                        command.Options.Add(Body);
                        command.Options.Add(BinaryBody);
                        command.Options.Add(Parameters);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Composio.PostToolsExecuteProxyRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Composio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var connectedAccountId = CliRuntime.WasSpecified(parseResult, ConnectedAccountId) ? parseResult.GetValue(ConnectedAccountId) : (__requestBase is { } __ConnectedAccountIdBaseValue ? __ConnectedAccountIdBaseValue.ConnectedAccountId : default);
                        var endpoint = parseResult.GetRequiredValue(Endpoint);
                        var method = parseResult.GetRequiredValue(Method);
                        var body = CliRuntime.WasSpecified(parseResult, Body) ? parseResult.GetValue(Body) : (__requestBase is { } __BodyBaseValue ? __BodyBaseValue.Body : default);
                        var binaryBody = CliRuntime.WasSpecified(parseResult, BinaryBody) ? parseResult.GetValue(BinaryBody) : (__requestBase is { } __BinaryBodyBaseValue ? __BinaryBodyBaseValue.BinaryBody : default);
                        var parameters = CliRuntime.WasSpecified(parseResult, Parameters) ? parseResult.GetValue(Parameters) : (__requestBase is { } __ParametersBaseValue ? __ParametersBaseValue.Parameters : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Tools.PostToolsExecuteProxyAsync(
                                    connectedAccountId: connectedAccountId,
                                    endpoint: endpoint,
                                    method: method,
                                    body: body,
                                    binaryBody: binaryBody,
                                    parameters: parameters,
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