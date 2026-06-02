#nullable enable

namespace Composio
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// List all projects<br/>
        /// Retrieves projects belonging to the authenticated organization by default, or all organizations the authenticated user belongs to when list_all_org_projects is true. Projects are returned in descending order of creation date (newest first). This endpoint is useful for displaying project selection in dashboards or for integrations that need to list all available projects.
        /// </summary>
        /// <param name="listAllOrgProjects">
        /// List projects from all organizations the authenticated user belongs to<br/>
        /// Default Value: false
        /// </param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.GetOrgProjectListResponse> GetOrgProjectListAsync(
            bool? listAllOrgProjects = default,
            int? limit = default,
            string? cursor = default,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List all projects<br/>
        /// Retrieves projects belonging to the authenticated organization by default, or all organizations the authenticated user belongs to when list_all_org_projects is true. Projects are returned in descending order of creation date (newest first). This endpoint is useful for displaying project selection in dashboards or for integrations that need to list all available projects.
        /// </summary>
        /// <param name="listAllOrgProjects">
        /// List projects from all organizations the authenticated user belongs to<br/>
        /// Default Value: false
        /// </param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.AutoSDKHttpResponse<global::Composio.GetOrgProjectListResponse>> GetOrgProjectListAsResponseAsync(
            bool? listAllOrgProjects = default,
            int? limit = default,
            string? cursor = default,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}