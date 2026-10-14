
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PatchToolRouterSessionBySessionIdResponseConfigInstant
    {
        /// <summary>
        /// Toolkits eligible for instant usage, as an enabled or disabled list. If absent, no additional toolkit restriction applies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolkits")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.AnyOfJsonConverter<global::Composio.PatchToolRouterSessionBySessionIdResponseConfigInstantToolkitsVariant1, global::Composio.PatchToolRouterSessionBySessionIdResponseConfigInstantToolkitsVariant2>))]
        public global::Composio.AnyOf<global::Composio.PatchToolRouterSessionBySessionIdResponseConfigInstantToolkitsVariant1, global::Composio.PatchToolRouterSessionBySessionIdResponseConfigInstantToolkitsVariant2>? Toolkits { get; set; }

        /// <summary>
        /// Per-toolkit enabled or disabled lists that restrict instant usage. Toolkits absent from this map have no additional tool restriction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public object? Tools { get; set; }

        /// <summary>
        /// Whether session tool responses return a top-level instant_charge when a charge is available. Defaults to false; controls response visibility only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_instant_charge")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ReturnInstantCharge { get; set; }

        /// <summary>
        /// Experimental. Whether tool search results show each instant tool's price, under instant_account.prices. Defaults to false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_prices_in_search")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ReturnPricesInSearch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchToolRouterSessionBySessionIdResponseConfigInstant" /> class.
        /// </summary>
        /// <param name="returnInstantCharge">
        /// Whether session tool responses return a top-level instant_charge when a charge is available. Defaults to false; controls response visibility only.
        /// </param>
        /// <param name="returnPricesInSearch">
        /// Experimental. Whether tool search results show each instant tool's price, under instant_account.prices. Defaults to false.
        /// </param>
        /// <param name="toolkits">
        /// Toolkits eligible for instant usage, as an enabled or disabled list. If absent, no additional toolkit restriction applies.
        /// </param>
        /// <param name="tools">
        /// Per-toolkit enabled or disabled lists that restrict instant usage. Toolkits absent from this map have no additional tool restriction.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchToolRouterSessionBySessionIdResponseConfigInstant(
            bool returnInstantCharge,
            bool returnPricesInSearch,
            global::Composio.AnyOf<global::Composio.PatchToolRouterSessionBySessionIdResponseConfigInstantToolkitsVariant1, global::Composio.PatchToolRouterSessionBySessionIdResponseConfigInstantToolkitsVariant2>? toolkits,
            object? tools)
        {
            this.Toolkits = toolkits;
            this.Tools = tools;
            this.ReturnInstantCharge = returnInstantCharge;
            this.ReturnPricesInSearch = returnPricesInSearch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchToolRouterSessionBySessionIdResponseConfigInstant" /> class.
        /// </summary>
        public PatchToolRouterSessionBySessionIdResponseConfigInstant()
        {
        }

    }
}