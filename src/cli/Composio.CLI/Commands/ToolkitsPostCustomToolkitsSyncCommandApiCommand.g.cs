#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class ToolkitsPostCustomToolkitsSyncCommandApiCommand
{
    private static Argument<string> Slug { get; } = new(
        name: @"slug")
    {
        Description = @"Toolkit slug to sync",
    };

    private static Option<string?> ConnectedAccountId { get; } = new(
        name: @"--connected-account-id")
    {
        Description = @"The unique identifier for the connected account",
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

                    private static string FormatResponse(ParseResult parseResult, global::Composio.PostCustomToolkitsSyncResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.PostCustomToolkitsSyncResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"post-custom-toolkits-sync", @"Sync a custom toolkit
Experimental: custom toolkits are in pilot and this contract may change. Re-fetches tool definitions from the remote MCP server for the custom toolkit with the provided slug. Call it when automatic sync fails or the remote tool definitions change.");
                        command.Arguments.Add(Slug);
                        command.Options.Add(ConnectedAccountId);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Composio.PostCustomToolkitsSyncRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Composio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var slug = parseResult.GetRequiredValue(Slug);
                        var connectedAccountId = CliRuntime.WasSpecified(parseResult, ConnectedAccountId) ? parseResult.GetValue(ConnectedAccountId) : (__requestBase is { } __ConnectedAccountIdBaseValue ? __ConnectedAccountIdBaseValue.ConnectedAccountId : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Toolkits.PostCustomToolkitsSyncAsync(
                                    slug: slug,
                                    connectedAccountId: connectedAccountId,
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