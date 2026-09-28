#nullable enable

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class LogsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"logs", @"Logs endpoint commands.");
                         command.Subcommands.Add(LogsGetInternalActionExecutionLogByIdCommandApiCommand.Create());
                         command.Subcommands.Add(LogsPostInternalActionExecutionLogsCommandApiCommand.Create());
                         command.Subcommands.Add(LogsPostInternalTriggerLogsCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}