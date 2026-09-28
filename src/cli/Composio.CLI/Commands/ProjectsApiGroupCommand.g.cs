#nullable enable

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class ProjectsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"projects", @"Projects endpoint commands.");
                         command.Subcommands.Add(ProjectsDeleteOrgOwnerProjectByNanoIdCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectsGetOrgOwnerProjectByNanoIdCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectsGetOrgOwnerProjectListCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectsGetOrgProjectListCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectsPostOrgConsumerProjectResolveCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectsPostOrgOwnerProjectByNanoIdRegenerateApiKeyCommandApiCommand.Create());
                         command.Subcommands.Add(ProjectsPostOrgOwnerProjectNewCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}