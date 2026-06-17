#nullable enable

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static class ToolsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"tools", @"Tools endpoint commands.");
                         command.Subcommands.Add(ToolsGetToolsCommandApiCommand.Create());
                         command.Subcommands.Add(ToolsGetToolsByToolSlugCommandApiCommand.Create());
                         command.Subcommands.Add(ToolsGetToolsEnumCommandApiCommand.Create());
                         command.Subcommands.Add(ToolsPostToolsExecuteByToolSlugCommandApiCommand.Create());
                         command.Subcommands.Add(ToolsPostToolsExecuteByToolSlugInputCommandApiCommand.Create());
                         command.Subcommands.Add(ToolsPostToolsExecuteProxyCommandApiCommand.Create());
        return command;
    }
}