#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class ProjectsGetOrgOwnerProjectByNanoIdCommandApiCommand
{
    private static Argument<string> NanoId { get; } = new(
        name: @"nano-id")
    {
        Description = @"Unique identifier (Nano ID) of the project to retrieve",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Composio.GetOrgOwnerProjectByNanoIdResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.GetOrgOwnerProjectByNanoIdResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-org-owner-project-by-nano-id", @"Get project details by ID With Org Api key
Retrieves detailed information about a specific project using its unique identifier. This endpoint provides complete project configuration including webhook URLs, creation and update timestamps, and webhook secrets. Use this endpoint to inspect project settings or verify project configuration.");
                        command.Arguments.Add(NanoId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var nanoId = parseResult.GetRequiredValue(NanoId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Projects.GetOrgOwnerProjectByNanoIdAsync(
                                    nanoId: nanoId,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Composio.SourceGenerationContext.Default,
                                        @"ApiKeys",
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