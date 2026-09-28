#nullable enable

using System.CommandLine;

namespace Composio.CLI.Commands;

internal static partial class WebhookSubscriptionsApiGroupCommand
{
    static partial void CustomizeCommand(ref Command command);

    public static Command Create()
    {
        var command = new Command(@"webhook-subscriptions", @"Webhook Subscriptions endpoint commands.");
                         command.Subcommands.Add(WebhookSubscriptionsDeleteWebhookSubscriptionsByIdCommandApiCommand.Create());
                         command.Subcommands.Add(WebhookSubscriptionsGetWebhookSubscriptionsCommandApiCommand.Create());
                         command.Subcommands.Add(WebhookSubscriptionsGetWebhookSubscriptionsByIdCommandApiCommand.Create());
                         command.Subcommands.Add(WebhookSubscriptionsGetWebhookSubscriptionsEventTypesCommandApiCommand.Create());
                         command.Subcommands.Add(WebhookSubscriptionsPatchWebhookSubscriptionsByIdCommandApiCommand.Create());
                         command.Subcommands.Add(WebhookSubscriptionsPostWebhookSubscriptionsCommandApiCommand.Create());
                         command.Subcommands.Add(WebhookSubscriptionsPostWebhookSubscriptionsByIdRotateSecretCommandApiCommand.Create());
        CustomizeCommand(ref command);
        return command;
    }
}