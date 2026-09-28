#nullable enable

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class OrganizationManagementApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"organization-management", @"Organization Management endpoint commands.");
                         command.Subcommands.Add(OrganizationManagementGetOrgConsumerConnectedToolkitsCommandApiCommand.Create());
                         command.Subcommands.Add(OrganizationManagementGetOrgListCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}