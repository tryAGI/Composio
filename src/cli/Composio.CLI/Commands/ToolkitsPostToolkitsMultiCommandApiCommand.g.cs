#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class ToolkitsPostToolkitsMultiCommandApiCommand
{
    private static Option<global::System.Collections.Generic.IList<string>?> Toolkits { get; } = new(
        name: @"--toolkits")
    {
        Description = @"Array of toolkit slug identifiers to retrieve",
    };

    private static Option<string?> Category { get; } = new(
        name: @"--category")
    {
        Description = @"Category ID or name to filter toolkits by",
    };

    private static Option<global::Composio.PostToolkitsMultiRequestManagedBy?> ManagedBy { get; } = new(
        name: @"--managed-by")
    {
        Description = @"Entity responsible for managing the toolkits",
    };

    private static Option<global::Composio.PostToolkitsMultiRequestSortBy?> SortBy { get; } = new(
        name: @"--sort-by")
    {
        Description = @"Determines how toolkits should be sorted in the response",
    };

    private static Option<double?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"",
    };

    private static Option<string?> Cursor { get; } = new(
        name: @"--cursor")
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

                    private static string FormatResponse(ParseResult parseResult, global::Composio.PostToolkitsMultiResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.PostToolkitsMultiResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"post-toolkits-multi", @"Fetch multiple toolkits
Retrieves a comprehensive list of toolkits of their latest versions that are available to the authenticated project. Toolkits represent integration points with external services and applications, each containing a collection of tools and triggers. This endpoint supports filtering by category and management type, as well as different sorting options. You can optionally specify a list of toolkit slugs to fetch specific toolkits.");
                        command.Options.Add(Toolkits);
                        command.Options.Add(Category);
                        command.Options.Add(ManagedBy);
                        command.Options.Add(SortBy);
                        command.Options.Add(Limit);
                        command.Options.Add(Cursor);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Composio.PostToolkitsMultiRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Composio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var toolkits = CliRuntime.WasSpecified(parseResult, Toolkits) ? parseResult.GetValue(Toolkits) : (__requestBase is { } __ToolkitsBaseValue ? __ToolkitsBaseValue.Toolkits : default);
                        var category = CliRuntime.WasSpecified(parseResult, Category) ? parseResult.GetValue(Category) : (__requestBase is { } __CategoryBaseValue ? __CategoryBaseValue.Category : default);
                        var managedBy = CliRuntime.WasSpecified(parseResult, ManagedBy) ? parseResult.GetValue(ManagedBy) : (__requestBase is { } __ManagedByBaseValue ? __ManagedByBaseValue.ManagedBy : default);
                        var sortBy = CliRuntime.WasSpecified(parseResult, SortBy) ? parseResult.GetValue(SortBy) : (__requestBase is { } __SortByBaseValue ? __SortByBaseValue.SortBy : default);
                        var limit = CliRuntime.WasSpecified(parseResult, Limit) ? parseResult.GetValue(Limit) : (__requestBase is { } __LimitBaseValue ? __LimitBaseValue.Limit : default);
                        var cursor = CliRuntime.WasSpecified(parseResult, Cursor) ? parseResult.GetValue(Cursor) : (__requestBase is { } __CursorBaseValue ? __CursorBaseValue.Cursor : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Toolkits.PostToolkitsMultiAsync(
                                    toolkits: toolkits,
                                    category: category,
                                    managedBy: managedBy,
                                    sortBy: sortBy,
                                    limit: limit,
                                    cursor: cursor,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Composio.SourceGenerationContext.Default,
                                        @"Items",
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