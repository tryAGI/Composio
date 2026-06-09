
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostTriggerInstancesBySlugUpsertResponse2
    {
        /// <summary>
        /// ID of the updated trigger
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TriggerId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deprecated")]
        public global::Composio.PostTriggerInstancesBySlugUpsertResponseDeprecated2? Deprecated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostTriggerInstancesBySlugUpsertResponse2" /> class.
        /// </summary>
        /// <param name="triggerId">
        /// ID of the updated trigger
        /// </param>
        /// <param name="deprecated"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostTriggerInstancesBySlugUpsertResponse2(
            string triggerId,
            global::Composio.PostTriggerInstancesBySlugUpsertResponseDeprecated2? deprecated)
        {
            this.TriggerId = triggerId ?? throw new global::System.ArgumentNullException(nameof(triggerId));
            this.Deprecated = deprecated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostTriggerInstancesBySlugUpsertResponse2" /> class.
        /// </summary>
        public PostTriggerInstancesBySlugUpsertResponse2()
        {
        }

    }
}