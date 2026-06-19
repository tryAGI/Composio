
#nullable enable

namespace Composio
{
    /// <summary>
    /// User metadata (JSONB). Typed keys are shown; additional keys pass through unchanged.
    /// </summary>
    public sealed partial class GetAuthSessionInfoResponseOrgMemberMetadata
    {
        /// <summary>
        /// If true, the user will be redirected to the legacy dashboard at platform.composio.dev.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefers_old_dashboard")]
        public bool? PrefersOldDashboard { get; set; }

        /// <summary>
        /// Platform the user onboarded on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("onboarding_platform")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.GetAuthSessionInfoResponseOrgMemberMetadataOnboardingPlatformJsonConverter))]
        public global::Composio.GetAuthSessionInfoResponseOrgMemberMetadataOnboardingPlatform? OnboardingPlatform { get; set; }

        /// <summary>
        /// True once the user has completed the consumer onboarding flow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seen_flow_consumer")]
        public bool? SeenFlowConsumer { get; set; }

        /// <summary>
        /// True once the user has completed the developer onboarding flow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seen_flow_developer")]
        public bool? SeenFlowDeveloper { get; set; }

        /// <summary>
        /// True once the user has completed the CLI onboarding flow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seen_flow_cli")]
        public bool? SeenFlowCli { get; set; }

        /// <summary>
        /// True once the user has dismissed the Composio For You announcement modal in the developer dashboard.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seen_connect_announcement")]
        public bool? SeenConnectAnnouncement { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAuthSessionInfoResponseOrgMemberMetadata" /> class.
        /// </summary>
        /// <param name="prefersOldDashboard">
        /// If true, the user will be redirected to the legacy dashboard at platform.composio.dev.
        /// </param>
        /// <param name="onboardingPlatform">
        /// Platform the user onboarded on.
        /// </param>
        /// <param name="seenFlowConsumer">
        /// True once the user has completed the consumer onboarding flow.
        /// </param>
        /// <param name="seenFlowDeveloper">
        /// True once the user has completed the developer onboarding flow.
        /// </param>
        /// <param name="seenFlowCli">
        /// True once the user has completed the CLI onboarding flow.
        /// </param>
        /// <param name="seenConnectAnnouncement">
        /// True once the user has dismissed the Composio For You announcement modal in the developer dashboard.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAuthSessionInfoResponseOrgMemberMetadata(
            bool? prefersOldDashboard,
            global::Composio.GetAuthSessionInfoResponseOrgMemberMetadataOnboardingPlatform? onboardingPlatform,
            bool? seenFlowConsumer,
            bool? seenFlowDeveloper,
            bool? seenFlowCli,
            bool? seenConnectAnnouncement)
        {
            this.PrefersOldDashboard = prefersOldDashboard;
            this.OnboardingPlatform = onboardingPlatform;
            this.SeenFlowConsumer = seenFlowConsumer;
            this.SeenFlowDeveloper = seenFlowDeveloper;
            this.SeenFlowCli = seenFlowCli;
            this.SeenConnectAnnouncement = seenConnectAnnouncement;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAuthSessionInfoResponseOrgMemberMetadata" /> class.
        /// </summary>
        public GetAuthSessionInfoResponseOrgMemberMetadata()
        {
        }

    }
}