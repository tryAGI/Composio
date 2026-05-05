#nullable enable

namespace Composio
{
    public partial interface IMcpClient
    {
        /// <summary>
        /// Generate MCP URL with custom parameters<br/>
        /// Generates a Model Control Protocol (MCP) URL for an existing server with custom query parameters. The URL includes user-specific parameters and configuration flags that control the behavior of the MCP connection.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PostMcpServersGenerateResponse> PostMcpServersGenerateAsync(

            global::Composio.PostMcpServersGenerateRequest request,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate MCP URL with custom parameters<br/>
        /// Generates a Model Control Protocol (MCP) URL for an existing server with custom query parameters. The URL includes user-specific parameters and configuration flags that control the behavior of the MCP connection.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.AutoSDKHttpResponse<global::Composio.PostMcpServersGenerateResponse>> PostMcpServersGenerateAsResponseAsync(

            global::Composio.PostMcpServersGenerateRequest request,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate MCP URL with custom parameters<br/>
        /// Generates a Model Control Protocol (MCP) URL for an existing server with custom query parameters. The URL includes user-specific parameters and configuration flags that control the behavior of the MCP connection.
        /// </summary>
        /// <param name="mcpServerId">
        /// Unique identifier of the MCP server to generate URL for<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="managedAuthByComposio">
        /// Flag indicating if Composio manages authentication<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="userIds">
        /// List of user identifiers for whom the URL is generated<br/>
        /// Example: [user_123456, user_789012]
        /// </param>
        /// <param name="connectedAccountIds">
        /// List of connected account identifiers<br/>
        /// Example: [ca_1a2b3c4d5e6f, ca_7g8h9i0j1k2l, ca_3m4n5o6p7q8r]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PostMcpServersGenerateResponse> PostMcpServersGenerateAsync(
            string mcpServerId,
            bool? managedAuthByComposio = default,
            global::System.Collections.Generic.IList<string>? userIds = default,
            global::System.Collections.Generic.IList<string>? connectedAccountIds = default,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}