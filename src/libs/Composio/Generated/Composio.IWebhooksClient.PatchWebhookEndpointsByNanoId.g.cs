#nullable enable

namespace Composio
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Update webhook endpoint configuration<br/>
        /// Updates app-specific secrets and credentials. Uses merge semantics — only included fields are updated; omitted fields are preserved. Can be called on active endpoints (e.g., to rotate a signing secret).
        /// </summary>
        /// <param name="nanoId">
        /// Webhook endpoint nano ID (e.g., we_abc123)
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PatchWebhookEndpointsByNanoIdResponse> PatchWebhookEndpointsByNanoIdAsync(
            string nanoId,

            global::Composio.PatchWebhookEndpointsByNanoIdRequest request,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update webhook endpoint configuration<br/>
        /// Updates app-specific secrets and credentials. Uses merge semantics — only included fields are updated; omitted fields are preserved. Can be called on active endpoints (e.g., to rotate a signing secret).
        /// </summary>
        /// <param name="nanoId">
        /// Webhook endpoint nano ID (e.g., we_abc123)
        /// </param>
        /// <param name="data">
        /// Key-value pairs matching the toolkit's setup_fields. Only include fields you want to update — omitted fields are preserved.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PatchWebhookEndpointsByNanoIdResponse> PatchWebhookEndpointsByNanoIdAsync(
            string nanoId,
            global::System.Collections.Generic.Dictionary<string, string> data,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}