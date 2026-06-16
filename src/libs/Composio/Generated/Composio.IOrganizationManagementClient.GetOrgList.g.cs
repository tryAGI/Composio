#nullable enable

namespace Composio
{
    public partial interface IOrganizationManagementClient
    {
        /// <summary>
        /// List organizations<br/>
        /// Retrieves a list of organizations that the authenticated user has access to. This includes organizations where the user is a member with any role.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.GetOrgListResponse> GetOrgListAsync(
            int? limit = default,
            string? cursor = default,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List organizations<br/>
        /// Retrieves a list of organizations that the authenticated user has access to. This includes organizations where the user is a member with any role.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.AutoSDKHttpResponse<global::Composio.GetOrgListResponse>> GetOrgListAsResponseAsync(
            int? limit = default,
            string? cursor = default,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}