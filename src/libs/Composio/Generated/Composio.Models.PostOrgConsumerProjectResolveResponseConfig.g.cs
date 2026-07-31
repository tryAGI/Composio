
#nullable enable

namespace Composio
{
    /// <summary>
    /// Consumer project configuration bag (consumer-experience and enhanced-controls flags, plus any provider-specific keys).
    /// </summary>
    public sealed partial class PostOrgConsumerProjectResolveResponseConfig
    {
        /// <summary>
        /// Whether the consumer experience is enabled for this project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consumer_experience_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ConsumerExperienceEnabled { get; set; }

        /// <summary>
        /// Whether enhanced controls are enabled for this consumer project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enhanced_controls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool EnhancedControls { get; set; }

        /// <summary>
        /// Whether org members share a single clanker bot identity for connected accounts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clanker")]
        public bool? Clanker { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostOrgConsumerProjectResolveResponseConfig" /> class.
        /// </summary>
        /// <param name="consumerExperienceEnabled">
        /// Whether the consumer experience is enabled for this project.
        /// </param>
        /// <param name="enhancedControls">
        /// Whether enhanced controls are enabled for this consumer project.
        /// </param>
        /// <param name="clanker">
        /// Whether org members share a single clanker bot identity for connected accounts.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostOrgConsumerProjectResolveResponseConfig(
            bool consumerExperienceEnabled,
            bool enhancedControls,
            bool? clanker)
        {
            this.ConsumerExperienceEnabled = consumerExperienceEnabled;
            this.EnhancedControls = enhancedControls;
            this.Clanker = clanker;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostOrgConsumerProjectResolveResponseConfig" /> class.
        /// </summary>
        public PostOrgConsumerProjectResolveResponseConfig()
        {
        }

    }
}