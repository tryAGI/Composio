#nullable enable

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class AuthenticationApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"authentication", @"Authentication endpoint commands.");
                         command.Subcommands.Add(AuthenticationGetAuthSessionInfoCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}