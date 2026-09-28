#nullable enable

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class CLIAuthenticationApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"cli-authentication", @"CLI Authentication endpoint commands.");
                         command.Subcommands.Add(CliAuthenticationGetCliGetSessionCommandApiCommand.Create());
                         command.Subcommands.Add(CliAuthenticationPostCliCreateSessionCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}