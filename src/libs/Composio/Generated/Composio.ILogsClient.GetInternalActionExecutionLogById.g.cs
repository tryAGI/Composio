#nullable enable

namespace Composio
{
    public partial interface ILogsClient
    {
        /// <summary>
        /// Get detailed execution log by ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.GetInternalActionExecutionLogByIdResponse> GetInternalActionExecutionLogByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}