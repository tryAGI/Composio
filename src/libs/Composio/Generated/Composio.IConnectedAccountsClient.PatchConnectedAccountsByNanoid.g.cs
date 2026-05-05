#nullable enable

namespace Composio
{
    public partial interface IConnectedAccountsClient
    {
        /// <summary>
        /// Update a connected account<br/>
        /// Update a connected account. Supports updating the alias and/or credentials. Only specified fields will be updated. Set a credential field to null to remove it. Alias must be unique within the same project, entity, and toolkit scope.
        /// </summary>
        /// <param name="nanoid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PatchConnectedAccountsByNanoidResponse> PatchConnectedAccountsByNanoidAsync(
            string nanoid,

            global::Composio.PatchConnectedAccountBody request,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a connected account<br/>
        /// Update a connected account. Supports updating the alias and/or credentials. Only specified fields will be updated. Set a credential field to null to remove it. Alias must be unique within the same project, entity, and toolkit scope.
        /// </summary>
        /// <param name="nanoid"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.AutoSDKHttpResponse<global::Composio.PatchConnectedAccountsByNanoidResponse>> PatchConnectedAccountsByNanoidAsResponseAsync(
            string nanoid,

            global::Composio.PatchConnectedAccountBody request,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a connected account<br/>
        /// Update a connected account. Supports updating the alias and/or credentials. Only specified fields will be updated. Set a credential field to null to remove it. Alias must be unique within the same project, entity, and toolkit scope.
        /// </summary>
        /// <param name="nanoid"></param>
        /// <param name="alias">
        /// A human-readable alias for this connected account. Pass an empty string to clear the alias. Must be unique per entity and toolkit within the project.
        /// </param>
        /// <param name="connection"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PatchConnectedAccountsByNanoidResponse> PatchConnectedAccountsByNanoidAsync(
            string nanoid,
            string? alias = default,
            global::Composio.PatchConnectedAccountBodyConnection? connection = default,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}