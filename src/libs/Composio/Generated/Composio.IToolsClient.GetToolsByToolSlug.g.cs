#nullable enable

namespace Composio
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Get tool by slug<br/>
        /// Retrieve detailed information about a specific tool using its slug identifier. This endpoint returns full metadata about a tool including input/output parameters, versions, and toolkit information.
        /// </summary>
        /// <param name="toolSlug"></param>
        /// <param name="includePricing">
        /// Default Value: false
        /// </param>
        /// <param name="version"></param>
        /// <param name="toolkitVersions"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.ToolDetails> GetToolsByToolSlugAsync(
            string toolSlug,
            bool? includePricing = default,
            string? version = default,
            global::Composio.OneOf<string, global::System.Collections.Generic.Dictionary<string, string>>? toolkitVersions = default,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get tool by slug<br/>
        /// Retrieve detailed information about a specific tool using its slug identifier. This endpoint returns full metadata about a tool including input/output parameters, versions, and toolkit information.
        /// </summary>
        /// <param name="toolSlug"></param>
        /// <param name="includePricing">
        /// Default Value: false
        /// </param>
        /// <param name="version"></param>
        /// <param name="toolkitVersions"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.AutoSDKHttpResponse<global::Composio.ToolDetails>> GetToolsByToolSlugAsResponseAsync(
            string toolSlug,
            bool? includePricing = default,
            string? version = default,
            global::Composio.OneOf<string, global::System.Collections.Generic.Dictionary<string, string>>? toolkitVersions = default,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}