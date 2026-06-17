#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class McpDeleteMcpServersByServerIdInstancesByInstanceIdCommandApiCommand
{
    private static Argument<string> ServerId { get; } = new(
        name: @"server-id")
    {
        Description = @"The ID of the MCP server",
    };

    private static Argument<string> InstanceId { get; } = new(
        name: @"instance-id")
    {
        Description = @"The instance ID (user ID) to delete",
    };

                    private static string FormatResponse(ParseResult parseResult, global::Composio.DeleteMcpServersByServerIdInstancesByInstanceIdResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.DeleteMcpServersByServerIdInstancesByInstanceIdResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"delete-mcp-servers-by-server-id-instances-by-instance-id", @"Delete an MCP server instance and associated connected accounts
Removes a user instance from the MCP server and deletes all connected accounts for that user that are associated with the auth configurations of this specific MCP server. Connected accounts for other auth configurations are not affected.");
                        command.Arguments.Add(ServerId);
                        command.Arguments.Add(InstanceId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var serverId = parseResult.GetRequiredValue(ServerId);
                        var instanceId = parseResult.GetRequiredValue(InstanceId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Mcp.DeleteMcpServersByServerIdInstancesByInstanceIdAsync(
                                    serverId: serverId,
                                    instanceId: instanceId,
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