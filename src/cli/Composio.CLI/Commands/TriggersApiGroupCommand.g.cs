#nullable enable

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static class TriggersApiGroupCommand
{
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
        return command;
    }
}