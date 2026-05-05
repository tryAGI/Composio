#nullable enable

namespace Composio
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Update webhook subscription<br/>
        /// Updates a webhook subscription. At least one field must be provided.
        /// </summary>
        /// <param name="id">
        /// Webhook subscription ID
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PatchWebhookSubscriptionsByIdResponse> PatchWebhookSubscriptionsByIdAsync(
            string id,

            global::Composio.PatchWebhookSubscriptionsByIdRequest request,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update webhook subscription<br/>
        /// Updates a webhook subscription. At least one field must be provided.
        /// </summary>
        /// <param name="id">
        /// Webhook subscription ID
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.AutoSDKHttpResponse<global::Composio.PatchWebhookSubscriptionsByIdResponse>> PatchWebhookSubscriptionsByIdAsResponseAsync(
            string id,

            global::Composio.PatchWebhookSubscriptionsByIdRequest request,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update webhook subscription<br/>
        /// Updates a webhook subscription. At least one field must be provided.
        /// </summary>
        /// <param name="id">
        /// Webhook subscription ID
        /// </param>
        /// <param name="webhookUrl">
        /// HTTPS URL to receive webhook events
        /// </param>
        /// <param name="enabledEvents">
        /// Array of event types to subscribe to
        /// </param>
        /// <param name="version">
        /// Webhook payload version
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PatchWebhookSubscriptionsByIdResponse> PatchWebhookSubscriptionsByIdAsync(
            string id,
            string? webhookUrl = default,
            global::System.Collections.Generic.IList<string>? enabledEvents = default,
            global::Composio.PatchWebhookSubscriptionsByIdRequestVersion? version = default,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}