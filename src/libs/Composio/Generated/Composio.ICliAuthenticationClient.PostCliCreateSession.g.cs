#nullable enable

namespace Composio
{
    public partial interface ICliAuthenticationClient
    {
        /// <summary>
        /// Create a new CLI session<br/>
        /// Generates a new CLI session with a UUID v4 ID and a random 6-character display code. Use the session ID in the web interface to approve the login and when polling for its API key. The display code cannot approve or retrieve a session. Optionally accepts a scope ('project' or 'user') and a source string.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PostCliCreateSessionResponse> PostCliCreateSessionAsync(

            global::Composio.PostCliCreateSessionRequest request,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new CLI session<br/>
        /// Generates a new CLI session with a UUID v4 ID and a random 6-character display code. Use the session ID in the web interface to approve the login and when polling for its API key. The display code cannot approve or retrieve a session. Optionally accepts a scope ('project' or 'user') and a source string.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.AutoSDKHttpResponse<global::Composio.PostCliCreateSessionResponse>> PostCliCreateSessionAsResponseAsync(

            global::Composio.PostCliCreateSessionRequest request,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new CLI session<br/>
        /// Generates a new CLI session with a UUID v4 ID and a random 6-character display code. Use the session ID in the web interface to approve the login and when polling for its API key. The display code cannot approve or retrieve a session. Optionally accepts a scope ('project' or 'user') and a source string.
        /// </summary>
        /// <param name="scope">
        /// Key scope. 'project' (default) returns a project-level API key; 'user' returns a user-level API key valid across projects.<br/>
        /// Default Value: project
        /// </param>
        /// <param name="source">
        /// Free-form string describing the source, e.g. 'Johns MacBook (darwin, v1.2.3)'
        /// </param>
        /// <param name="codeChallenge">
        /// PKCE-style S256 challenge: the base64url encoding, without padding, of the SHA-256 digest of a random verifier the client keeps. Send together with code_challenge_method.
        /// </param>
        /// <param name="codeChallengeMethod">
        /// Method used to derive code_challenge from the verifier. Only S256 is supported. Send together with code_challenge.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PostCliCreateSessionResponse> PostCliCreateSessionAsync(
            global::Composio.PostCliCreateSessionRequestScope? scope = default,
            string? source = default,
            string? codeChallenge = default,
            global::Composio.PostCliCreateSessionRequestCodeChallengeMethod? codeChallengeMethod = default,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}