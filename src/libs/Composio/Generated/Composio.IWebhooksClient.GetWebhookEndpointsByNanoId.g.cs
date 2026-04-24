#nullable enable

namespace Composio
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Get webhook endpoint<br/>
        /// Retrieves a single webhook endpoint. Secret values are redacted. Use GET /webhook_endpoints/schema to discover field definitions.
        /// </summary>
        /// <param name="nanoId">
        /// Webhook endpoint nano ID (e.g., we_abc123)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.GetWebhookEndpointsByNanoIdResponse> GetWebhookEndpointsByNanoIdAsync(
            string nanoId,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}