#nullable enable

namespace Composio
{
    public partial interface ITriggersClient
    {
        /// <summary>
        /// Update a trigger<br/>
        /// Updates a trigger instance. Pass status to enable or disable it: disabling pauses event listening without deleting the trigger configuration, and re-enabling restores it. Pass egress_url to override where this instance delivers its events (null removes the override); the project webhook subscription is still required and still controls signing, the payload version and which events are enabled. Send either field or both. On a project with 2FA enabled, user_id is required to set egress_url and, whenever sent, must own the connected account behind the trigger.
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
        /// Update a trigger<br/>
        /// Updates a trigger instance. Pass status to enable or disable it: disabling pauses event listening without deleting the trigger configuration, and re-enabling restores it. Pass egress_url to override where this instance delivers its events (null removes the override); the project webhook subscription is still required and still controls signing, the payload version and which events are enabled. Send either field or both. On a project with 2FA enabled, user_id is required to set egress_url and, whenever sent, must own the connected account behind the trigger.
        /// </summary>
        /// <param name="triggerId">
        /// The ID of the trigger instance to update
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.AutoSDKHttpResponse<global::Composio.PatchTriggerInstancesManageByTriggerIdResponse>> PatchTriggerInstancesManageByTriggerIdAsResponseAsync(
            string triggerId,

            global::Composio.PatchTriggerInstancesManageByTriggerIdRequest request,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a trigger<br/>
        /// Updates a trigger instance. Pass status to enable or disable it: disabling pauses event listening without deleting the trigger configuration, and re-enabling restores it. Pass egress_url to override where this instance delivers its events (null removes the override); the project webhook subscription is still required and still controls signing, the payload version and which events are enabled. Send either field or both. On a project with 2FA enabled, user_id is required to set egress_url and, whenever sent, must own the connected account behind the trigger.
        /// </summary>
        /// <param name="triggerId">
        /// The ID of the trigger instance to update
        /// </param>
        /// <param name="status">
        /// Enable or disable the trigger instance.
        /// </param>
        /// <param name="userId">
        /// The user id that owns the connected account behind this trigger. Optional: when sent on a project with 2FA enabled it must be the owner of a private connection or allowed on a shared one, whatever is being updated. Required to set egress_url when 2FA is enabled. Ignored when 2FA is disabled.
        /// </param>
        /// <param name="egressUrl">
        /// Overrides the delivery URL for this trigger instance only: its events are sent to this HTTPS URL instead of the project webhook URL. Your project webhook subscription is still required and still controls signing (the webhook secret), the payload version and which events are enabled; only the destination changes for this instance. Omit to leave the current value unchanged; pass null to remove the override and deliver to the project webhook URL again.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PatchTriggerInstancesManageByTriggerIdResponse> PatchTriggerInstancesManageByTriggerIdAsync(
            string triggerId,
            global::Composio.PatchTriggerInstancesManageByTriggerIdRequestStatus? status = default,
            string? userId = default,
            string? egressUrl = default,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}