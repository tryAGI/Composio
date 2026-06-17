#nullable enable

namespace Composio
{
    public partial interface IConnectedAccountsClient
    {
        /// <summary>
        /// Delete a connected account<br/>
        /// Soft-deletes a connected account by marking it as deleted in the database. This prevents the account from being used for API calls but preserves the record for audit purposes. Pass `?revoke_on_delete=true` to also revoke the account's upstream credentials via a background job.
        /// </summary>
        /// <param name="nanoid"></param>
        /// <param name="revokeOnDelete">
        /// When `true`, the delete also starts a background job that revokes the upstream credentials of every connected account in scope, and the response carries a `revoke_job_id`. Defaults to `false`. Revocation is irreversible — recovering a deleted entity does not restore working credentials.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.DeleteConnectedAccountsByNanoidResponse> DeleteConnectedAccountsByNanoidAsync(
            string nanoid,
            bool? revokeOnDelete = default,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a connected account<br/>
        /// Soft-deletes a connected account by marking it as deleted in the database. This prevents the account from being used for API calls but preserves the record for audit purposes. Pass `?revoke_on_delete=true` to also revoke the account's upstream credentials via a background job.
        /// </summary>
        /// <param name="nanoid"></param>
        /// <param name="revokeOnDelete">
        /// When `true`, the delete also starts a background job that revokes the upstream credentials of every connected account in scope, and the response carries a `revoke_job_id`. Defaults to `false`. Revocation is irreversible — recovering a deleted entity does not restore working credentials.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.AutoSDKHttpResponse<global::Composio.DeleteConnectedAccountsByNanoidResponse>> DeleteConnectedAccountsByNanoidAsResponseAsync(
            string nanoid,
            bool? revokeOnDelete = default,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}