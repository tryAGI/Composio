#nullable enable

namespace Composio
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Create webhook endpoint<br/>
        /// Creates a shared webhook endpoint for a toolkit + OAuth app + project. Returns the webhook URL that the customer registers in their app dashboard. Idempotent — returns existing endpoint if one already exists for this toolkit + client_id + project.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PostWebhookEndpointsResponse> PostWebhookEndpointsAsync(

            global::Composio.PostWebhookEndpointsRequest request,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create webhook endpoint<br/>
        /// Creates a shared webhook endpoint for a toolkit + OAuth app + project. Returns the webhook URL that the customer registers in their app dashboard. Idempotent — returns existing endpoint if one already exists for this toolkit + client_id + project.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.AutoSDKHttpResponse<global::Composio.PostWebhookEndpointsResponse>> PostWebhookEndpointsAsResponseAsync(

            global::Composio.PostWebhookEndpointsRequest request,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create webhook endpoint<br/>
        /// Creates a shared webhook endpoint for a toolkit + OAuth app + project. Returns the webhook URL that the customer registers in their app dashboard. Idempotent — returns existing endpoint if one already exists for this toolkit + client_id + project.
        /// </summary>
        /// <param name="toolkitSlug">
        /// Toolkit identifier (e.g., slack, discord)
        /// </param>
        /// <param name="clientId">
        /// OAuth app client ID — identifies which app this endpoint is for
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PostWebhookEndpointsResponse> PostWebhookEndpointsAsync(
            string toolkitSlug,
            string clientId,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}