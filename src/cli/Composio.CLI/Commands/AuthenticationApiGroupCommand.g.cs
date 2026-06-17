#nullable enable

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static class AuthenticationApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"authentication", @"Authentication endpoint commands.");
                         command.Subcommands.Add(AuthenticationGetAuthSessionInfoCommandApiCommand.Create());
        return command;
    }
}