#nullable enable

namespace Composio
{
    public partial interface IAuthConfigsClient
    {
        /// <summary>
        /// Enable or disable an authentication configuration<br/>
        /// Updates the status of an authentication configuration to either enabled or disabled. Disabled configurations cannot be used for new connections.
        /// </summary>
        /// <param name="nanoid">
        /// The unique identifier of the authentication configuration to update
        /// </param>
        /// <param name="status">
        /// The new status to set for the auth configuration
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PatchAuthConfigsByNanoidByStatusResponse> PatchAuthConfigsByNanoidByStatusAsync(
            string nanoid,
            global::Composio.PatchAuthConfigsByNanoidByStatusStatus status,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Enable or disable an authentication configuration<br/>
        /// Updates the status of an authentication configuration to either enabled or disabled. Disabled configurations cannot be used for new connections.
        /// </summary>
        /// <param name="nanoid">
        /// The unique identifier of the authentication configuration to update
        /// </param>
        /// <param name="status">
        /// The new status to set for the auth configuration
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.AutoSDKHttpResponse<global::Composio.PatchAuthConfigsByNanoidByStatusResponse>> PatchAuthConfigsByNanoidByStatusAsResponseAsync(
            string nanoid,
            global::Composio.PatchAuthConfigsByNanoidByStatusStatus status,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}