#nullable enable

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class ConnectedAccountsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"connected-accounts", @"Connected Accounts endpoint commands.");
                         command.Subcommands.Add(ConnectedAccountsDeleteConnectedAccountsByNanoidCommandApiCommand.Create());
                         command.Subcommands.Add(ConnectedAccountsGetConnectedAccountsCommandApiCommand.Create());
                         command.Subcommands.Add(ConnectedAccountsGetConnectedAccountsByNanoidCommandApiCommand.Create());
                         command.Subcommands.Add(ConnectedAccountsPatchConnectedAccountsByNanoIdStatusCommandApiCommand.Create());
                         command.Subcommands.Add(ConnectedAccountsPatchConnectedAccountsByNanoidCommandApiCommand.Create());
                         command.Subcommands.Add(ConnectedAccountsPostConnectedAccountsCommandApiCommand.Create());
                         command.Subcommands.Add(ConnectedAccountsPostConnectedAccountsLinkCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}