#nullable enable

namespace Composio
{
    public partial interface IConnectedAccountsClient
    {
        /// <summary>
        /// Create a new connected account<br/>
        /// Initiates a new connection to an external service for a user. For OAuth-based toolkits, this returns a redirect URL to complete authentication. For API key-based toolkits, provide the credentials directly in the request body. Use the `user_id` field to associate the connection with a specific user in your system.<br/>
        /// **Deprecated for Composio-managed OAuth:** For Composio-managed auth configs on OAuth1, OAuth2, or DCR_OAUTH schemes, this endpoint is being retired and will start returning `400 BadRequest` on **2026-05-08** for new organizations and **2026-07-03** for all remaining organizations. Migrate those calls to `POST /api/v3/connected_accounts/link`. Custom auth configs and non-OAuth schemes (API key, bearer, basic) continue to be supported here. Responses on the retiring path carry a `Deprecation` header (RFC 9745) and a `Sunset` header (RFC 8594) for client-side detection.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PostConnectedAccountsResponse> PostConnectedAccountsAsync(

            global::Composio.PostConnectedAccountsRequest request,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new connected account<br/>
        /// Initiates a new connection to an external service for a user. For OAuth-based toolkits, this returns a redirect URL to complete authentication. For API key-based toolkits, provide the credentials directly in the request body. Use the `user_id` field to associate the connection with a specific user in your system.<br/>
        /// **Deprecated for Composio-managed OAuth:** For Composio-managed auth configs on OAuth1, OAuth2, or DCR_OAUTH schemes, this endpoint is being retired and will start returning `400 BadRequest` on **2026-05-08** for new organizations and **2026-07-03** for all remaining organizations. Migrate those calls to `POST /api/v3/connected_accounts/link`. Custom auth configs and non-OAuth schemes (API key, bearer, basic) continue to be supported here. Responses on the retiring path carry a `Deprecation` header (RFC 9745) and a `Sunset` header (RFC 8594) for client-side detection.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.AutoSDKHttpResponse<global::Composio.PostConnectedAccountsResponse>> PostConnectedAccountsAsResponseAsync(

            global::Composio.PostConnectedAccountsRequest request,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new connected account<br/>
        /// Initiates a new connection to an external service for a user. For OAuth-based toolkits, this returns a redirect URL to complete authentication. For API key-based toolkits, provide the credentials directly in the request body. Use the `user_id` field to associate the connection with a specific user in your system.<br/>
        /// **Deprecated for Composio-managed OAuth:** For Composio-managed auth configs on OAuth1, OAuth2, or DCR_OAUTH schemes, this endpoint is being retired and will start returning `400 BadRequest` on **2026-05-08** for new organizations and **2026-07-03** for all remaining organizations. Migrate those calls to `POST /api/v3/connected_accounts/link`. Custom auth configs and non-OAuth schemes (API key, bearer, basic) continue to be supported here. Responses on the retiring path carry a `Deprecation` header (RFC 9745) and a `Sunset` header (RFC 8594) for client-side detection.
        /// </summary>
        /// <param name="authConfig"></param>
        /// <param name="connection"></param>
        /// <param name="validateCredentials">
        /// [EXPERIMENTAL] Whether to validate the provided credentials, validates only for API Key Auth scheme<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PostConnectedAccountsResponse> PostConnectedAccountsAsync(
            global::Composio.PostConnectedAccountsRequestAuthConfig authConfig,
            global::Composio.PostConnectedAccountsRequestConnection connection,
            bool? validateCredentials = default,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}