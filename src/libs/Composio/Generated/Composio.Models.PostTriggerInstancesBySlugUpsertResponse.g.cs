
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PostTriggerInstancesBySlugUpsertResponse
    {
        /// <summary>
        /// ID of the updated trigger
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TriggerId { get; set; }

        /// <summary>
        /// How this trigger instance gets events: webhook (the provider notifies) or poll (a scheduled check).<br/>
        /// Example: webhook
        /// </summary>
        /// <example>webhook</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PostTriggerInstancesBySlugUpsertResponseTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.PostTriggerInstancesBySlugUpsertResponseType Type { get; set; }

        /// <summary>
        /// Set when Composio downgraded to a poll-based mechanism instead of webhooks for this trigger.<br/>
        /// Example: No webhook endpoint found for toolkit "gmail". Create a webhook endpoint before setting up triggers.
        /// </summary>
        /// <example>No webhook endpoint found for toolkit "gmail". Create a webhook endpoint before setting up triggers.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallback_reason")]
        public string? FallbackReason { get; set; }

        /// <summary>
        /// Minutes between scheduled polls for a poll instance.<br/>
        /// Example: 15
        /// </summary>
        /// <example>15</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("polling_interval")]
        public int? PollingInterval { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostTriggerInstancesBySlugUpsertResponse" /> class.
        /// </summary>
        /// <param name="triggerId">
        /// ID of the updated trigger
        /// </param>
        /// <param name="type">
        /// How this trigger instance gets events: webhook (the provider notifies) or poll (a scheduled check).<br/>
        /// Example: webhook
        /// </param>
        /// <param name="fallbackReason">
        /// Set when Composio downgraded to a poll-based mechanism instead of webhooks for this trigger.<br/>
        /// Example: No webhook endpoint found for toolkit "gmail". Create a webhook endpoint before setting up triggers.
        /// </param>
        /// <param name="pollingInterval">
        /// Minutes between scheduled polls for a poll instance.<br/>
        /// Example: 15
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostTriggerInstancesBySlugUpsertResponse(
            string triggerId,
            global::Composio.PostTriggerInstancesBySlugUpsertResponseType type,
            string? fallbackReason,
            int? pollingInterval)
        {
            this.TriggerId = triggerId ?? throw new global::System.ArgumentNullException(nameof(triggerId));
            this.Type = type;
            this.FallbackReason = fallbackReason;
            this.PollingInterval = pollingInterval;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostTriggerInstancesBySlugUpsertResponse" /> class.
        /// </summary>
        public PostTriggerInstancesBySlugUpsertResponse()
        {
        }

    }
}