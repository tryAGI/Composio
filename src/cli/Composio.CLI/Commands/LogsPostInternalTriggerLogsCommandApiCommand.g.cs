#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class LogsPostInternalTriggerLogsCommandApiCommand
{
    private static Option<global::Composio.PostInternalTriggerLogsRequestTime?> Time { get; } = new(
        name: @"--time")
    {
        Description = @"Return logs from the last N time units",
    };

    private static Option<double?> From { get; } = new(
        name: @"--from")
    {
        Description = @"Start time for logs (epoch timestamp in milliseconds)",
    };

    private static Option<double?> To { get; } = new(
        name: @"--to")
    {
        Description = @"End time for logs (epoch timestamp in milliseconds)",
    };

    private static Option<global::Composio.PostInternalTriggerLogsRequestStatus?> Status { get; } = new(
        name: @"--status")
    {
        Description = @"Filter logs by their status level",
    };

    private static Option<string?> Search { get; } = new(
        name: @"--search")
    {
        Description = @"Search term to filter logs",
    };

    private static Option<global::System.Guid?> IntegrationId { get; } = new(
        name: @"--integration-id")
    {
        Description = @"",
    };

    private static Option<string?> EntityId { get; } = new(
        name: @"--entity-id")
    {
        Description = @"",
    };

    private static Option<string?> UserId { get; } = new(
        name: @"--user-id")
    {
        Description = @"Filter logs by user ID",
    };

    private static Option<double?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"The limit of trigger logs to return",
    };

    private static Option<string?> Cursor { get; } = new(
        name: @"--cursor")
    {
        Description = @"",
    };

    private static Option<global::System.Collections.Generic.IList<global::Composio.PostInternalTriggerLogsRequestSearchParam>?> SearchParams { get; } = new(
        name: @"--search-params")
    {
        Description = @"Advanced search parameters for filtering logs",
    };

    private static Option<bool?> IncludePayload { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--include-payload",
        description: @"Whether to include payload fields in the response. Set to false for faster list views.");
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

                    private static string FormatResponse(ParseResult parseResult, global::Composio.PostInternalTriggerLogsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.PostInternalTriggerLogsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"post-internal-trigger-logs", @"Search and retrieve trigger event logs
Search and retrieve trigger event logs with advanced filtering capabilities including search parameters");
                        command.Options.Add(Time);
                        command.Options.Add(From);
                        command.Options.Add(To);
                        command.Options.Add(Status);
                        command.Options.Add(Search);
                        command.Options.Add(IntegrationId);
                        command.Options.Add(EntityId);
                        command.Options.Add(UserId);
                        command.Options.Add(Limit);
                        command.Options.Add(Cursor);
                        command.Options.Add(SearchParams);
                        command.Options.Add(IncludePayload);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Composio.PostInternalTriggerLogsRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Composio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var time = CliRuntime.WasSpecified(parseResult, Time) ? parseResult.GetValue(Time) : (__requestBase is { } __TimeBaseValue ? __TimeBaseValue.Time : default);
                        var from = CliRuntime.WasSpecified(parseResult, From) ? parseResult.GetValue(From) : (__requestBase is { } __FromBaseValue ? __FromBaseValue.From : default);
                        var to = CliRuntime.WasSpecified(parseResult, To) ? parseResult.GetValue(To) : (__requestBase is { } __ToBaseValue ? __ToBaseValue.To : default);
                        var status = CliRuntime.WasSpecified(parseResult, Status) ? parseResult.GetValue(Status) : (__requestBase is { } __StatusBaseValue ? __StatusBaseValue.Status : default);
                        var search = CliRuntime.WasSpecified(parseResult, Search) ? parseResult.GetValue(Search) : (__requestBase is { } __SearchBaseValue ? __SearchBaseValue.Search : default);
                        var integrationId = CliRuntime.WasSpecified(parseResult, IntegrationId) ? parseResult.GetValue(IntegrationId) : (__requestBase is { } __IntegrationIdBaseValue ? __IntegrationIdBaseValue.IntegrationId : default);
                        var entityId = CliRuntime.WasSpecified(parseResult, EntityId) ? parseResult.GetValue(EntityId) : (__requestBase is { } __EntityIdBaseValue ? __EntityIdBaseValue.EntityId : default);
                        var userId = CliRuntime.WasSpecified(parseResult, UserId) ? parseResult.GetValue(UserId) : (__requestBase is { } __UserIdBaseValue ? __UserIdBaseValue.UserId : default);
                        var limit = CliRuntime.WasSpecified(parseResult, Limit) ? parseResult.GetValue(Limit) : (__requestBase is { } __LimitBaseValue ? __LimitBaseValue.Limit : default);
                        var cursor = CliRuntime.WasSpecified(parseResult, Cursor) ? parseResult.GetValue(Cursor) : (__requestBase is { } __CursorBaseValue ? __CursorBaseValue.Cursor : default);
                        var searchParams = CliRuntime.WasSpecified(parseResult, SearchParams) ? parseResult.GetValue(SearchParams) : (__requestBase is { } __SearchParamsBaseValue ? __SearchParamsBaseValue.SearchParams : default);
                        var includePayload = CliRuntime.WasSpecified(parseResult, IncludePayload) ? parseResult.GetValue(IncludePayload) : (__requestBase is { } __IncludePayloadBaseValue ? __IncludePayloadBaseValue.IncludePayload : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Logs.PostInternalTriggerLogsAsync(
                                    time: time,
                                    from: from,
                                    to: to,
                                    status: status,
                                    search: search,
                                    integrationId: integrationId,
                                    entityId: entityId,
                                    userId: userId,
                                    limit: limit,
                                    cursor: cursor,
                                    searchParams: searchParams,
                                    includePayload: includePayload,
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