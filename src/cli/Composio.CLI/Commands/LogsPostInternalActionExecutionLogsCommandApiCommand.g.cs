#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class LogsPostInternalActionExecutionLogsCommandApiCommand
{
    private static Option<double?> Cursor { get; } = new(
        name: @"--cursor")
    {
        Description = @"cursor_that_can_be_used_to_paginate_through_the_logs",
    };

    private static Option<double?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"number_of_logs_to_return",
    };

    private static Option<bool?> CaseSensitive { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--case-sensitive",
        description: @"whether_the_search_is_case_sensitive_or_not");

    private static Option<double?> From { get; } = new(
        name: @"--from")
    {
        Description = @"start_time_of_the_logs_in_epoch_time",
    };

    private static Option<double?> To { get; } = new(
        name: @"--to")
    {
        Description = @"end_time_of_the_logs_in_epoch_time",
    };

    private static Option<global::System.Collections.Generic.IList<global::Composio.PostInternalActionExecutionLogsRequestSearchParam>?> SearchParams { get; } = new(
        name: @"--search-params")
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

                    private static string FormatResponse(ParseResult parseResult, global::Composio.PostInternalActionExecutionLogsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.PostInternalActionExecutionLogsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"post-internal-action-execution-logs", @"Search and retrieve action execution logs");
                        command.Options.Add(Cursor);
                        command.Options.Add(Limit);
                        command.Options.Add(CaseSensitive);
                        command.Options.Add(From);
                        command.Options.Add(To);
                        command.Options.Add(SearchParams);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Composio.PostInternalActionExecutionLogsRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Composio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var cursor = CliRuntime.WasSpecified(parseResult, Cursor) ? parseResult.GetValue(Cursor) : (__requestBase is { } __CursorBaseValue ? __CursorBaseValue.Cursor : default);
                        var limit = CliRuntime.WasSpecified(parseResult, Limit) ? parseResult.GetValue(Limit) : (__requestBase is { } __LimitBaseValue ? __LimitBaseValue.Limit : default);
                        var caseSensitive = CliRuntime.WasSpecified(parseResult, CaseSensitive) ? parseResult.GetValue(CaseSensitive) : (__requestBase is { } __CaseSensitiveBaseValue ? __CaseSensitiveBaseValue.CaseSensitive : default);
                        var from = CliRuntime.WasSpecified(parseResult, From) ? parseResult.GetValue(From) : (__requestBase is { } __FromBaseValue ? __FromBaseValue.From : default);
                        var to = CliRuntime.WasSpecified(parseResult, To) ? parseResult.GetValue(To) : (__requestBase is { } __ToBaseValue ? __ToBaseValue.To : default);
                        var searchParams = CliRuntime.WasSpecified(parseResult, SearchParams) ? parseResult.GetValue(SearchParams) : (__requestBase is { } __SearchParamsBaseValue ? __SearchParamsBaseValue.SearchParams : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Logs.PostInternalActionExecutionLogsAsync(
                                    cursor: cursor,
                                    limit: limit,
                                    caseSensitive: caseSensitive,
                                    from: from,
                                    to: to,
                                    searchParams: searchParams,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Composio.SourceGenerationContext.Default,
                                        @"Data",
                                        cancellationToken).ConfigureAwait(false))
                                {
                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Composio.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}