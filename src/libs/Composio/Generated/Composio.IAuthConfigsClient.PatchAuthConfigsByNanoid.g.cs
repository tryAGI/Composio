#nullable enable

namespace Composio
{
    public partial interface IAuthConfigsClient
    {
        /// <summary>
        /// Update an authentication configuration<br/>
        /// Modifies an existing authentication configuration with new credentials or other settings. Only specified fields will be updated.
        /// </summary>
        /// <param name="nanoid">
        /// The unique identifier of the authentication configuration to update
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> PatchAuthConfigsByNanoidAsync(
            string nanoid,

            global::Composio.OneOf<global::Composio.PatchAuthConfigsByNanoidRequestVariant1, global::Composio.PatchAuthConfigsByNanoidRequestVariant2> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an authentication configuration<br/>
        /// Modifies an existing authentication configuration with new credentials or other settings. Only specified fields will be updated.
        /// </summary>
        /// <param name="nanoid">
        /// The unique identifier of the authentication configuration to update
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> PatchAuthConfigsByNanoidAsync(
            string nanoid,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}