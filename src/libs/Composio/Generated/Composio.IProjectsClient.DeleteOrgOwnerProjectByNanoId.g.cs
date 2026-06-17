#nullable enable

namespace Composio
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Delete a project<br/>
        /// Soft-deletes a project within the organization by its unique identifier. When a project is deleted, it is marked as deleted but not immediately removed from the database. This operation affects all resources associated with the project including API keys, webhook configurations, and connected services. This action cannot be undone through the API. Pass `?revoke_on_delete=true` to also revoke the upstream credentials of every connection in the project via a background job.
        /// </summary>
        /// <param name="nanoId">
        /// Unique identifier (Nano ID) of the project to delete<br/>
        /// Example: pr_1a2b3c4d5e6f
        /// </param>
        /// <param name="revokeOnDelete">
        /// When `true`, the delete also starts a background job that revokes the upstream credentials of every connected account in scope, and the response carries a `revoke_job_id`. Defaults to `false`. Revocation is irreversible — recovering a deleted entity does not restore working credentials.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.DeleteOrgOwnerProjectByNanoIdResponse> DeleteOrgOwnerProjectByNanoIdAsync(
            string nanoId,
            bool? revokeOnDelete = default,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a project<br/>
        /// Soft-deletes a project within the organization by its unique identifier. When a project is deleted, it is marked as deleted but not immediately removed from the database. This operation affects all resources associated with the project including API keys, webhook configurations, and connected services. This action cannot be undone through the API. Pass `?revoke_on_delete=true` to also revoke the upstream credentials of every connection in the project via a background job.
        /// </summary>
        /// <param name="nanoId">
        /// Unique identifier (Nano ID) of the project to delete<br/>
        /// Example: pr_1a2b3c4d5e6f
        /// </param>
        /// <param name="revokeOnDelete">
        /// When `true`, the delete also starts a background job that revokes the upstream credentials of every connected account in scope, and the response carries a `revoke_job_id`. Defaults to `false`. Revocation is irreversible — recovering a deleted entity does not restore working credentials.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.AutoSDKHttpResponse<global::Composio.DeleteOrgOwnerProjectByNanoIdResponse>> DeleteOrgOwnerProjectByNanoIdAsResponseAsync(
            string nanoId,
            bool? revokeOnDelete = default,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}