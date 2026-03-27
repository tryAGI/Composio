#nullable enable

namespace Composio
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Get tool enum list<br/>
        /// Retrieve a list of all available tool enumeration values (tool slugs) from latest version of each toolkit. This endpoint returns a comma-separated string of tool slugs that can be used in other API calls.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<string>> GetToolsEnumAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}