
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PatchToolRouterSessionBySessionIdResponseConfigPremiumUsage
    {
        /// <summary>
        /// Toolkits eligible for premium usage, as an enabled or disabled list. If absent, no additional toolkit restriction applies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolkits")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.AnyOfJsonConverter<global::Composio.PatchToolRouterSessionBySessionIdResponseConfigPremiumUsageToolkitsVariant1, global::Composio.PatchToolRouterSessionBySessionIdResponseConfigPremiumUsageToolkitsVariant2>))]
        public global::Composio.AnyOf<global::Composio.PatchToolRouterSessionBySessionIdResponseConfigPremiumUsageToolkitsVariant1, global::Composio.PatchToolRouterSessionBySessionIdResponseConfigPremiumUsageToolkitsVariant2>? Toolkits { get; set; }

        /// <summary>
        /// Per-toolkit enabled or disabled lists that restrict premium usage. Toolkits absent from this map have no additional tool restriction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public object? Tools { get; set; }

        /// <summary>
        /// Whether session tool responses return a top-level premium_charge when a charge is available. Defaults to false; controls response visibility only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_premium_charge")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ReturnPremiumCharge { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchToolRouterSessionBySessionIdResponseConfigPremiumUsage" /> class.
        /// </summary>
        /// <param name="returnPremiumCharge">
        /// Whether session tool responses return a top-level premium_charge when a charge is available. Defaults to false; controls response visibility only.
        /// </param>
        /// <param name="toolkits">
        /// Toolkits eligible for premium usage, as an enabled or disabled list. If absent, no additional toolkit restriction applies.
        /// </param>
        /// <param name="tools">
        /// Per-toolkit enabled or disabled lists that restrict premium usage. Toolkits absent from this map have no additional tool restriction.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchToolRouterSessionBySessionIdResponseConfigPremiumUsage(
            bool returnPremiumCharge,
            global::Composio.AnyOf<global::Composio.PatchToolRouterSessionBySessionIdResponseConfigPremiumUsageToolkitsVariant1, global::Composio.PatchToolRouterSessionBySessionIdResponseConfigPremiumUsageToolkitsVariant2>? toolkits,
            object? tools)
        {
            this.Toolkits = toolkits;
            this.Tools = tools;
            this.ReturnPremiumCharge = returnPremiumCharge;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchToolRouterSessionBySessionIdResponseConfigPremiumUsage" /> class.
        /// </summary>
        public PatchToolRouterSessionBySessionIdResponseConfigPremiumUsage()
        {
        }

    }
}