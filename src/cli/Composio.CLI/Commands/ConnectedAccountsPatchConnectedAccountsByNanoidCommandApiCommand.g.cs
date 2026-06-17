#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class ConnectedAccountsPatchConnectedAccountsByNanoidCommandApiCommand
{
    private static Argument<string> Nanoid { get; } = new(
        name: @"nanoid")
    {
        Description = @"The unique identifier (nanoid) of the connected account",
    };

    private static Option<string?> Alias { get; } = new(
        name: @"--alias")
    {
        Description = @"A human-readable alias for this connected account. Pass an empty string to clear the alias. Must be unique per entity and toolkit within the project.",
    };

    private static Option<global::Composio.PatchConnectedAccountBodyConnection?> Connection { get; } = new(
        name: @"--connection")
    {
        Description = @"",
    };

    private static Option<global::Composio.PatchConnectedAccountBodyExperimental?> Experimental { get; } = new(
        name: @"--experimental")
    {
        Description = @"Experimental features - not stable, may be modified or removed in future versions.",
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

                    private static string FormatResponse(ParseResult parseResult, global::Composio.PatchConnectedAccountsByNanoidResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.PatchConnectedAccountsByNanoidResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"patch-connected-accounts-by-nanoid", @"Update a connected account
Update a connected account. Supports updating the alias and/or credentials. Only specified fields will be updated. Set a credential field to null to remove it. Alias must be unique within the same project, entity, and toolkit scope.");
                        command.Arguments.Add(Nanoid);
                        command.Options.Add(Alias);
                        command.Options.Add(Connection);
                        command.Options.Add(Experimental);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Composio.PatchConnectedAccountBody>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Composio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var nanoid = parseResult.GetRequiredValue(Nanoid);
                        var alias = CliRuntime.WasSpecified(parseResult, Alias) ? parseResult.GetValue(Alias) : (__requestBase is { } __AliasBaseValue ? __AliasBaseValue.Alias : default);
                        var connection = CliRuntime.WasSpecified(parseResult, Connection) ? parseResult.GetValue(Connection) : (__requestBase is { } __ConnectionBaseValue ? __ConnectionBaseValue.Connection : default);
                        var experimental = CliRuntime.WasSpecified(parseResult, Experimental) ? parseResult.GetValue(Experimental) : (__requestBase is { } __ExperimentalBaseValue ? __ExperimentalBaseValue.Experimental : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ConnectedAccounts.PatchConnectedAccountsByNanoidAsync(
                                    nanoid: nanoid,
                                    alias: alias,
                                    connection: connection,
                                    experimental: experimental,
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