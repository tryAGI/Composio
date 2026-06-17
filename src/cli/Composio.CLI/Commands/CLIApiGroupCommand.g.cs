#nullable enable

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static class CLIApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"cli", @"CLI endpoint commands.");
                         command.Subcommands.Add(CliPostCliCodactFailuresCommandApiCommand.Create());
        return command;
    }
}