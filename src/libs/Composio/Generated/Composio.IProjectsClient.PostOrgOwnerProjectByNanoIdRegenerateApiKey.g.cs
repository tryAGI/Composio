#nullable enable

namespace Composio
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Delete and generate new API key for project<br/>
        /// Generates a new API key for the specified project, invalidating any existing API keys for that project. This operation creates a fresh API key with a new random name and key value. All existing API keys for this project will be marked as deleted.
        /// </summary>
        /// <param name="nanoId">
        /// Unique identifier (Nano ID) of the project to regenerate API key for<br/>
        /// Example: proj_abc123xyz456
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PostOrgOwnerProjectByNanoIdRegenerateApiKeyResponse> PostOrgOwnerProjectByNanoIdRegenerateApiKeyAsync(
            string nanoId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}