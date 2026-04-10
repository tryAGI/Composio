#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Composio
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Execute proxy request<br/>
        /// Proxy an HTTP request to a third-party API using connected account credentials. This endpoint allows making authenticated API calls to external services while abstracting away authentication details.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PostToolsExecuteProxyResponse> PostToolsExecuteProxyAsync(

            global::Composio.PostToolsExecuteProxyRequest request,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Execute proxy request<br/>
        /// Proxy an HTTP request to a third-party API using connected account credentials. This endpoint allows making authenticated API calls to external services while abstracting away authentication details.
        /// </summary>
        /// <param name="connectedAccountId">
        /// The ID of the connected account to use for authentication (if not provided, will use the default account for the project)<br/>
        /// Example: ca_1a2b3c4d5e6f
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PostToolsExecuteProxyResponse> PostToolsExecuteProxyAsync(
            string endpoint,
            global::Composio.PostToolsExecuteProxyRequestMethod method,
            string? connectedAccountId = default,
            object? body = default,
            global::Composio.AnyOf<global::Composio.PostToolsExecuteProxyRequestBinaryBodyVariant1, global::Composio.PostToolsExecuteProxyRequestBinaryBodyVariant2>? binaryBody = default,
            global::System.Collections.Generic.IList<global::Composio.PostToolsExecuteProxyRequestParameter>? parameters = default,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}