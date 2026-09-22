
#nullable enable

namespace Composio
{
    /// <summary>
    /// Per-toolkit enable or disable lists that restrict premium usage. Toolkits absent from the map have no additional tool restriction. On PATCH, a supplied map replaces all existing tool filters; an empty map clears them, and omission preserves them.
    /// </summary>
    public sealed partial class PostToolRouterSessionRequestPremiumUsageTools
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}