#nullable enable

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static class WebhookEndpointsApiGroupCommand
{
    public static Command Create()
    {
        var command = new Command(@"webhook-endpoints", @"Webhook Endpoints endpoint commands.");
                         command.Subcommands.Add(WebhookEndpointsGetWebhookEndpointsCommandApiCommand.Create());
                         command.Subcommands.Add(WebhookEndpointsGetWebhookEndpointsByNanoIdCommandApiCommand.Create());
                         command.Subcommands.Add(WebhookEndpointsPatchWebhookEndpointsByNanoIdCommandApiCommand.Create());
                         command.Subcommands.Add(WebhookEndpointsPostWebhookEndpointsCommandApiCommand.Create());
                         command.Subcommands.Add(WebhookEndpointsPostWebhookEndpointsByNanoIdCommandApiCommand.Create());
        return command;
    }
}