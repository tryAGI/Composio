#nullable enable

namespace Composio
{
    public partial interface IWebhookSubscriptionsClient
    {
        /// <summary>
        /// Delete webhook subscription<br/>
        /// Permanently deletes a webhook subscription. This action cannot be undone.
        /// </summary>
        /// <param name="id">
        /// Webhook subscription ID
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.DeleteWebhookSubscriptionsByIdResponse> DeleteWebhookSubscriptionsByIdAsync(
            string id,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete webhook subscription<br/>
        /// Permanently deletes a webhook subscription. This action cannot be undone.
        /// </summary>
        /// <param name="id">
        /// Webhook subscription ID
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.AutoSDKHttpResponse<global::Composio.DeleteWebhookSubscriptionsByIdResponse>> DeleteWebhookSubscriptionsByIdAsResponseAsync(
            string id,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}