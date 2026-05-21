
#nullable enable

namespace Composio
{
    /// <summary>
    /// Per-tool overrides keyed by `${toolSlug}:${connectedAccountId ?? "__none__"}`, plus account-wide overrides keyed by `*:${connectedAccountId ?? "__none__"}`. Exact tool overrides take precedence over account-wide overrides. `always_allow` skips the prompt and runs the tool; `always_deny` blocks the tool; `ask_once` prompts once per session (allow/deny) and remembers; `ask_always` prompts on every call with allow-once/allow-session/deny, ignoring any cached session allow. Overrides take precedence over `default`.
    /// </summary>
    public sealed partial class PatchToolRouterSessionBySessionIdRequestExperimentalPermissionsOverrides
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}