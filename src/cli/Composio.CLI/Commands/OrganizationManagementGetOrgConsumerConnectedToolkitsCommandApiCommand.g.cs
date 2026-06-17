#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class OrganizationManagementGetOrgConsumerConnectedToolkitsCommandApiCommand
{
    private static Option<string> UserId { get; } = new(
        name: @"--user-id")
    {
        Description = @"Consumer user ID to inspect within the consumer project.",
        Required = true,
    };

    private static Option<string> XUserApiKey { get; } = new(
        name: @"--x-user-api-key")
    {
        Description = @"User API key used to authenticate the request.",
        Required = true,
    };

    private static Option<string> XOrgId { get; } = new(
        name: @"--x-org-id")
    {
        Description = @"Organization nano ID that owns the consumer project.",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Composio.GetOrgConsumerConnectedToolkitsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.GetOrgConsumerConnectedToolkitsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-org-consumer-connected-toolkits", @"List active connected toolkits for a consumer user
Resolves the organization's single CONSUMER project and returns the distinct toolkit slugs for which the specified consumer user has an ACTIVE connection.");
                        command.Options.Add(UserId);
                        command.Options.Add(XUserApiKey);
                        command.Options.Add(XOrgId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var userId = parseResult.GetRequiredValue(UserId);
                        var xUserApiKey = parseResult.GetRequiredValue(XUserApiKey);
                        var xOrgId = parseResult.GetRequiredValue(XOrgId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.OrganizationManagement.GetOrgConsumerConnectedToolkitsAsync(
                                    userId: userId,
                                    xUserApiKey: xUserApiKey,
                                    xOrgId: xOrgId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Composio.SourceGenerationContext.Default,
                                        @"Toolkits",
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