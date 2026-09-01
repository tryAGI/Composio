#nullable enable

namespace Composio
{
    public partial interface IConnectedAccountsClient
    {
        /// <summary>
        /// Delete a connected account<br/>
        /// Deletes a connected account. The account immediately stops working for API calls and cannot be restored through the API. Pass `?revoke_on_delete=true` to also revoke the account's upstream credentials.
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
        /// Deletes a connected account. The account immediately stops working for API calls and cannot be restored through the API. Pass `?revoke_on_delete=true` to also revoke the account's upstream credentials.
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