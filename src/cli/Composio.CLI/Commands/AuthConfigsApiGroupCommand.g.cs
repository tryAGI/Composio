#nullable enable

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static class AuthConfigsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"auth-configs", @"Auth Configs endpoint commands.");
                         command.Subcommands.Add(AuthConfigsDeleteAuthConfigsByNanoidCommandApiCommand.Create());
                         command.Subcommands.Add(AuthConfigsGetAuthConfigsCommandApiCommand.Create());
                         command.Subcommands.Add(AuthConfigsGetAuthConfigsByNanoidCommandApiCommand.Create());
                         command.Subcommands.Add(AuthConfigsPatchAuthConfigsByNanoidCommandApiCommand.Create());
                         command.Subcommands.Add(AuthConfigsPatchAuthConfigsByNanoidByStatusCommandApiCommand.Create());
                         command.Subcommands.Add(AuthConfigsPostAuthConfigsCommandApiCommand.Create());
        return command;
    }
}