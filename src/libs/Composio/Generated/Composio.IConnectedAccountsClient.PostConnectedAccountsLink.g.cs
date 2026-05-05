#nullable enable

namespace Composio
{
    public partial interface IConnectedAccountsClient
    {
        /// <summary>
        /// Create a new auth link session<br/>
        /// Creates a new authentication link session that users can use to connect their accounts
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PostConnectedAccountsLinkResponse> PostConnectedAccountsLinkAsync(

            global::Composio.PostConnectedAccountsLinkRequest request,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new auth link session<br/>
        /// Creates a new authentication link session that users can use to connect their accounts
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.AutoSDKHttpResponse<global::Composio.PostConnectedAccountsLinkResponse>> PostConnectedAccountsLinkAsResponseAsync(

            global::Composio.PostConnectedAccountsLinkRequest request,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new auth link session<br/>
        /// Creates a new authentication link session that users can use to connect their accounts
        /// </summary>
        /// <param name="authConfigId">
        /// The auth config id to create a link for
        /// </param>
        /// <param name="userId">
        /// The user id to create a link for
        /// </param>
        /// <param name="alias">
        /// A human-readable alias for this connected account. Must be unique per entity and toolkit within the project.
        /// </param>
        /// <param name="callbackUrl">
        /// The callback url to create a link for
        /// </param>
        /// <param name="connectionData">
        /// Connection data for the linked account (provider-specific key-value pairs)
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PostConnectedAccountsLinkResponse> PostConnectedAccountsLinkAsync(
            string authConfigId,
            string userId,
            string? alias = default,
            string? callbackUrl = default,
            object? connectionData = default,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}