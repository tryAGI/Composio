#nullable enable

namespace Composio
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Get project details by ID With Org Api key<br/>
        /// Retrieves detailed information about a specific project using its unique identifier. This endpoint provides complete project configuration including webhook URLs, creation and update timestamps, and webhook secrets. Use this endpoint to inspect project settings or verify project configuration.
        /// </summary>
        /// <param name="nanoId">
        /// Unique identifier (Nano ID) of the project to retrieve<br/>
        /// Example: pr_1a2b3c4d5e6f
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.GetOrgOwnerProjectByNanoIdResponse> GetOrgOwnerProjectByNanoIdAsync(
            string nanoId,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}