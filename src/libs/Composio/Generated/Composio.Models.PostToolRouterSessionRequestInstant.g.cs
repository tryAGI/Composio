
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PostToolRouterSessionRequestInstant
    {
        /// <summary>
        /// Toolkit configuration - specify either enable toolkits (allowlist) or disable toolkits (denylist). Mutually exclusive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolkits")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.AnyOfJsonConverter<global::Composio.PostToolRouterSessionRequestInstantToolkitsVariant1, global::Composio.PostToolRouterSessionRequestInstantToolkitsVariant2>))]
        public global::Composio.AnyOf<global::Composio.PostToolRouterSessionRequestInstantToolkitsVariant1, global::Composio.PostToolRouterSessionRequestInstantToolkitsVariant2>? Toolkits { get; set; }

        /// <summary>
        /// Per-toolkit enable or disable lists that restrict instant usage. Toolkits absent from the map have no additional tool restriction. On PATCH, a supplied map replaces all existing tool filters; an empty map clears them, and omission preserves them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public object? Tools { get; set; }

        /// <summary>
        /// Return the top-level instant_charge in session tool responses when a charge is available. Defaults to false on create; omission on PATCH preserves the current value. Controls response visibility only; it does not enable or disable instant usage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_instant_charge")]
        public bool? ReturnInstantCharge { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequestInstant" /> class.
        /// </summary>
        /// <param name="toolkits">
        /// Toolkit configuration - specify either enable toolkits (allowlist) or disable toolkits (denylist). Mutually exclusive.
        /// </param>
        /// <param name="tools">
        /// Per-toolkit enable or disable lists that restrict instant usage. Toolkits absent from the map have no additional tool restriction. On PATCH, a supplied map replaces all existing tool filters; an empty map clears them, and omission preserves them.
        /// </param>
        /// <param name="returnInstantCharge">
        /// Return the top-level instant_charge in session tool responses when a charge is available. Defaults to false on create; omission on PATCH preserves the current value. Controls response visibility only; it does not enable or disable instant usage.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolRouterSessionRequestInstant(
            global::Composio.AnyOf<global::Composio.PostToolRouterSessionRequestInstantToolkitsVariant1, global::Composio.PostToolRouterSessionRequestInstantToolkitsVariant2>? toolkits,
            object? tools,
            bool? returnInstantCharge)
        {
            this.Toolkits = toolkits;
            this.Tools = tools;
            this.ReturnInstantCharge = returnInstantCharge;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequestInstant" /> class.
        /// </summary>
        public PostToolRouterSessionRequestInstant()
        {
        }

    }
}