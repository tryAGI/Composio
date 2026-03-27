#nullable enable

namespace Composio
{
    public partial interface IConnectedAccountsClient
    {
        /// <summary>
        /// Delete a connected account<br/>
        /// Soft-deletes a connected account by marking it as deleted in the database. This prevents the account from being used for API calls but preserves the record for audit purposes.
        /// </summary>
        /// <param name="nanoid"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.DeleteConnectedAccountsByNanoidResponse> DeleteConnectedAccountsByNanoidAsync(
            string nanoid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}