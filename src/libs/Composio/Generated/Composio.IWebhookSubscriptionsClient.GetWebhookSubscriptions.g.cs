#nullable enable

namespace Composio
{
    public partial interface IWebhookSubscriptionsClient
    {
        /// <summary>
        /// List webhook subscriptions<br/>
        /// Lists all webhook subscriptions for the authenticated project with pagination. Currently limited to one subscription per project.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.GetWebhookSubscriptionsResponse> GetWebhookSubscriptionsAsync(
            double? limit = default,
            string? cursor = default,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List webhook subscriptions<br/>
        /// Lists all webhook subscriptions for the authenticated project with pagination. Currently limited to one subscription per project.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.AutoSDKHttpResponse<global::Composio.GetWebhookSubscriptionsResponse>> GetWebhookSubscriptionsAsResponseAsync(
            double? limit = default,
            string? cursor = default,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}