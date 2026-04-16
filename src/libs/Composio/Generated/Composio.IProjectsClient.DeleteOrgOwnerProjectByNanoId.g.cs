#nullable enable

namespace Composio
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Delete a project<br/>
        /// Soft-deletes a project within the organization by its unique identifier. When a project is deleted, it is marked as deleted but not immediately removed from the database. This operation affects all resources associated with the project including API keys, webhook configurations, and connected services. This action cannot be undone through the API.
        /// </summary>
        /// <param name="nanoId">
        /// Unique identifier (Nano ID) of the project to delete<br/>
        /// Example: pr_1a2b3c4d5e6f
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.DeleteOrgOwnerProjectByNanoIdResponse> DeleteOrgOwnerProjectByNanoIdAsync(
            string nanoId,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}