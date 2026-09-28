#nullable enable

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class TriggersApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"triggers", @"Triggers endpoint commands.");
                         command.Subcommands.Add(TriggersDeleteTriggerInstancesManageByTriggerIdCommandApiCommand.Create());
                         command.Subcommands.Add(TriggersGetCliRealtimeCredentialsCommandApiCommand.Create());
                         command.Subcommands.Add(TriggersGetTriggerInstancesActiveCommandApiCommand.Create());
                         command.Subcommands.Add(TriggersGetTriggersTypesCommandApiCommand.Create());
                         command.Subcommands.Add(TriggersGetTriggersTypesBySlugCommandApiCommand.Create());
                         command.Subcommands.Add(TriggersGetTriggersTypesListEnumCommandApiCommand.Create());
                         command.Subcommands.Add(TriggersPatchTriggerInstancesManageByTriggerIdCommandApiCommand.Create());
                         command.Subcommands.Add(TriggersPostCliRealtimeAuthCommandApiCommand.Create());
                         command.Subcommands.Add(TriggersPostTriggerInstancesBySlugUpsertCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}