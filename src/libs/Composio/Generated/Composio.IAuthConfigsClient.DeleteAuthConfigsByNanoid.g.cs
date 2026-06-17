#nullable enable

namespace Composio
{
    public partial interface IAuthConfigsClient
    {
        /// <summary>
        /// Delete an authentication configuration<br/>
        /// Soft-deletes an authentication configuration by marking it as deleted in the database. This operation cannot be undone. Pass `?revoke_on_delete=true` to also revoke the upstream credentials of every connection using this auth config via a background job.
        /// </summary>
        /// <param name="nanoid">
        /// The unique identifier of the authentication configuration to delete
        /// </param>
        /// <param name="revokeOnDelete">
        /// When `true`, the delete also starts a background job that revokes the upstream credentials of every connected account in scope, and the response carries a `revoke_job_id`. Defaults to `false`. Revocation is irreversible — recovering a deleted entity does not restore working credentials.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.DeleteAuthConfigsByNanoidResponse> DeleteAuthConfigsByNanoidAsync(
            string nanoid,
            bool? revokeOnDelete = default,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete an authentication configuration<br/>
        /// Soft-deletes an authentication configuration by marking it as deleted in the database. This operation cannot be undone. Pass `?revoke_on_delete=true` to also revoke the upstream credentials of every connection using this auth config via a background job.
        /// </summary>
        /// <param name="nanoid">
        /// The unique identifier of the authentication configuration to delete
        /// </param>
        /// <param name="revokeOnDelete">
        /// When `true`, the delete also starts a background job that revokes the upstream credentials of every connected account in scope, and the response carries a `revoke_job_id`. Defaults to `false`. Revocation is irreversible — recovering a deleted entity does not restore working credentials.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.AutoSDKHttpResponse<global::Composio.DeleteAuthConfigsByNanoidResponse>> DeleteAuthConfigsByNanoidAsResponseAsync(
            string nanoid,
            bool? revokeOnDelete = default,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}