#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class ToolRouterPostToolRouterSessionBySessionIdMountsByMountIdDeleteCommandApiCommand
{
    private static Argument<string> SessionId { get; } = new(
        name: @"session-id")
    {
        Description = @"The unique identifier of the tool router session",
    };

    private static Argument<string> MountId { get; } = new(
        name: @"mount-id")
    {
        Description = @"ID of the storage mount",
    };

    private static Option<string> MountRelativePath { get; } = new(
        name: @"--mount-relative-path")
    {
        Description = @"Relative file path within the mount",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Composio.PostToolRouterSessionBySessionIdMountsByMountIdDeleteResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.PostToolRouterSessionBySessionIdMountsByMountIdDeleteResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"post-tool-router-session-by-session-id-mounts-by-mount-id-delete", @"Delete a file from a session mount
Deletes a file from a workbench session storage mount. S3 delete is idempotent — deleting a non-existent file succeeds silently.");
                        command.Arguments.Add(SessionId);
                        command.Arguments.Add(MountId);
                        command.Options.Add(MountRelativePath);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var sessionId = parseResult.GetRequiredValue(SessionId);
                        var mountId = parseResult.GetRequiredValue(MountId);
                        var mountRelativePath = parseResult.GetRequiredValue(MountRelativePath);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ToolRouter.PostToolRouterSessionBySessionIdMountsByMountIdDeleteAsync(
                                    sessionId: sessionId,
                                    mountId: mountId,
                                    mountRelativePath: mountRelativePath,
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