#nullable enable

namespace Composio
{
    public partial interface IToolRouterClient
    {
        /// <summary>
        /// List meta tools with schemas for a tool router session<br/>
        /// Returns the meta tools available in a tool router session with their complete schemas. This includes request and response schemas specific to the session context.
        /// </summary>
        /// <param name="sessionId">
        /// Tool router session ID
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.GetToolRouterSessionBySessionIdToolsResponse> GetToolRouterSessionBySessionIdToolsAsync(
            string? sessionId,

            object request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List meta tools with schemas for a tool router session<br/>
        /// Returns the meta tools available in a tool router session with their complete schemas. This includes request and response schemas specific to the session context.
        /// </summary>
        /// <param name="sessionId">
        /// Tool router session ID
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.GetToolRouterSessionBySessionIdToolsResponse> GetToolRouterSessionBySessionIdToolsAsync(
            string? sessionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}