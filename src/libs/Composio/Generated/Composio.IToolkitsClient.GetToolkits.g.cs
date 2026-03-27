#nullable enable

namespace Composio
{
    public partial interface IToolkitsClient
    {
        /// <summary>
        /// List available toolkits<br/>
        /// Retrieves a comprehensive list of toolkits of their latest versions that are available to the authenticated project. Toolkits represent integration points with external services and applications, each containing a collection of tools and triggers. This endpoint supports filtering by category and management type, as well as different sorting options.
        /// </summary>
        /// <param name="category">
        /// Category ID or name to filter toolkits by<br/>
        /// Example: productivity
        /// </param>
        /// <param name="managedBy">
        /// Entity responsible for managing the toolkits
        /// </param>
        /// <param name="sortBy">
        /// Determines how toolkits should be sorted in the response
        /// </param>
        /// <param name="includeDeprecated">
        /// Include deprecated toolkits in the response<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="search">
        /// Search query to filter toolkits by name, slug, or description (minimum 3 characters)<br/>
        /// Example: gmail
        /// </param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.GetToolkitsResponse> GetToolkitsAsync(
            string? category = default,
            global::Composio.GetToolkitsManagedBy? managedBy = default,
            global::Composio.GetToolkitsSortBy? sortBy = default,
            bool? includeDeprecated = default,
            string? search = default,
            double? limit = default,
            string? cursor = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}