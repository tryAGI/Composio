#nullable enable

namespace Composio
{
    public partial interface IToolRouterClient
    {
        /// <summary>
        /// Execute proxy request within a tool router session<br/>
        /// Execute any native API call on a toolkit with authentication automatically injected from Composio. This endpoint proxies HTTP requests to third-party APIs using connected account credentials resolved from the session context. Provide the toolkit slug, API endpoint, and HTTP method — Composio handles authentication injection, abstracting away credential management. Supports all HTTP methods, custom headers/query parameters, and binary request/response bodies.
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the tool router session. Required for public API endpoints, optional for internal endpoints where it is injected by middleware.<br/>
        /// Example: trs_LX9uJKBinWWr
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PostToolRouterSessionBySessionIdProxyExecuteResponse> PostToolRouterSessionBySessionIdProxyExecuteAsync(
            string? sessionId,

            global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequest request,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Execute proxy request within a tool router session<br/>
        /// Execute any native API call on a toolkit with authentication automatically injected from Composio. This endpoint proxies HTTP requests to third-party APIs using connected account credentials resolved from the session context. Provide the toolkit slug, API endpoint, and HTTP method — Composio handles authentication injection, abstracting away credential management. Supports all HTTP methods, custom headers/query parameters, and binary request/response bodies.
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the tool router session. Required for public API endpoints, optional for internal endpoints where it is injected by middleware.<br/>
        /// Example: trs_LX9uJKBinWWr
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.AutoSDKHttpResponse<global::Composio.PostToolRouterSessionBySessionIdProxyExecuteResponse>> PostToolRouterSessionBySessionIdProxyExecuteAsResponseAsync(
            string? sessionId,

            global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequest request,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Execute proxy request within a tool router session<br/>
        /// Execute any native API call on a toolkit with authentication automatically injected from Composio. This endpoint proxies HTTP requests to third-party APIs using connected account credentials resolved from the session context. Provide the toolkit slug, API endpoint, and HTTP method — Composio handles authentication injection, abstracting away credential management. Supports all HTTP methods, custom headers/query parameters, and binary request/response bodies.
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the tool router session. Required for public API endpoints, optional for internal endpoints where it is injected by middleware.<br/>
        /// Example: trs_LX9uJKBinWWr
        /// </param>
        /// <param name="toolkitSlug">
        /// The slug of the toolkit to use for the request<br/>
        /// Example: gmail
        /// </param>
        /// <param name="endpoint">
        /// The API endpoint to call (absolute URL or path relative to base URL of the connected account)<br/>
        /// Example: /api/v1/resources
        /// </param>
        /// <param name="method">
        /// The HTTP method to use for the request<br/>
        /// Example: GET
        /// </param>
        /// <param name="body">
        /// The request body (for POST, PUT, and PATCH requests)<br/>
        /// Example: {"name":"New Resource","description":"This is a new resource"}
        /// </param>
        /// <param name="binaryBody">
        /// Binary body to send. For binary upload via URL: use {url: "https://...", content_type?: "..."}. For binary upload via base64: use {base64: "...", content_type?: "..."}.
        /// </param>
        /// <param name="parameters">
        /// Additional HTTP headers or query parameters to include in the request<br/>
        /// Example: [{"name":"x-api-key","value":"abc123def456","type":"header"}, {"name":"filter","value":"active","type":"query"}]
        /// </param>
        /// <param name="customConnectionData"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PostToolRouterSessionBySessionIdProxyExecuteResponse> PostToolRouterSessionBySessionIdProxyExecuteAsync(
            string? sessionId,
            string toolkitSlug,
            string endpoint,
            global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestMethod method,
            object? body = default,
            global::Composio.AnyOf<global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestBinaryBodyVariant1, global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestBinaryBodyVariant2>? binaryBody = default,
            global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestParameter>? parameters = default,
            global::Composio.OneOf<global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant1, global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant2, global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant3, global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant4, global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant5, global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant6, global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant7, global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant8, global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant9, global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant10, global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant11>? customConnectionData = default,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}