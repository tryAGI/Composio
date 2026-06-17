#nullable enable

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static class LogsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"logs", @"Logs endpoint commands.");
                         command.Subcommands.Add(LogsGetInternalActionExecutionFieldsCommandApiCommand.Create());
                         command.Subcommands.Add(LogsGetInternalActionExecutionLogByIdCommandApiCommand.Create());
                         command.Subcommands.Add(LogsGetInternalTriggerLogByIdCommandApiCommand.Create());
                         command.Subcommands.Add(LogsPostInternalActionExecutionLogsCommandApiCommand.Create());
                         command.Subcommands.Add(LogsPostInternalTriggerLogsCommandApiCommand.Create());
        return command;
    }
}