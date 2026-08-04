#nullable enable

namespace Composio
{
    public partial interface IToolkitsClient
    {
        /// <summary>
        /// Sync a custom toolkit<br/>
        /// Experimental: custom toolkits are in pilot and this contract may change. Re-fetches tool definitions from the remote MCP server for the custom toolkit with the provided slug. Call it when automatic sync fails or the remote tool definitions change.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PostCustomToolkitsSyncResponse> PostCustomToolkitsSyncAsync(

            global::Composio.PostCustomToolkitsSyncRequest request,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Sync a custom toolkit<br/>
        /// Experimental: custom toolkits are in pilot and this contract may change. Re-fetches tool definitions from the remote MCP server for the custom toolkit with the provided slug. Call it when automatic sync fails or the remote tool definitions change.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.AutoSDKHttpResponse<global::Composio.PostCustomToolkitsSyncResponse>> PostCustomToolkitsSyncAsResponseAsync(

            global::Composio.PostCustomToolkitsSyncRequest request,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Sync a custom toolkit<br/>
        /// Experimental: custom toolkits are in pilot and this contract may change. Re-fetches tool definitions from the remote MCP server for the custom toolkit with the provided slug. Call it when automatic sync fails or the remote tool definitions change.
        /// </summary>
        /// <param name="slug">
        /// Toolkit slug to sync<br/>
        /// Example: CUSTOM_MY_TOOLKIT
        /// </param>
        /// <param name="connectedAccountId">
        /// The unique identifier for the connected account<br/>
        /// Example: ca_1a2b3c4d5e6f
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PostCustomToolkitsSyncResponse> PostCustomToolkitsSyncAsync(
            string slug,
            string? connectedAccountId = default,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}