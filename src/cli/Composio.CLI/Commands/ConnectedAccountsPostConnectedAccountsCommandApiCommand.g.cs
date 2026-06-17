#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class ConnectedAccountsPostConnectedAccountsCommandApiCommand
{
    private static Option<global::Composio.PostConnectedAccountsRequestAuthConfig> AuthConfig { get; } = new(
        name: @"--auth-config")
    {
        Description = @"",
        Required = true,
    };

    private static Option<global::Composio.PostConnectedAccountsRequestConnection> Connection { get; } = new(
        name: @"--connection")
    {
        Description = @"",
        Required = true,
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

                    private static string FormatResponse(ParseResult parseResult, global::Composio.PostConnectedAccountsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.PostConnectedAccountsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"post-connected-accounts", @"Create a new connected account
Initiates a new connection to an external service for a user. For OAuth-based toolkits, this returns a redirect URL to complete authentication. For API key-based toolkits, provide the credentials directly in the request body. Use the `user_id` field to associate the connection with a specific user in your system.

**Deprecated for Composio-managed OAuth:** For Composio-managed auth configs on OAuth1, OAuth2, or DCR_OAUTH schemes, this endpoint is being retired and will start returning `400 BadRequest` on **2026-05-08** for new organizations and **2026-07-03** for all remaining organizations. Migrate those calls to `POST /api/v3/connected_accounts/link`. Custom auth configs and non-OAuth schemes (API key, bearer, basic) continue to be supported here. Responses on the retiring path carry a `Deprecation` header (RFC 9745) and a `Sunset` header (RFC 8594) for client-side detection.");
                        command.Options.Add(AuthConfig);
                        command.Options.Add(Connection);
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
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Composio.PostConnectedAccountsRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Composio.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var authConfig = parseResult.GetRequiredValue(AuthConfig);
                        var connection = parseResult.GetRequiredValue(Connection);
                        var validateCredentials = CliRuntime.WasSpecified(parseResult, ValidateCredentials) ? parseResult.GetValue(ValidateCredentials) : (__requestBase is { } __ValidateCredentialsBaseValue ? __ValidateCredentialsBaseValue.ValidateCredentials : default);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ConnectedAccounts.PostConnectedAccountsAsync(
                                    authConfig: authConfig,
                                    connection: connection,
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