
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PatchTriggerInstancesManageByTriggerIdRequest
    {
        /// <summary>
        /// Enable or disable the trigger instance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PatchTriggerInstancesManageByTriggerIdRequestStatusJsonConverter))]
        public global::Composio.PatchTriggerInstancesManageByTriggerIdRequestStatus? Status { get; set; }

        /// <summary>
        /// The user id that owns the connected account behind this trigger. Optional: when sent on a project with 2FA enabled it must be the owner of a private connection or allowed on a shared one, whatever is being updated. Required to set egress_url when 2FA is enabled. Ignored when 2FA is disabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Overrides the delivery URL for this trigger instance only: its events are sent to this HTTPS URL instead of the project webhook URL. Your project webhook subscription is still required and still controls signing (the webhook secret), the payload version and which events are enabled; only the destination changes for this instance. Omit to leave the current value unchanged; pass null to remove the override and deliver to the project webhook URL again.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("egress_url")]
        public string? EgressUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTriggerInstancesManageByTriggerIdRequest" /> class.
        /// </summary>
        /// <param name="status">
        /// Enable or disable the trigger instance.
        /// </param>
        /// <param name="userId">
        /// The user id that owns the connected account behind this trigger. Optional: when sent on a project with 2FA enabled it must be the owner of a private connection or allowed on a shared one, whatever is being updated. Required to set egress_url when 2FA is enabled. Ignored when 2FA is disabled.
        /// </param>
        /// <param name="egressUrl">
        /// Overrides the delivery URL for this trigger instance only: its events are sent to this HTTPS URL instead of the project webhook URL. Your project webhook subscription is still required and still controls signing (the webhook secret), the payload version and which events are enabled; only the destination changes for this instance. Omit to leave the current value unchanged; pass null to remove the override and deliver to the project webhook URL again.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchTriggerInstancesManageByTriggerIdRequest(
            global::Composio.PatchTriggerInstancesManageByTriggerIdRequestStatus? status,
            string? userId,
            string? egressUrl)
        {
            this.Status = status;
            this.UserId = userId;
            this.EgressUrl = egressUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchTriggerInstancesManageByTriggerIdRequest" /> class.
        /// </summary>
        public PatchTriggerInstancesManageByTriggerIdRequest()
        {
        }

    }
}