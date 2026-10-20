#nullable enable

namespace Composio
{
    public partial interface ICliAuthenticationClient
    {
        /// <summary>
        /// Get CLI session details by ID or code<br/>
        /// Retrieves the current state of a CLI session using either the session ID (UUID) or the 6-character code. The first UUID lookup after the session is linked returns its API key; each session issues one key. A code lookup reports status only and never returns a key.
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
        /// Retrieves the current state of a CLI session using either the session ID (UUID) or the 6-character code. The first UUID lookup after the session is linked returns its API key; each session issues one key. A code lookup reports status only and never returns a key.
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