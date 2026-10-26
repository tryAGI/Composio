#nullable enable

namespace Composio
{
    public partial interface ICliAuthenticationClient
    {
        /// <summary>
        /// Get CLI session details by ID or code<br/>
        /// Retrieves the current state of a CLI session using either the session ID (UUID) or the 6-character code. This endpoint is used by both the CLI client to check if the session has been linked, and by the web interface to display session details before linking.
        /// </summary>
        /// <param name="id">
        /// The CLI session ID or code to check<br/>
        /// Example: ABC123
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.GetCliGetSessionResponse> GetCliGetSessionAsync(
            string id,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get CLI session details by ID or code<br/>
        /// Retrieves the current state of a CLI session using either the session ID (UUID) or the 6-character code. This endpoint is used by both the CLI client to check if the session has been linked, and by the web interface to display session details before linking.
        /// </summary>
        /// <param name="id">
        /// The CLI session ID or code to check<br/>
        /// Example: ABC123
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.AutoSDKHttpResponse<global::Composio.GetCliGetSessionResponse>> GetCliGetSessionAsResponseAsync(
            string id,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}