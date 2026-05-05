#nullable enable

namespace Composio
{
    public partial interface IToolRouterClient
    {
        /// <summary>
        /// Execute a tool within a tool router session<br/>
        /// Executes a specific tool within a tool router session. This is the primary execution endpoint for both meta tools and app tools exposed by the session. The toolkit is automatically inferred from the tool slug. For app tools, the tool must belong to an allowed toolkit and must not be disabled in the session configuration. The endpoint validates permissions, resolves connected accounts when needed, and executes the tool with the session context. The top-level account field applies only to direct app tool execution in multi-account sessions. Meta/helper tools either ignore it or define their own account-selection fields, for example COMPOSIO_MULTI_EXECUTE_TOOL.tools[].account.
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the tool router session. Required for public API endpoints, optional for internal endpoints where it is injected by middleware.<br/>
        /// Example: trs_LX9uJKBinWWr
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PostToolRouterSessionBySessionIdExecuteResponse> PostToolRouterSessionBySessionIdExecuteAsync(
            string? sessionId,

            global::Composio.PostToolRouterSessionBySessionIdExecuteRequest request,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Execute a tool within a tool router session<br/>
        /// Executes a specific tool within a tool router session. This is the primary execution endpoint for both meta tools and app tools exposed by the session. The toolkit is automatically inferred from the tool slug. For app tools, the tool must belong to an allowed toolkit and must not be disabled in the session configuration. The endpoint validates permissions, resolves connected accounts when needed, and executes the tool with the session context. The top-level account field applies only to direct app tool execution in multi-account sessions. Meta/helper tools either ignore it or define their own account-selection fields, for example COMPOSIO_MULTI_EXECUTE_TOOL.tools[].account.
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the tool router session. Required for public API endpoints, optional for internal endpoints where it is injected by middleware.<br/>
        /// Example: trs_LX9uJKBinWWr
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.AutoSDKHttpResponse<global::Composio.PostToolRouterSessionBySessionIdExecuteResponse>> PostToolRouterSessionBySessionIdExecuteAsResponseAsync(
            string? sessionId,

            global::Composio.PostToolRouterSessionBySessionIdExecuteRequest request,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Execute a tool within a tool router session<br/>
        /// Executes a specific tool within a tool router session. This is the primary execution endpoint for both meta tools and app tools exposed by the session. The toolkit is automatically inferred from the tool slug. For app tools, the tool must belong to an allowed toolkit and must not be disabled in the session configuration. The endpoint validates permissions, resolves connected accounts when needed, and executes the tool with the session context. The top-level account field applies only to direct app tool execution in multi-account sessions. Meta/helper tools either ignore it or define their own account-selection fields, for example COMPOSIO_MULTI_EXECUTE_TOOL.tools[].account.
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the tool router session. Required for public API endpoints, optional for internal endpoints where it is injected by middleware.<br/>
        /// Example: trs_LX9uJKBinWWr
        /// </param>
        /// <param name="toolSlug">
        /// The unique slug identifier of the tool to execute. Supports both meta tools and app tools exposed by the session.<br/>
        /// Example: GITHUB_CREATE_AN_ISSUE
        /// </param>
        /// <param name="arguments">
        /// The arguments required by the tool<br/>
        /// Default Value: {}<br/>
        /// Example: {"repository":"octocat/Hello-World","workflow_id":"main.yml","ref":"main","inputs":{"environment":"production"}}
        /// </param>
        /// <param name="account">
        /// Account identifier to specify which connected account to use for direct tool execution. Use the account ID (e.g. "coup_hurricane_dal_analytical") or an alias. When omitted with a single account, the default is used. When omitted with multiple accounts, an error lists available accounts. Meta/helper tools either ignore this top-level field or define their own account-selection fields, for example COMPOSIO_MULTI_EXECUTE_TOOL.tools[].account.<br/>
        /// Example: coup_hurricane_dal_analytical
        /// </param>
        /// <param name="enableAutoWorkbenchOffload">
        /// When true, direct non-meta tool execution may return a workbench offload preview if the response exceeds the configured threshold and the session workbench is enabled. When omitted or false, direct tool execution returns the normal inline response. Meta/helper tools are unaffected, and COMPOSIO_MULTI_EXECUTE_TOOL uses session.workbench configuration for its own batch-level offload behavior.<br/>
        /// Example: true
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PostToolRouterSessionBySessionIdExecuteResponse> PostToolRouterSessionBySessionIdExecuteAsync(
            string? sessionId,
            string toolSlug,
            global::System.Collections.Generic.Dictionary<string, object?>? arguments = default,
            string? account = default,
            bool? enableAutoWorkbenchOffload = default,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}