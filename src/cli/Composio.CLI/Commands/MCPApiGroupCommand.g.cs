#nullable enable

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static class MCPApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"mcp", @"MCP endpoint commands.");
                         command.Subcommands.Add(McpDeleteMcpByIdCommandApiCommand.Create());
                         command.Subcommands.Add(McpDeleteMcpServersByServerIdInstancesByInstanceIdCommandApiCommand.Create());
                         command.Subcommands.Add(McpGetMcpAppByAppKeyCommandApiCommand.Create());
                         command.Subcommands.Add(McpGetMcpByIdCommandApiCommand.Create());
                         command.Subcommands.Add(McpGetMcpServersCommandApiCommand.Create());
                         command.Subcommands.Add(McpGetMcpServersByServerIdInstancesCommandApiCommand.Create());
                         command.Subcommands.Add(McpPatchMcpByIdCommandApiCommand.Create());
                         command.Subcommands.Add(McpPostMcpServersCommandApiCommand.Create());
                         command.Subcommands.Add(McpPostMcpServersByServerIdInstancesCommandApiCommand.Create());
                         command.Subcommands.Add(McpPostMcpServersCustomCommandApiCommand.Create());
                         command.Subcommands.Add(McpPostMcpServersGenerateCommandApiCommand.Create());
        return command;
    }
}