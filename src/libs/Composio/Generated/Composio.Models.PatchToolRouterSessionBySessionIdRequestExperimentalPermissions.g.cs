
#nullable enable

namespace Composio
{
    /// <summary>
    /// Per-tool elicitation permission config. Replaces the stored block when provided.
    /// </summary>
    public sealed partial class PatchToolRouterSessionBySessionIdRequestExperimentalPermissions
    {
        /// <summary>
        /// Default elicitation behavior when no override matches. `allow_all` runs every tool without prompting; `ask_every_call` prompts on each invocation; `ask_once_per_session` prompts once and remembers the answer for the rest of the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PatchToolRouterSessionBySessionIdRequestExperimentalPermissionsDefaultJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.PatchToolRouterSessionBySessionIdRequestExperimentalPermissionsDefault Default { get; set; }

        /// <summary>
        /// Per-tool overrides keyed by `${toolSlug}:${connectedAccountId ?? "__none__"}`. `always_allow` skips the prompt and runs the tool; `always_deny` blocks the tool. Overrides take precedence over `default` and the session cache.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overrides")]
        public global::System.Collections.Generic.Dictionary<string, global::Composio.PatchToolRouterSessionBySessionIdRequestExperimentalPermissionsOverrides2>? Overrides { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchToolRouterSessionBySessionIdRequestExperimentalPermissions" /> class.
        /// </summary>
        /// <param name="default">
        /// Default elicitation behavior when no override matches. `allow_all` runs every tool without prompting; `ask_every_call` prompts on each invocation; `ask_once_per_session` prompts once and remembers the answer for the rest of the session.
        /// </param>
        /// <param name="overrides">
        /// Per-tool overrides keyed by `${toolSlug}:${connectedAccountId ?? "__none__"}`. `always_allow` skips the prompt and runs the tool; `always_deny` blocks the tool. Overrides take precedence over `default` and the session cache.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchToolRouterSessionBySessionIdRequestExperimentalPermissions(
            global::Composio.PatchToolRouterSessionBySessionIdRequestExperimentalPermissionsDefault @default,
            global::System.Collections.Generic.Dictionary<string, global::Composio.PatchToolRouterSessionBySessionIdRequestExperimentalPermissionsOverrides2>? overrides)
        {
            this.Default = @default;
            this.Overrides = overrides;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchToolRouterSessionBySessionIdRequestExperimentalPermissions" /> class.
        /// </summary>
        public PatchToolRouterSessionBySessionIdRequestExperimentalPermissions()
        {
        }
    }
}