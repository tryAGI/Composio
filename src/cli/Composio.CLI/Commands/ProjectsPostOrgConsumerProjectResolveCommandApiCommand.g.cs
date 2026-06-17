#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class ProjectsPostOrgConsumerProjectResolveCommandApiCommand
{
    private static Option<string> XUserApiKey { get; } = new(
        name: @"--x-user-api-key")
    {
        Description = @"User API key used to authenticate the request.",
        Required = true,
    };

    private static Option<string> XOrgId { get; } = new(
        name: @"--x-org-id")
    {
        Description = @"Organization nano ID that scopes the user API key resolution.",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Composio.PostOrgConsumerProjectResolveResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.PostOrgConsumerProjectResolveResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"post-org-consumer-project-resolve", @"Resolve the organization consumer project
Finds the authenticated organization's single CONSUMER project and provisions it if absent. This endpoint is idempotent and never returns consumer API keys.");
                        command.Options.Add(XUserApiKey);
                        command.Options.Add(XOrgId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var xUserApiKey = parseResult.GetRequiredValue(XUserApiKey);
                        var xOrgId = parseResult.GetRequiredValue(XOrgId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Projects.PostOrgConsumerProjectResolveAsync(
                                    xUserApiKey: xUserApiKey,
                                    xOrgId: xOrgId,
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