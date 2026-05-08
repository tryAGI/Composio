#nullable enable

namespace Composio
{
    public partial interface IToolRouterClient
    {
        /// <summary>
        /// Create a link session for a toolkit in a tool router session<br/>
        /// Initiates an authentication link session for a specific toolkit within a tool router session. Returns a link token and redirect URL that users can use to complete the OAuth flow.
        /// </summary>
        /// <param name="sessionId">
        /// The session ID returned when creating the session<br/>
        /// Example: trs_LX9uJKBinWWr
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PostToolRouterSessionBySessionIdLinkResponse> PostToolRouterSessionBySessionIdLinkAsync(
            string sessionId,

            global::Composio.PostToolRouterSessionBySessionIdLinkRequest request,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a link session for a toolkit in a tool router session<br/>
        /// Initiates an authentication link session for a specific toolkit within a tool router session. Returns a link token and redirect URL that users can use to complete the OAuth flow.
        /// </summary>
        /// <param name="sessionId">
        /// The session ID returned when creating the session<br/>
        /// Example: trs_LX9uJKBinWWr
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.AutoSDKHttpResponse<global::Composio.PostToolRouterSessionBySessionIdLinkResponse>> PostToolRouterSessionBySessionIdLinkAsResponseAsync(
            string sessionId,

            global::Composio.PostToolRouterSessionBySessionIdLinkRequest request,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a link session for a toolkit in a tool router session<br/>
        /// Initiates an authentication link session for a specific toolkit within a tool router session. Returns a link token and redirect URL that users can use to complete the OAuth flow.
        /// </summary>
        /// <param name="sessionId">
        /// The session ID returned when creating the session<br/>
        /// Example: trs_LX9uJKBinWWr
        /// </param>
        /// <param name="toolkit">
        /// The unique slug identifier of the toolkit to connect<br/>
        /// Example: github
        /// </param>
        /// <param name="alias">
        /// A human-readable alias for this connected account. Must be unique per entity and toolkit within the project.
        /// </param>
        /// <param name="callbackUrl">
        /// URL where users will be redirected after completing auth<br/>
        /// Example: https://myapp.com/callback
        /// </param>
        /// <param name="accountType">
        /// Sharing model for this connected account. PRIVATE (default) is usable only by the owning user_id. SHARED is reachable from a tool-router session ONLY when explicitly pinned in the session config — at most one SHARED connection per toolkit per session. Sessions never use a SHARED connection implicitly. Set at creation time only — cannot be changed later.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PostToolRouterSessionBySessionIdLinkResponse> PostToolRouterSessionBySessionIdLinkAsync(
            string sessionId,
            string toolkit,
            string? alias = default,
            string? callbackUrl = default,
            global::Composio.PostToolRouterSessionBySessionIdLinkRequestAccountType? accountType = default,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}