#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class ToolRouterPostToolRouterSessionBySessionIdSearchCommandApiCommand
{
    private static Argument<string> SessionId { get; } = new(
        name: @"session-id")
    {
        Description = @"Tool router session ID (trs_*)",
    };

    private static Option<global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionBySessionIdSearchRequestQuerie>> Queries { get; } = new(
        name: @"--queries")
    {
        Description = @"List of search queries to execute in parallel. Up to 7 queries supported.",
        Required = true,
    };

    private static Option<string?> Model { get; } = new(
        name: @"--model")
    {
        Description = @"Optional model hint for search/planning behavior (e.g., ""gpt-4o""). Ignored if invalid.",
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

                    private static string FormatResponse(ParseResult parseResult, global::Composio.PostToolRouterSessionBySessionIdSearchResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.PostToolRouterSessionBySessionIdSearchResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"post-tool-router-session-by-session-id-search", @"Search for tools using a query
Search for tools matching a given use case query within a tool router session. Returns matching tool slugs, full tool schemas, toolkit connection statuses, and workflow guidance in a predictable format.");
                        command.Arguments.Add(SessionId);
                        command.Options.Add(Queries);
                        command.Options.Add(Model);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Composio.PostToolRouterSessionBySessionIdSearchRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Composio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var sessionId = parseResult.GetRequiredValue(SessionId);
                        var queries = parseResult.GetRequiredValue(Queries);
                        var model = CliRuntime.WasSpecified(parseResult, Model) ? parseResult.GetValue(Model) : (__requestBase is { } __ModelBaseValue ? __ModelBaseValue.Model : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ToolRouter.PostToolRouterSessionBySessionIdSearchAsync(
                                    sessionId: sessionId,
                                    queries: queries,
                                    model: model,
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