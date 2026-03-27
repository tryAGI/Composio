#nullable enable

namespace Composio
{
    public partial interface ITriggersClient
    {
        /// <summary>
        /// Get credentials for CLI realtime events<br/>
        /// Get the Pusher key and project nanoId for the CLI realtime trigger channel. The CLI subscribes to private-cli-{project_id}.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.GetCliRealtimeCredentialsResponse> GetCliRealtimeCredentialsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}