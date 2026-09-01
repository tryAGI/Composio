#nullable enable

namespace Composio
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Delete and generate new API key for project<br/>
        /// Generates a new API key for the specified project, invalidating any existing API keys for that project. This operation creates a fresh API key with a new random name and key value. Every existing API key for the project stops working immediately.
        /// </summary>
        /// <param name="nanoId">
        /// Unique identifier (Nano ID) of the project to regenerate API key for<br/>
        /// Example: pr_1a2b3c4d5e6f
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PostOrgOwnerProjectByNanoIdRegenerateApiKeyResponse> PostOrgOwnerProjectByNanoIdRegenerateApiKeyAsync(
            string nanoId,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete and generate new API key for project<br/>
        /// Generates a new API key for the specified project, invalidating any existing API keys for that project. This operation creates a fresh API key with a new random name and key value. Every existing API key for the project stops working immediately.
        /// </summary>
        /// <param name="nanoId">
        /// Unique identifier (Nano ID) of the project to regenerate API key for<br/>
        /// Example: pr_1a2b3c4d5e6f
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.AutoSDKHttpResponse<global::Composio.PostOrgOwnerProjectByNanoIdRegenerateApiKeyResponse>> PostOrgOwnerProjectByNanoIdRegenerateApiKeyAsResponseAsync(
            string nanoId,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}