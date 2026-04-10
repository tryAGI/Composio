#nullable enable

namespace Composio
{
    public partial interface IConnectedAccountsClient
    {
        /// <summary>
        /// Enable or disable a connected account<br/>
        /// Updates the status of a connected account to either enabled (active) or disabled (inactive). Disabled accounts cannot be used for API calls but remain in the database.
        /// </summary>
        /// <param name="nanoId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PatchConnectedAccountsByNanoIdStatusResponse> PatchConnectedAccountsByNanoIdStatusAsync(
            string nanoId,

            global::Composio.PatchConnectedAccountsByNanoIdStatusRequest request,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Enable or disable a connected account<br/>
        /// Updates the status of a connected account to either enabled (active) or disabled (inactive). Disabled accounts cannot be used for API calls but remain in the database.
        /// </summary>
        /// <param name="nanoId"></param>
        /// <param name="enabled">
        /// Set to true to enable the account or false to disable it
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PatchConnectedAccountsByNanoIdStatusResponse> PatchConnectedAccountsByNanoIdStatusAsync(
            string nanoId,
            bool enabled,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}