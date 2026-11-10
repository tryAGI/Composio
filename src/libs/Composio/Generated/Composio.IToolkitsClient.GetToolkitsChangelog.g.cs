#nullable enable

namespace Composio
{
    public partial interface IToolkitsClient
    {
        /// <summary>
        /// Get toolkits changelog<br/>
        /// Retrieves the last 10 versions changelog for all toolkits. This endpoint provides version history and changelog information for each toolkit.
        /// </summary>
        /// <param name="userId">
        /// Include the custom toolkits this user can use. Without it, only custom toolkits with access "all" are included.<br/>
        /// Example: user_123
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.GetToolkitsChangelogResponse> GetToolkitsChangelogAsync(
            string? userId = default,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get toolkits changelog<br/>
        /// Retrieves the last 10 versions changelog for all toolkits. This endpoint provides version history and changelog information for each toolkit.
        /// </summary>
        /// <param name="userId">
        /// Include the custom toolkits this user can use. Without it, only custom toolkits with access "all" are included.<br/>
        /// Example: user_123
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.AutoSDKHttpResponse<global::Composio.GetToolkitsChangelogResponse>> GetToolkitsChangelogAsResponseAsync(
            string? userId = default,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}