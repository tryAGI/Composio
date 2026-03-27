#nullable enable

namespace Composio
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Get webhook subscription<br/>
        /// Retrieves a webhook subscription by ID.
        /// </summary>
        /// <param name="id">
        /// Webhook subscription ID
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.GetWebhookSubscriptionsByIdResponse> GetWebhookSubscriptionsByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}