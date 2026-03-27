#nullable enable

namespace Composio
{
    public partial interface ILogsClient
    {
        /// <summary>
        /// Get action log fields for filtering
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.GetInternalActionExecutionFieldsResponse> GetInternalActionExecutionFieldsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}