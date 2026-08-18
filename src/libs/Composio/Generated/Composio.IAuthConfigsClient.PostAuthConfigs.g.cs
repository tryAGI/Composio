#nullable enable

namespace Composio
{
    public partial interface IAuthConfigsClient
    {
        /// <summary>
        /// Create new authentication configuration<br/>
        /// Creates a new auth config for a toolkit, allowing you to use your own OAuth credentials or API keys instead of Composio-managed authentication. This is required when you want to use custom OAuth apps (bring your own client ID/secret) or configure specific authentication parameters for a toolkit.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PostAuthConfigsResponse> PostAuthConfigsAsync(

            global::Composio.PostAuthConfigsRequest request,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create new authentication configuration<br/>
        /// Creates a new auth config for a toolkit, allowing you to use your own OAuth credentials or API keys instead of Composio-managed authentication. This is required when you want to use custom OAuth apps (bring your own client ID/secret) or configure specific authentication parameters for a toolkit.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.AutoSDKHttpResponse<global::Composio.PostAuthConfigsResponse>> PostAuthConfigsAsResponseAsync(

            global::Composio.PostAuthConfigsRequest request,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create new authentication configuration<br/>
        /// Creates a new auth config for a toolkit, allowing you to use your own OAuth credentials or API keys instead of Composio-managed authentication. This is required when you want to use custom OAuth apps (bring your own client ID/secret) or configure specific authentication parameters for a toolkit.
        /// </summary>
        /// <param name="toolkit"></param>
        /// <param name="authConfig">
        /// Default Value: {"type":"use_composio_managed_auth","credentials":{},"restrict_to_following_tools":[]}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PostAuthConfigsResponse> PostAuthConfigsAsync(
            global::Composio.PostAuthConfigsRequestToolkit toolkit,
            global::Composio.AuthConfig? authConfig = default,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}