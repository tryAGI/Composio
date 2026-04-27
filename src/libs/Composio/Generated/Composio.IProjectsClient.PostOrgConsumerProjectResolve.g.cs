#nullable enable

namespace Composio
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Resolve the organization consumer project<br/>
        /// Finds the authenticated organization's single CONSUMER project and provisions it if absent. This endpoint is idempotent and never returns consumer API keys.
        /// </summary>
        /// <param name="xUserApiKey">
        /// User API key used to authenticate the request.<br/>
        /// Example: uak_a1b2c3d4e5f6g7h8i9j0
        /// </param>
        /// <param name="xOrgId">
        /// Organization nano ID that scopes the user API key resolution.<br/>
        /// Example: ok_1a2b3c4d5e6f
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PostOrgConsumerProjectResolveResponse> PostOrgConsumerProjectResolveAsync(
            string xUserApiKey,
            string xOrgId,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}