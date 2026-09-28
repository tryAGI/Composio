#nullable enable

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class AuthConfigsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"auth-configs", @"Auth Configs endpoint commands.");
                         command.Subcommands.Add(AuthConfigsDeleteAuthConfigsByNanoidCommandApiCommand.Create());
                         command.Subcommands.Add(AuthConfigsGetAuthConfigsCommandApiCommand.Create());
                         command.Subcommands.Add(AuthConfigsGetAuthConfigsByNanoidCommandApiCommand.Create());
                         command.Subcommands.Add(AuthConfigsPatchAuthConfigsByNanoidCommandApiCommand.Create());
                         command.Subcommands.Add(AuthConfigsPatchAuthConfigsByNanoidByStatusCommandApiCommand.Create());
                         command.Subcommands.Add(AuthConfigsPostAuthConfigsCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}