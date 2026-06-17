#nullable enable

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static class CLIAuthenticationApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"cli-authentication", @"CLI Authentication endpoint commands.");
                         command.Subcommands.Add(CliAuthenticationGetCliGetSessionCommandApiCommand.Create());
                         command.Subcommands.Add(CliAuthenticationPostCliCreateSessionCommandApiCommand.Create());
        return command;
    }
}