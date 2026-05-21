#nullable enable

namespace Composio
{
    public partial interface IWebhookSubscriptionsClient
    {
        /// <summary>
        /// List available event types<br/>
        /// Returns all event types that can be subscribed to, along with their supported webhook versions.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.GetWebhookSubscriptionsEventTypesResponse> GetWebhookSubscriptionsEventTypesAsync(
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List available event types<br/>
        /// Returns all event types that can be subscribed to, along with their supported webhook versions.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.AutoSDKHttpResponse<global::Composio.GetWebhookSubscriptionsEventTypesResponse>> GetWebhookSubscriptionsEventTypesAsResponseAsync(
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}