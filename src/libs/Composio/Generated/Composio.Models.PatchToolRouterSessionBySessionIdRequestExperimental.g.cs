
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchToolRouterSessionBySessionIdRequestExperimental
    {
        /// <summary>
        /// Per-tool elicitation permission config. Replaces the stored block when provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public global::Composio.PatchToolRouterSessionBySessionIdRequestExperimentalPermissions? Permissions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchToolRouterSessionBySessionIdRequestExperimental" /> class.
        /// </summary>
        /// <param name="permissions">
        /// Per-tool elicitation permission config. Replaces the stored block when provided.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchToolRouterSessionBySessionIdRequestExperimental(
            global::Composio.PatchToolRouterSessionBySessionIdRequestExperimentalPermissions? permissions)
        {
            this.Permissions = permissions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchToolRouterSessionBySessionIdRequestExperimental" /> class.
        /// </summary>
        public PatchToolRouterSessionBySessionIdRequestExperimental()
        {
        }
    }
}