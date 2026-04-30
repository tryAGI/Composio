
#nullable enable

namespace Composio
{
    /// <summary>
    /// Per-tool overrides keyed by `${toolSlug}:${connectedAccountId ?? "__none__"}`. `always_allow` skips the prompt and runs the tool; `always_deny` blocks the tool. Overrides take precedence over `default` and the session cache.
    /// </summary>
    public sealed partial class PostToolRouterSessionRequestExperimentalPermissionsOverrides
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}