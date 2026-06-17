#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class ToolRouterPostToolRouterSessionBySessionIdProxyExecuteCommandApiCommand
{
    private static Argument<string?> SessionId { get; } = new(
        name: @"session-id")
    {
        Description = @"Tool router session ID (required for public API, optional for internal - injected by middleware)",
    };

    private static Option<string> ToolkitSlug { get; } = new(
        name: @"--toolkit-slug")
    {
        Description = @"The slug of the toolkit to use for the request",
        Required = true,
    };

    private static Option<string> Endpoint { get; } = new(
        name: @"--endpoint")
    {
        Description = @"The API endpoint to call (absolute URL or path relative to base URL of the connected account)",
        Required = true,
    };

    private static Option<global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestMethod> Method { get; } = new(
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

    private static Option<global::Composio.AnyOf<global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestBinaryBodyVariant1, global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestBinaryBodyVariant2>?> BinaryBody { get; } = new(
        name: @"--binary-body")
    {
        Description = @"Binary body to send. For binary upload via URL: use {url: ""https://..."", content_type?: ""...""}. For binary upload via base64: use {base64: ""..."", content_type?: ""...""}.",
    };

    private static Option<global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestParameter>?> Parameters { get; } = new(
        name: @"--parameters")
    {
        Description = @"Additional HTTP headers or query parameters to include in the request",
    };

    private static Option<global::Composio.OneOf<global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant1, global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant2, global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant3, global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant4, global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant5, global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant6, global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant7, global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant8, global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant9, global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant10, global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant11>?> CustomConnectionData { get; } = new(
        name: @"--custom-connection-data")
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

                    private static string FormatResponse(ParseResult parseResult, global::Composio.PostToolRouterSessionBySessionIdProxyExecuteResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.PostToolRouterSessionBySessionIdProxyExecuteResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"post-tool-router-session-by-session-id-proxy-execute", @"Execute proxy request within a tool router session
Execute any native API call on a toolkit with authentication automatically injected from Composio. This endpoint proxies HTTP requests to third-party APIs using connected account credentials resolved from the session context. Provide the toolkit slug, API endpoint, and HTTP method — Composio handles authentication injection, abstracting away credential management. Supports all HTTP methods, custom headers/query parameters, and binary request/response bodies.");
                        command.Arguments.Add(SessionId);
                        command.Options.Add(ToolkitSlug);
                        command.Options.Add(Endpoint);
                        command.Options.Add(Method);
                        command.Options.Add(Body);
                        command.Options.Add(BinaryBody);
                        command.Options.Add(Parameters);
                        command.Options.Add(CustomConnectionData);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Composio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var sessionId = parseResult.GetRequiredValue(SessionId);
                        var toolkitSlug = parseResult.GetRequiredValue(ToolkitSlug);
                        var endpoint = parseResult.GetRequiredValue(Endpoint);
                        var method = parseResult.GetRequiredValue(Method);
                        var body = CliRuntime.WasSpecified(parseResult, Body) ? parseResult.GetValue(Body) : (__requestBase is { } __BodyBaseValue ? __BodyBaseValue.Body : default);
                        var binaryBody = CliRuntime.WasSpecified(parseResult, BinaryBody) ? parseResult.GetValue(BinaryBody) : (__requestBase is { } __BinaryBodyBaseValue ? __BinaryBodyBaseValue.BinaryBody : default);
                        var parameters = CliRuntime.WasSpecified(parseResult, Parameters) ? parseResult.GetValue(Parameters) : (__requestBase is { } __ParametersBaseValue ? __ParametersBaseValue.Parameters : default);
                        var customConnectionData = CliRuntime.WasSpecified(parseResult, CustomConnectionData) ? parseResult.GetValue(CustomConnectionData) : (__requestBase is { } __CustomConnectionDataBaseValue ? __CustomConnectionDataBaseValue.CustomConnectionData : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ToolRouter.PostToolRouterSessionBySessionIdProxyExecuteAsync(
                                    sessionId: sessionId,
                                    toolkitSlug: toolkitSlug,
                                    endpoint: endpoint,
                                    method: method,
                                    body: body,
                                    binaryBody: binaryBody,
                                    parameters: parameters,
                                    customConnectionData: customConnectionData,
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