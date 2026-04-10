#nullable enable

namespace Composio
{
    public partial interface IToolkitsClient
    {
        /// <summary>
        /// List toolkit categories<br/>
        /// Retrieves a comprehensive list of all available toolkit categories from their latest versions. These categories can be used to filter toolkits by type or purpose when using the toolkit listing endpoint. Categories help organize toolkits into logical groups based on their functionality or industry focus.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.GetToolkitsCategoriesResponse> GetToolkitsCategoriesAsync(
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}