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
        /// <param name="slug">
        /// The unique slug identifier of the meta tool to execute<br/>
        /// Example: COMPOSIO_MANAGE_CONNECTIONS
        /// </param>
        /// <param name="arguments">
        /// The arguments required by the meta tool<br/>
        /// Default Value: {}<br/>
        /// Example: {"toolkits":["github"],"reinitiate_all":false}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PostToolRouterSessionBySessionIdExecuteMetaResponse> PostToolRouterSessionBySessionIdExecuteMetaAsync(
            string? sessionId,
            global::Composio.PostToolRouterSessionBySessionIdExecuteMetaRequestSlug slug,
            global::System.Collections.Generic.Dictionary<string, object?>? arguments = default,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}