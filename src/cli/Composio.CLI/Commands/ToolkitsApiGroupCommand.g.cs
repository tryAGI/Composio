#nullable enable

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static class ToolkitsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"toolkits", @"Toolkits endpoint commands.");
                         command.Subcommands.Add(ToolkitsGetToolkitsCommandApiCommand.Create());
                         command.Subcommands.Add(ToolkitsGetToolkitsBySlugCommandApiCommand.Create());
                         command.Subcommands.Add(ToolkitsGetToolkitsCategoriesCommandApiCommand.Create());
                         command.Subcommands.Add(ToolkitsGetToolkitsChangelogCommandApiCommand.Create());
                         command.Subcommands.Add(ToolkitsPostCustomToolkitsSyncCommandApiCommand.Create());
                         command.Subcommands.Add(ToolkitsPostCustomToolkitsUpsertCommandApiCommand.Create());
                         command.Subcommands.Add(ToolkitsPostToolkitsMultiCommandApiCommand.Create());
        return command;
    }
}