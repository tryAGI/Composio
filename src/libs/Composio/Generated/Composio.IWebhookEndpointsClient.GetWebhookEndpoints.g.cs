#nullable enable

namespace Composio
{
    public partial interface IWebhookEndpointsClient
    {
        /// <summary>
        /// List webhook endpoints<br/>
        /// Lists webhook endpoints for the authenticated project, optionally filtered by toolkit.
        /// </summary>
        /// <param name="toolkitSlug">
        /// Filter by toolkit slug
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.GetWebhookEndpointsResponse> GetWebhookEndpointsAsync(
            string? toolkitSlug = default,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List webhook endpoints<br/>
        /// Lists webhook endpoints for the authenticated project, optionally filtered by toolkit.
        /// </summary>
        /// <param name="toolkitSlug">
        /// Filter by toolkit slug
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.AutoSDKHttpResponse<global::Composio.GetWebhookEndpointsResponse>> GetWebhookEndpointsAsResponseAsync(
            string? toolkitSlug = default,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}