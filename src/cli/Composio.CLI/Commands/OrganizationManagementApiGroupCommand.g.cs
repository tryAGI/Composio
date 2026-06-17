#nullable enable

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static class OrganizationManagementApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"organization-management", @"Organization Management endpoint commands.");
                         command.Subcommands.Add(OrganizationManagementGetOrgConsumerConnectedToolkitsCommandApiCommand.Create());
                         command.Subcommands.Add(OrganizationManagementGetOrgListCommandApiCommand.Create());
        return command;
    }
}