#nullable enable

namespace Composio
{
    public partial interface IToolkitsClient
    {
        /// <summary>
        /// Get toolkits changelog<br/>
        /// Retrieves the last 10 versions changelog for all toolkits. This endpoint provides version history and changelog information for each toolkit.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.GetToolkitsChangelogResponse> GetToolkitsChangelogAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}