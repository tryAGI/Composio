
#nullable enable

namespace Composio
{
    /// <summary>
    /// Per-tool elicitation permission config. Default behavior + per-tool always_allow/always_deny overrides. Mutation via PATCH.
    /// </summary>
    public sealed partial class PostToolRouterSessionRequestExperimentalPermissions
    {
        /// <summary>
        /// Default elicitation behavior when no override matches. `allow_all` runs every tool without prompting; `ask_every_call` prompts on each invocation; `ask_once_per_session` prompts once and remembers the answer for the rest of the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PostToolRouterSessionRequestExperimentalPermissionsDefaultJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.PostToolRouterSessionRequestExperimentalPermissionsDefault Default { get; set; }

        /// <summary>
        /// Per-tool overrides keyed by `${toolSlug}:${connectedAccountId ?? "__none__"}`, plus account-wide overrides keyed by `*:${connectedAccountId ?? "__none__"}`. Exact tool overrides take precedence over account-wide overrides. `always_allow` skips the prompt and runs the tool; `always_deny` blocks the tool; `ask_once` prompts once per session (allow/deny) and remembers; `ask_always` prompts on every call with allow-once/allow-session/deny, ignoring any cached session allow. Overrides take precedence over `default`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overrides")]
        public global::System.Collections.Generic.Dictionary<string, global::Composio.PostToolRouterSessionRequestExperimentalPermissionsOverrides2>? Overrides { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequestExperimentalPermissions" /> class.
        /// </summary>
        /// <param name="default">
        /// Default elicitation behavior when no override matches. `allow_all` runs every tool without prompting; `ask_every_call` prompts on each invocation; `ask_once_per_session` prompts once and remembers the answer for the rest of the session.
        /// </param>
        /// <param name="overrides">
        /// Per-tool overrides keyed by `${toolSlug}:${connectedAccountId ?? "__none__"}`, plus account-wide overrides keyed by `*:${connectedAccountId ?? "__none__"}`. Exact tool overrides take precedence over account-wide overrides. `always_allow` skips the prompt and runs the tool; `always_deny` blocks the tool; `ask_once` prompts once per session (allow/deny) and remembers; `ask_always` prompts on every call with allow-once/allow-session/deny, ignoring any cached session allow. Overrides take precedence over `default`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolRouterSessionRequestExperimentalPermissions(
            global::Composio.PostToolRouterSessionRequestExperimentalPermissionsDefault @default,
            global::System.Collections.Generic.Dictionary<string, global::Composio.PostToolRouterSessionRequestExperimentalPermissionsOverrides2>? overrides)
        {
            this.Default = @default;
            this.Overrides = overrides;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequestExperimentalPermissions" /> class.
        /// </summary>
        public PostToolRouterSessionRequestExperimentalPermissions()
        {
        }

    }
}