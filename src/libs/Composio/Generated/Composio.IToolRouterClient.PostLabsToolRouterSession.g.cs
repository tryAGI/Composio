#nullable enable

namespace Composio
{
    public partial interface IToolRouterClient
    {
        /// <summary>
        /// Create a new tool router session (Legacy)<br/>
        /// Creates a new session for the tool router lab feature (Legacy). This endpoint initializes a new session with specified toolkits and their authentication configurations. The session provides an isolated environment for testing and managing tool routing logic with scoped MCP server access.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PostLabsToolRouterSessionResponse> PostLabsToolRouterSessionAsync(

            global::Composio.PostLabsToolRouterSessionRequest request,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new tool router session (Legacy)<br/>
        /// Creates a new session for the tool router lab feature (Legacy). This endpoint initializes a new session with specified toolkits and their authentication configurations. The session provides an isolated environment for testing and managing tool routing logic with scoped MCP server access.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.AutoSDKHttpResponse<global::Composio.PostLabsToolRouterSessionResponse>> PostLabsToolRouterSessionAsResponseAsync(

            global::Composio.PostLabsToolRouterSessionRequest request,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new tool router session (Legacy)<br/>
        /// Creates a new session for the tool router lab feature (Legacy). This endpoint initializes a new session with specified toolkits and their authentication configurations. The session provides an isolated environment for testing and managing tool routing logic with scoped MCP server access.
        /// </summary>
        /// <param name="userId">
        /// Unique user identifier for the session owner<br/>
        /// Example: user_123456789
        /// </param>
        /// <param name="config">
        /// Session configuration including enabled toolkits and their auth configs<br/>
        /// Default Value: {}<br/>
        /// Example: {"manually_manage_connections":false,"toolkits":[{"toolkit":"gmail","auth_config_id":"ac_1a2b3c4d5e6f"},{"toolkit":"slack"}]}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PostLabsToolRouterSessionResponse> PostLabsToolRouterSessionAsync(
            string userId,
            global::Composio.PostLabsToolRouterSessionRequestConfig? config = default,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}