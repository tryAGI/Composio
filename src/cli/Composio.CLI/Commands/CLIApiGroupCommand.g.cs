#nullable enable

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class CLIApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"cli", @"CLI endpoint commands.");
                         command.Subcommands.Add(CliPostCliCodactFailuresCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}