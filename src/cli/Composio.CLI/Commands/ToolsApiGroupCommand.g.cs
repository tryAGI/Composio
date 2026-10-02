#nullable enable

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class ToolsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"tools", @"Tools endpoint commands.");
                         command.Subcommands.Add(ToolsGetToolsCommandApiCommand.Create());
                         command.Subcommands.Add(ToolsGetToolsByToolSlugCommandApiCommand.Create());
                         command.Subcommands.Add(ToolsGetToolsEnumCommandApiCommand.Create());
                         command.Subcommands.Add(ToolsPostToolsExecuteByToolSlugCommandApiCommand.Create());
                         command.Subcommands.Add(ToolsPostToolsExecuteProxyCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}