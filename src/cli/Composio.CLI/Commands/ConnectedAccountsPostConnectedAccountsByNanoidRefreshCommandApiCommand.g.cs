#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class ConnectedAccountsPostConnectedAccountsByNanoidRefreshCommandApiCommand
{
    private static Argument<string> Nanoid { get; } = new(
        name: @"nanoid")
    {
        Description = @"The unique identifier of the connected account",
    };

    private static Option<string?> RedirectUrl { get; } = new(
        name: @"--redirect-url")
    {
        Description = @"",
    };

    private static Option<string?> RequestRedirectUrl { get; } = new(
        name: @"--redirect-url")
    {
        Description = @"",
    };

    private static Option<bool?> ValidateCredentials { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--validate-credentials",
        description: @"[EXPERIMENTAL] Whether to validate the provided credentials, validates only for API Key Auth scheme");
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

                    private static string FormatResponse(ParseResult parseResult, global::Composio.PostConnectedAccountsByNanoidRefreshResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.PostConnectedAccountsByNanoidRefreshResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"post-connected-accounts-by-nanoid-refresh", @"Refresh authentication for a connected account
Initiates a new authentication flow for a connected account when credentials have expired or become invalid. This may generate a new authentication URL for OAuth flows or refresh tokens for other auth schemes.");
                        command.Arguments.Add(Nanoid);
                        command.Options.Add(RedirectUrl);
                        command.Options.Add(RequestRedirectUrl);
                        command.Options.Add(ValidateCredentials);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Composio.PostConnectedAccountsByNanoidRefreshRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Composio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var nanoid = parseResult.GetRequiredValue(Nanoid);
                        var redirectUrl = parseResult.GetValue(RedirectUrl);
                        var requestRedirectUrl = CliRuntime.WasSpecified(parseResult, RequestRedirectUrl) ? parseResult.GetValue(RequestRedirectUrl) : (__requestBase is { } __RequestRedirectUrlBaseValue ? __RequestRedirectUrlBaseValue.RedirectUrl : default);
                        var validateCredentials = CliRuntime.WasSpecified(parseResult, ValidateCredentials) ? parseResult.GetValue(ValidateCredentials) : (__requestBase is { } __ValidateCredentialsBaseValue ? __ValidateCredentialsBaseValue.ValidateCredentials : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ConnectedAccounts.PostConnectedAccountsByNanoidRefreshAsync(
                                    nanoid: nanoid,
                                    redirectUrl: redirectUrl,
                                    requestRedirectUrl: requestRedirectUrl,
                                    validateCredentials: validateCredentials,
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