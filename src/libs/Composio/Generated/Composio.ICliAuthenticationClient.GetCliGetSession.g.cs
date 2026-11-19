#nullable enable

namespace Composio
{
    public partial interface ICliAuthenticationClient
    {
        /// <summary>
        /// Get CLI session details by ID<br/>
        /// Retrieves the current state of a CLI session using its session ID (UUID v4). The first lookup after the session is linked returns its API key; each session issues one key. Display codes are not accepted.
        /// </summary>
        /// <param name="id">
        /// The CLI session ID (UUID) to check<br/>
        /// Example: 123e4567-e89b-42d3-a456-426614174000
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.GetCliGetSessionResponse> GetCliGetSessionAsync(
            global::System.Guid id,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get CLI session details by ID<br/>
        /// Retrieves the current state of a CLI session using its session ID (UUID v4). The first lookup after the session is linked returns its API key; each session issues one key. Display codes are not accepted.
        /// </summary>
        /// <param name="id">
        /// The CLI session ID (UUID) to check<br/>
        /// Example: 123e4567-e89b-42d3-a456-426614174000
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.AutoSDKHttpResponse<global::Composio.GetCliGetSessionResponse>> GetCliGetSessionAsResponseAsync(
            global::System.Guid id,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}