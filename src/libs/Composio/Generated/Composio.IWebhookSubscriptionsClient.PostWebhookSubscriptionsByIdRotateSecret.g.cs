#nullable enable

namespace Composio
{
    public partial interface IWebhookSubscriptionsClient
    {
        /// <summary>
        /// Rotate webhook secret<br/>
        /// Generates a new signing secret for the webhook subscription.
        /// </summary>
        /// <param name="id">
        /// Webhook subscription ID
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PostWebhookSubscriptionsByIdRotateSecretResponse> PostWebhookSubscriptionsByIdRotateSecretAsync(
            string id,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rotate webhook secret<br/>
        /// Generates a new signing secret for the webhook subscription.
        /// </summary>
        /// <param name="id">
        /// Webhook subscription ID
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.AutoSDKHttpResponse<global::Composio.PostWebhookSubscriptionsByIdRotateSecretResponse>> PostWebhookSubscriptionsByIdRotateSecretAsResponseAsync(
            string id,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}