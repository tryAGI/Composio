#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class ToolRouterGetToolRouterSessionBySessionIdMountsByMountIdItemsCommandApiCommand
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

    private static Option<string?> Cursor { get; } = new(
        name: @"--cursor")
    {
        Description = @"Pagination cursor from the previous response next_cursor field",
    };

    private static Option<double?> Limit { get; } = new(
        name: @"--limit")
    {
        Description = @"Maximum number of files to return per page (1-500)",
    };

    private static Option<string?> MountRelativePrefix { get; } = new(
        name: @"--mount-relative-prefix")
    {
        Description = @"Relative path prefix within the mount for filtering",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Composio.GetToolRouterSessionBySessionIdMountsByMountIdItemsResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.GetToolRouterSessionBySessionIdMountsByMountIdItemsResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"get-tool-router-session-by-session-id-mounts-by-mount-id-items", @"List files in a session mount
Lists files in a workbench session storage mount with cursor-based pagination. Use the download_url endpoint with the returned mount_relative_path to get a presigned download URL.");
                        command.Arguments.Add(SessionId);
                        command.Arguments.Add(MountId);
                        command.Options.Add(Cursor);
                        command.Options.Add(Limit);
                        command.Options.Add(MountRelativePrefix);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var sessionId = parseResult.GetRequiredValue(SessionId);
                        var mountId = parseResult.GetRequiredValue(MountId);
                        var cursor = parseResult.GetValue(Cursor);
                        var limit = parseResult.GetValue(Limit);
                        var mountRelativePrefix = parseResult.GetValue(MountRelativePrefix);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.ToolRouter.GetToolRouterSessionBySessionIdMountsByMountIdItemsAsync(
                                    sessionId: sessionId,
                                    mountId: mountId,
                                    cursor: cursor,
                                    limit: limit,
                                    mountRelativePrefix: mountRelativePrefix,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Composio.SourceGenerationContext.Default,
                                        @"Items",
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