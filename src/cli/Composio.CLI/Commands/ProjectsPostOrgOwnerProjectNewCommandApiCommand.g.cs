#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class ProjectsPostOrgOwnerProjectNewCommandApiCommand
{
    private static Argument<string> NameOption { get; } = new(
        name: @"name")
    {
        Description = @"A unique name for your project that follows the required format rules",
    };

    private static Option<bool?> ShouldCreateApiKey { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--should-create-api-key",
        description: @"Whether to create an API key for the project. If true, the API key will be created and returned in the response.");

    private static Option<global::Composio.PostOrgOwnerProjectNewRequestConfig?> Config { get; } = new(
        name: @"--config")
    {
        Description = @"Configuration for the project",
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

                    private static string FormatResponse(ParseResult parseResult, global::Composio.PostOrgOwnerProjectNewResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.PostOrgOwnerProjectNewResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"post-org-owner-project-new", @"Create a new project
Creates a new project within the authenticated user's organization using the specified name. Projects are isolated environments within your organization, each with their own API keys, webhook configurations, and resources. Use this endpoint to create additional projects for different environments (e.g., development, staging, production) or for separate applications.");
                        command.Arguments.Add(NameOption);
                        command.Options.Add(ShouldCreateApiKey);
                        command.Options.Add(Config);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Composio.PostOrgOwnerProjectNewRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Composio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var name = parseResult.GetRequiredValue(NameOption);
                        var shouldCreateApiKey = CliRuntime.WasSpecified(parseResult, ShouldCreateApiKey) ? parseResult.GetValue(ShouldCreateApiKey) : (__requestBase is { } __ShouldCreateApiKeyBaseValue ? __ShouldCreateApiKeyBaseValue.ShouldCreateApiKey : default);
                        var config = CliRuntime.WasSpecified(parseResult, Config) ? parseResult.GetValue(Config) : (__requestBase is { } __ConfigBaseValue ? __ConfigBaseValue.Config : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Projects.PostOrgOwnerProjectNewAsync(
                                    name: name,
                                    shouldCreateApiKey: shouldCreateApiKey,
                                    config: config,
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