#nullable enable

namespace Composio
{
    public partial interface IConnectedAccountsClient
    {
        /// <summary>
        /// Update a connected account<br/>
        /// Updates mutable fields of a connected account. Currently supports updating the alias field. Alias must be unique within the same project, entity, and toolkit scope.
        /// </summary>
        /// <param name="nanoid"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PatchConnectedAccountsByNanoidResponse> PatchConnectedAccountsByNanoidAsync(
            string nanoid,

            global::Composio.PatchConnectedAccountsByNanoidRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a connected account<br/>
        /// Updates mutable fields of a connected account. Currently supports updating the alias field. Alias must be unique within the same project, entity, and toolkit scope.
        /// </summary>
        /// <param name="nanoid"></param>
        /// <param name="alias">
        /// A human-readable alias for this connected account. Pass an empty string to clear the alias. Must be unique per entity and toolkit within the project.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PatchConnectedAccountsByNanoidResponse> PatchConnectedAccountsByNanoidAsync(
            string nanoid,
            string alias,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}