#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class CliAuthenticationPostCliCreateSessionCommandApiCommand
{
    private static Option<global::Composio.PostCliCreateSessionRequestScope?> Scope { get; } = new(
        name: @"--scope")
    {
        Description = @"Key scope. 'project' (default) returns a project-level API key; 'user' returns a user-level API key valid across projects.",
    };

    private static Option<string?> Source { get; } = new(
        name: @"--source")
    {
        Description = @"Free-form string describing the source, e.g. 'Johns MacBook (darwin, v1.2.3)'",
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

                    private static string FormatResponse(ParseResult parseResult, global::Composio.PostCliCreateSessionResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.PostCliCreateSessionResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"post-cli-create-session", @"Create a new CLI session with auth code
Generates a new CLI session with a random 6-character code. This endpoint is the first step in the CLI authentication flow, creating a session that can later be linked to a user account. The generated code is displayed to the user in the CLI and should be entered in the web interface to complete authentication. Optionally accepts a scope ('project' or 'user') and a source string.");
                        command.Options.Add(Scope);
                        command.Options.Add(Source);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Composio.PostCliCreateSessionRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Composio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var scope = CliRuntime.WasSpecified(parseResult, Scope) ? parseResult.GetValue(Scope) : (__requestBase is { } __ScopeBaseValue ? __ScopeBaseValue.Scope : default);
                        var source = CliRuntime.WasSpecified(parseResult, Source) ? parseResult.GetValue(Source) : (__requestBase is { } __SourceBaseValue ? __SourceBaseValue.Source : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CliAuthentication.PostCliCreateSessionAsync(
                                    scope: scope,
                                    source: source,
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