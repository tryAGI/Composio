#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class TriggersPostCliRealtimeAuthCommandApiCommand
{
    private static Option<string> ChannelName { get; } = new(
        name: @"--channel-name")
    {
        Description = @"The channel name to authenticate for",
        Required = true,
    };

    private static Option<string> SocketId { get; } = new(
        name: @"--socket-id")
    {
        Description = @"The socket ID for Pusher authentication",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Composio.PostCliRealtimeAuthResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.PostCliRealtimeAuthResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"post-cli-realtime-auth", @"Authenticate CLI Pusher channel access
Authenticate CLI client access to a private-cli-{nanoId} Pusher channel");
                        command.Options.Add(ChannelName);
                        command.Options.Add(SocketId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var channelName = parseResult.GetRequiredValue(ChannelName);
                        var socketId = parseResult.GetRequiredValue(SocketId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Triggers.PostCliRealtimeAuthAsync(
                                    channelName: channelName,
                                    socketId: socketId,
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