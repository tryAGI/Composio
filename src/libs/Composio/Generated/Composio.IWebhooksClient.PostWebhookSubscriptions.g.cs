#nullable enable

namespace Composio
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Create webhook subscription<br/>
        /// Creates a webhook subscription for the authenticated project. Only one subscription is allowed per project. The signing secret is returned only on creation.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PostWebhookSubscriptionsResponse> PostWebhookSubscriptionsAsync(

            global::Composio.PostWebhookSubscriptionsRequest request,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create webhook subscription<br/>
        /// Creates a webhook subscription for the authenticated project. Only one subscription is allowed per project. The signing secret is returned only on creation.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.AutoSDKHttpResponse<global::Composio.PostWebhookSubscriptionsResponse>> PostWebhookSubscriptionsAsResponseAsync(

            global::Composio.PostWebhookSubscriptionsRequest request,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create webhook subscription<br/>
        /// Creates a webhook subscription for the authenticated project. Only one subscription is allowed per project. The signing secret is returned only on creation.
        /// </summary>
        /// <param name="webhookUrl">
        /// HTTPS URL to receive webhook events
        /// </param>
        /// <param name="enabledEvents">
        /// Array of event types to subscribe to
        /// </param>
        /// <param name="version">
        /// Webhook payload version<br/>
        /// Default Value: V3
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PostWebhookSubscriptionsResponse> PostWebhookSubscriptionsAsync(
            string webhookUrl,
            global::System.Collections.Generic.IList<string> enabledEvents,
            global::Composio.PostWebhookSubscriptionsRequestVersion? version = default,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}