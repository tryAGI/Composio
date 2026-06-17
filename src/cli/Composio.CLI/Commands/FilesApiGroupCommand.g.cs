#nullable enable

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static class FilesApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"files", @"Files endpoint commands.");
                         command.Subcommands.Add(FilesGetFilesListCommandApiCommand.Create());
                         command.Subcommands.Add(FilesPostFilesUploadRequestCommandApiCommand.Create());
        return command;
    }
}