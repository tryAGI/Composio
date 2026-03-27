#nullable enable

namespace Composio
{
    public partial interface ITriggersClient
    {
        /// <summary>
        /// List active triggers<br/>
        /// Retrieves all active trigger instances for your project. Triggers listen for events from connected accounts (e.g., new emails, Slack messages, GitHub commits) and can invoke webhooks or workflows. Use filters to find triggers for specific users, connected accounts, or trigger types.
        /// </summary>
        /// <param name="userIds">
        /// Array of user IDs to filter triggers by
        /// </param>
        /// <param name="connectedAccountIds1">
        /// Array of connected account IDs to filter triggers by
        /// </param>
        /// <param name="authConfigIds1">
        /// Array of auth config IDs to filter triggers by
        /// </param>
        /// <param name="triggerIds1">
        /// Array of trigger IDs to filter triggers by
        /// </param>
        /// <param name="triggerNames1">
        /// Array of trigger names to filter triggers by. Case-insensitive (internally normalized to uppercase).
        /// </param>
        /// <param name="connectedAccountIds2"></param>
        /// <param name="authConfigIds2"></param>
        /// <param name="triggerIds2"></param>
        /// <param name="showDisabled1">
        /// When set to true, includes disabled triggers in the response.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="triggerNames2"></param>
        /// <param name="showDisabled2">
        /// DEPRECATED: Use show_disabled instead<br/>
        /// Default Value: false
        /// </param>
        /// <param name="deprecatedConnectedAccountUuids">
        /// Array of connected account UUIDs to filter triggers by
        /// </param>
        /// <param name="deprecatedAuthConfigUuids">
        /// Array of auth config UUIDs to filter triggers by
        /// </param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.GetTriggerInstancesActiveResponse> GetTriggerInstancesActiveAsync(
            global::System.Collections.Generic.IList<string>? userIds = default,
            global::System.Collections.Generic.IList<string>? connectedAccountIds1 = default,
            global::System.Collections.Generic.IList<string>? authConfigIds1 = default,
            global::System.Collections.Generic.IList<string>? triggerIds1 = default,
            global::System.Collections.Generic.IList<string>? triggerNames1 = default,
            global::System.Collections.Generic.IList<string>? connectedAccountIds2 = default,
            global::System.Collections.Generic.IList<string>? authConfigIds2 = default,
            global::System.Collections.Generic.IList<string>? triggerIds2 = default,
            bool? showDisabled1 = default,
            global::System.Collections.Generic.IList<string>? triggerNames2 = default,
            bool? showDisabled2 = default,
            global::System.Collections.Generic.IList<string>? deprecatedConnectedAccountUuids = default,
            global::System.Collections.Generic.IList<string>? deprecatedAuthConfigUuids = default,
            double? limit = default,
            string? cursor = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}