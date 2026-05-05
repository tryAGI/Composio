#nullable enable

namespace Composio
{
    public partial interface IAuthConfigsClient
    {
        /// <summary>
        /// Get single authentication configuration by ID<br/>
        /// Retrieves detailed information about a specific authentication configuration using its unique identifier.
        /// </summary>
        /// <param name="nanoid">
        /// The unique identifier of the authentication configuration to retrieve
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.GetAuthConfigsByNanoidResponse> GetAuthConfigsByNanoidAsync(
            string nanoid,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get single authentication configuration by ID<br/>
        /// Retrieves detailed information about a specific authentication configuration using its unique identifier.
        /// </summary>
        /// <param name="nanoid">
        /// The unique identifier of the authentication configuration to retrieve
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.AutoSDKHttpResponse<global::Composio.GetAuthConfigsByNanoidResponse>> GetAuthConfigsByNanoidAsResponseAsync(
            string nanoid,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}