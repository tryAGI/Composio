#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class ToolsPostToolsExecuteByToolSlugInputCommandApiCommand
{
    private static Argument<string> ToolSlug { get; } = new(
        name: @"tool-slug")
    {
        Description = @"The tool slug to generate inputs for",
    };

    private static Option<string> Text { get; } = new(
        name: @"--text")
    {
        Description = @"Natural language description of what you want to accomplish with this tool",
        Required = true,
    };

    private static Option<string?> CustomDescription { get; } = new(
        name: @"--custom-description")
    {
        Description = @"Custom description of the tool to help guide the LLM in generating more accurate inputs",
    };

    private static Option<string?> SystemPrompt { get; } = new(
        name: @"--system-prompt")
    {
        Description = @"System prompt to control and guide the behavior of the LLM when generating inputs",
    };

    private static Option<string?> Version { get; } = new(
        name: @"--version")
    {
        Description = @"Tool version to use when generating inputs (defaults to ""latest"" if not specified)",
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

                    private static string FormatResponse(ParseResult parseResult, global::Composio.PostToolsExecuteByToolSlugInputResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.PostToolsExecuteByToolSlugInputResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"post-tools-execute-by-tool-slug-input", @"Generate tool inputs from natural language
Uses AI to translate a natural language description into structured arguments for a specific tool. This endpoint is useful when you want to let users describe what they want to do in plain language instead of providing structured parameters.");
                        command.Arguments.Add(ToolSlug);
                        command.Options.Add(Text);
                        command.Options.Add(CustomDescription);
                        command.Options.Add(SystemPrompt);
                        command.Options.Add(Version);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Composio.PostToolsExecuteByToolSlugInputRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Composio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var toolSlug = parseResult.GetRequiredValue(ToolSlug);
                        var text = parseResult.GetRequiredValue(Text);
                        var customDescription = CliRuntime.WasSpecified(parseResult, CustomDescription) ? parseResult.GetValue(CustomDescription) : (__requestBase is { } __CustomDescriptionBaseValue ? __CustomDescriptionBaseValue.CustomDescription : default);
                        var systemPrompt = CliRuntime.WasSpecified(parseResult, SystemPrompt) ? parseResult.GetValue(SystemPrompt) : (__requestBase is { } __SystemPromptBaseValue ? __SystemPromptBaseValue.SystemPrompt : default);
                        var version = CliRuntime.WasSpecified(parseResult, Version) ? parseResult.GetValue(Version) : (__requestBase is { } __VersionBaseValue ? __VersionBaseValue.Version : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Tools.PostToolsExecuteByToolSlugInputAsync(
                                    toolSlug: toolSlug,
                                    text: text,
                                    customDescription: customDescription,
                                    systemPrompt: systemPrompt,
                                    version: version,
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