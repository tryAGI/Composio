#nullable enable

namespace Composio
{
    public partial interface ICliAuthenticationClient
    {
        /// <summary>
        /// Get CLI session details by ID<br/>
        /// Retrieves the current state of a CLI session using its session ID (UUID v4). The first lookup after the session is linked returns its API key; each session issues one key. Display codes are not accepted. For a session created with a code_challenge, every lookup must send the verifier in the x-cli-session-secret header; a session created without one rejects any lookup that sends the header.
        /// </summary>
        /// <param name="id">
        /// The CLI session ID (UUID) to check<br/>
        /// Example: 123e4567-e89b-42d3-a456-426614174000
        /// </param>
        /// <param name="xCliSessionSecret">
        /// The code_verifier whose S256 hash is the session's code_challenge. Required on every UUID lookup of a session created with a code_challenge; omit it for a session created without one.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.GetCliGetSessionResponse> GetCliGetSessionAsync(
            global::System.Guid id,
            string? xCliSessionSecret = default,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get CLI session details by ID<br/>
        /// Retrieves the current state of a CLI session using its session ID (UUID v4). The first lookup after the session is linked returns its API key; each session issues one key. Display codes are not accepted. For a session created with a code_challenge, every lookup must send the verifier in the x-cli-session-secret header; a session created without one rejects any lookup that sends the header.
        /// </summary>
        /// <param name="id">
        /// The CLI session ID (UUID) to check<br/>
        /// Example: 123e4567-e89b-42d3-a456-426614174000
        /// </param>
        /// <param name="xCliSessionSecret">
        /// The code_verifier whose S256 hash is the session's code_challenge. Required on every UUID lookup of a session created with a code_challenge; omit it for a session created without one.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.AutoSDKHttpResponse<global::Composio.GetCliGetSessionResponse>> GetCliGetSessionAsResponseAsync(
            global::System.Guid id,
            string? xCliSessionSecret = default,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}