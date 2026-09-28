#nullable enable

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class ToolRouterApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"tool-router", @"Tool Router endpoint commands.");
                         command.Subcommands.Add(ToolRouterGetToolRouterSessionBySessionIdCommandApiCommand.Create());
                         command.Subcommands.Add(ToolRouterGetToolRouterSessionBySessionIdMountsByMountIdItemsCommandApiCommand.Create());
                         command.Subcommands.Add(ToolRouterGetToolRouterSessionBySessionIdToolkitsCommandApiCommand.Create());
                         command.Subcommands.Add(ToolRouterGetToolRouterSessionBySessionIdToolsCommandApiCommand.Create());
                         command.Subcommands.Add(ToolRouterPatchToolRouterSessionBySessionIdCommandApiCommand.Create());
                         command.Subcommands.Add(ToolRouterPostToolRouterSessionCommandApiCommand.Create());
                         command.Subcommands.Add(ToolRouterPostToolRouterSessionBySessionIdExecuteCommandApiCommand.Create());
                         command.Subcommands.Add(ToolRouterPostToolRouterSessionBySessionIdExecuteMetaCommandApiCommand.Create());
                         command.Subcommands.Add(ToolRouterPostToolRouterSessionBySessionIdLinkCommandApiCommand.Create());
                         command.Subcommands.Add(ToolRouterPostToolRouterSessionBySessionIdMountsByMountIdDeleteCommandApiCommand.Create());
                         command.Subcommands.Add(ToolRouterPostToolRouterSessionBySessionIdMountsByMountIdDownloadUrlCommandApiCommand.Create());
                         command.Subcommands.Add(ToolRouterPostToolRouterSessionBySessionIdMountsByMountIdUploadUrlCommandApiCommand.Create());
                         command.Subcommands.Add(ToolRouterPostToolRouterSessionBySessionIdProxyExecuteCommandApiCommand.Create());
                         command.Subcommands.Add(ToolRouterPostToolRouterSessionBySessionIdSearchCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}