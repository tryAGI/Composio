#nullable enable

namespace Composio
{
    public partial interface IToolRouterClient
    {
        /// <summary>
        /// Get a tool router session by ID<br/>
        /// Retrieves an existing tool router session by its ID. Returns the session configuration, MCP server URL, and available tools.
        /// </summary>
        /// <param name="sessionId">
        /// The session ID returned when creating the session<br/>
        /// Example: trs_1a2b3c4d5e6f
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.GetToolRouterSessionBySessionIdResponse> GetToolRouterSessionBySessionIdAsync(
            string sessionId,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a tool router session by ID<br/>
        /// Retrieves an existing tool router session by its ID. Returns the session configuration, MCP server URL, and available tools.
        /// </summary>
        /// <param name="sessionId">
        /// The session ID returned when creating the session<br/>
        /// Example: trs_1a2b3c4d5e6f
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.AutoSDKHttpResponse<global::Composio.GetToolRouterSessionBySessionIdResponse>> GetToolRouterSessionBySessionIdAsResponseAsync(
            string sessionId,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}