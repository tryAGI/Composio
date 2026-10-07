
#nullable enable

namespace Composio
{
    /// <summary>
    /// MCP tool annotation hints for filtering tools with enabled/disabled support, and experimentally the tags whose tools need approval. enabled: tags that the tool must have at least one of. disabled: tags that the tool must NOT have any of. Both conditions must be satisfied.
    /// </summary>
    public sealed partial class PatchToolRouterSessionBySessionIdResponseConfigTags
    {
        /// <summary>
        /// Tags that the tool must have at least one of
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdResponseConfigTagsEnabledItem>? Enabled { get; set; }

        /// <summary>
        /// Tags that the tool must NOT have any of
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        public global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdResponseConfigTagsDisabledItem>? Disabled { get; set; }

        /// <summary>
        /// Tool calls matched here pause until the user approves them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_approval")]
        public global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdResponseConfigTagsRequireApprovalItem>? RequireApproval { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchToolRouterSessionBySessionIdResponseConfigTags" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Tags that the tool must have at least one of
        /// </param>
        /// <param name="disabled">
        /// Tags that the tool must NOT have any of
        /// </param>
        /// <param name="requireApproval">
        /// Tool calls matched here pause until the user approves them.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchToolRouterSessionBySessionIdResponseConfigTags(
            global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdResponseConfigTagsEnabledItem>? enabled,
            global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdResponseConfigTagsDisabledItem>? disabled,
            global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdResponseConfigTagsRequireApprovalItem>? requireApproval)
        {
            this.Enabled = enabled;
            this.Disabled = disabled;
            this.RequireApproval = requireApproval;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchToolRouterSessionBySessionIdResponseConfigTags" /> class.
        /// </summary>
        public PatchToolRouterSessionBySessionIdResponseConfigTags()
        {
        }

    }
}