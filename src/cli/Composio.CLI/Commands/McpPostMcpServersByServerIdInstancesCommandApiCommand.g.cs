#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class McpPostMcpServersByServerIdInstancesCommandApiCommand
{
    private static Argument<string> ServerId { get; } = new(
        name: @"server-id")
    {
        Description = @"The ID of the MCP server",
    };

    private static Option<string> UserId { get; } = new(
        name: @"--user-id")
    {
        Description = @"The user ID (entity ID) that will be used as both the user identifier and instance ID",
        Required = true,
    };

                    private static string FormatResponse(ParseResult parseResult, global::Composio.PostMcpServersByServerIdInstancesResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Composio.PostMcpServersByServerIdInstancesResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"post-mcp-servers-by-server-id-instances", @"Create a new MCP server instance
Creates a new instance for a Model Control Protocol (MCP) server. This endpoint validates that the user has connected accounts for all auth configurations associated with the MCP server before creating the instance.");
                        command.Arguments.Add(ServerId);
                        command.Options.Add(UserId);


        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var serverId = parseResult.GetRequiredValue(ServerId);
                        var userId = parseResult.GetRequiredValue(UserId);
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.Mcp.PostMcpServersByServerIdInstancesAsync(
                                    serverId: serverId,
                                    userId: userId,
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