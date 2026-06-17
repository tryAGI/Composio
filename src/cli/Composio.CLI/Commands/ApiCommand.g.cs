#nullable enable

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static class ApiCommand
{
    public static Command Create()
    {
        var command = new Command("api", "Generated endpoint commands.");

                         command.Subcommands.Add(AuthConfigsApiGroupCommand.Create());
                         command.Subcommands.Add(AuthenticationApiGroupCommand.Create());
                         command.Subcommands.Add(CLIApiGroupCommand.Create());
                         command.Subcommands.Add(CLIAuthenticationApiGroupCommand.Create());
                         command.Subcommands.Add(ConnectedAccountsApiGroupCommand.Create());
                         command.Subcommands.Add(FilesApiGroupCommand.Create());
                         command.Subcommands.Add(LogsApiGroupCommand.Create());
                         command.Subcommands.Add(MCPApiGroupCommand.Create());
                         command.Subcommands.Add(OrganizationManagementApiGroupCommand.Create());
                         command.Subcommands.Add(ProjectsApiGroupCommand.Create());
                         command.Subcommands.Add(ToolRouterApiGroupCommand.Create());
                         command.Subcommands.Add(ToolkitsApiGroupCommand.Create());
                         command.Subcommands.Add(ToolsApiGroupCommand.Create());
                         command.Subcommands.Add(TriggersApiGroupCommand.Create());
                         command.Subcommands.Add(WebhookEndpointsApiGroupCommand.Create());
                         command.Subcommands.Add(WebhookSubscriptionsApiGroupCommand.Create());
        return command;
    }
}