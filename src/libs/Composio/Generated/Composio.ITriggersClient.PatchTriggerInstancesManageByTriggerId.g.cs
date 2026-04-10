#nullable enable

namespace Composio
{
    public partial interface ITriggersClient
    {
        /// <summary>
        /// Enable or disable a trigger<br/>
        /// Updates the status of a trigger instance to enable or disable it. Disabling a trigger pauses event listening without deleting the trigger configuration. Re-enabling restores the trigger to its active state. Use this for temporary maintenance or to control trigger execution.
        /// </summary>
        /// <param name="triggerId">
        /// The ID of the trigger instance to update
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PatchTriggerInstancesManageByTriggerIdResponse> PatchTriggerInstancesManageByTriggerIdAsync(
            string triggerId,

            global::Composio.PatchTriggerInstancesManageByTriggerIdRequest request,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Enable or disable a trigger<br/>
        /// Updates the status of a trigger instance to enable or disable it. Disabling a trigger pauses event listening without deleting the trigger configuration. Re-enabling restores the trigger to its active state. Use this for temporary maintenance or to control trigger execution.
        /// </summary>
        /// <param name="triggerId">
        /// The ID of the trigger instance to update
        /// </param>
        /// <param name="status"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PatchTriggerInstancesManageByTriggerIdResponse> PatchTriggerInstancesManageByTriggerIdAsync(
            string triggerId,
            global::Composio.PatchTriggerInstancesManageByTriggerIdRequestStatus status,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}