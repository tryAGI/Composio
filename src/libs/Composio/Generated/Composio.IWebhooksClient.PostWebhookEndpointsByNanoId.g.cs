#nullable enable

namespace Composio
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Put webhook endpoint configuration<br/>
        /// Full replacement of webhook endpoint configuration. All required setup fields must be provided. Use PATCH to update individual fields.
        /// </summary>
        /// <param name="nanoId">
        /// Webhook endpoint nano ID (e.g., we_abc123)
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PostWebhookEndpointsByNanoIdResponse> PostWebhookEndpointsByNanoIdAsync(
            string nanoId,

            global::Composio.PostWebhookEndpointsByNanoIdRequest request,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Put webhook endpoint configuration<br/>
        /// Full replacement of webhook endpoint configuration. All required setup fields must be provided. Use PATCH to update individual fields.
        /// </summary>
        /// <param name="nanoId">
        /// Webhook endpoint nano ID (e.g., we_abc123)
        /// </param>
        /// <param name="data">
        /// Key-value pairs for ALL required setup_fields. Unlike PATCH, all required fields must be provided — this is initial configuration.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PostWebhookEndpointsByNanoIdResponse> PostWebhookEndpointsByNanoIdAsync(
            string nanoId,
            global::System.Collections.Generic.Dictionary<string, string> data,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}