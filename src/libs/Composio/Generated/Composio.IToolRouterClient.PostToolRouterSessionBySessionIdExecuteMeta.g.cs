#nullable enable

namespace Composio
{
    public partial interface IToolRouterClient
    {
        /// <summary>
        /// Execute a meta tool within a tool router session<br/>
        /// Executes a Composio meta tool (COMPOSIO_*) within a tool router session. This endpoint is kept for meta-tool compatibility; clients can also use the primary /execute endpoint.
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the tool router session. Required for public API endpoints, optional for internal endpoints where it is injected by middleware.<br/>
        /// Example: trs_LX9uJKBinWWr
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PostToolRouterSessionBySessionIdExecuteMetaResponse> PostToolRouterSessionBySessionIdExecuteMetaAsync(
            string? sessionId,

            global::Composio.PostToolRouterSessionBySessionIdExecuteMetaRequest request,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Execute a meta tool within a tool router session<br/>
        /// Executes a Composio meta tool (COMPOSIO_*) within a tool router session. This endpoint is kept for meta-tool compatibility; clients can also use the primary /execute endpoint.
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the tool router session. Required for public API endpoints, optional for internal endpoints where it is injected by middleware.<br/>
        /// Example: trs_LX9uJKBinWWr
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.AutoSDKHttpResponse<global::Composio.PostToolRouterSessionBySessionIdExecuteMetaResponse>> PostToolRouterSessionBySessionIdExecuteMetaAsResponseAsync(
            string? sessionId,

            global::Composio.PostToolRouterSessionBySessionIdExecuteMetaRequest request,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Execute a meta tool within a tool router session<br/>
        /// Executes a Composio meta tool (COMPOSIO_*) within a tool router session. This endpoint is kept for meta-tool compatibility; clients can also use the primary /execute endpoint.
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the tool router session. Required for public API endpoints, optional for internal endpoints where it is injected by middleware.<br/>
        /// Example: trs_LX9uJKBinWWr
        /// </param>
        /// <param name="slug">
        /// The unique slug identifier of the meta tool to execute<br/>
        /// Example: COMPOSIO_MANAGE_CONNECTIONS
        /// </param>
        /// <param name="arguments">
        /// The arguments required by the meta tool<br/>
        /// Default Value: {}<br/>
        /// Example: {"toolkits":["github"],"reinitiate_all":false}
        /// </param>
        /// <param name="inputResponses">
        /// The user's answers to an `input_required` response, keyed by the ids in its `input_requests`. Send them by repeating the same call (same tool and arguments) with this field added, along with the response's `request_state` if present. An approved call runs; a denied or declined one returns `failed`.<br/>
        /// Example: {"approval_3f9a1c2b7d4e5f60":{"action":"accept","content":{"decision":"approve"}}}
        /// </param>
        /// <param name="requestState">
        /// The `request_state` from the `input_required` response, sent back unchanged with `input_responses`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PostToolRouterSessionBySessionIdExecuteMetaResponse> PostToolRouterSessionBySessionIdExecuteMetaAsync(
            string? sessionId,
            global::Composio.PostToolRouterSessionBySessionIdExecuteMetaRequestSlug slug,
            global::System.Collections.Generic.Dictionary<string, object?>? arguments = default,
            global::System.Collections.Generic.Dictionary<string, global::Composio.UserInputResponse>? inputResponses = default,
            string? requestState = default,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}