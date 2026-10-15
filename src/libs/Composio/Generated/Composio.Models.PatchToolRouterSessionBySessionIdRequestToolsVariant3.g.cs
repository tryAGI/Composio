
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PatchToolRouterSessionBySessionIdRequestToolsVariant3
    {
        /// <summary>
        /// Tags for this toolkit. Any `tags` object here fully replaces the session-wide `tags` for this toolkit, including one that only sets `require_approval`. Array format is treated as an enabled list.<br/>
        /// Example: {"disable":["openWorldHint"],"require_approval":["destructiveHint"]}
        /// </summary>
        /// <example>{"disable":["openWorldHint"],"require_approval":["destructiveHint"]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdRequestToolsVariant3Tag>, global::Composio.PatchToolRouterSessionBySessionIdRequestToolsVariant3Tags>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.AnyOf<global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdRequestToolsVariant3Tag>, global::Composio.PatchToolRouterSessionBySessionIdRequestToolsVariant3Tags> Tags { get; set; }

        /// <summary>
        /// Tool calls matched here pause until the user approves them. Setting this toolkit's own list, even an empty one, replaces the session-wide `tags.require_approval` for its tools.<br/>
        /// Example: [GITHUB_DELETE_A_REPOSITORY]
        /// </summary>
        /// <example>[GITHUB_DELETE_A_REPOSITORY]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_approval")]
        public global::System.Collections.Generic.IList<string>? RequireApproval { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchToolRouterSessionBySessionIdRequestToolsVariant3" /> class.
        /// </summary>
        /// <param name="tags">
        /// Tags for this toolkit. Any `tags` object here fully replaces the session-wide `tags` for this toolkit, including one that only sets `require_approval`. Array format is treated as an enabled list.<br/>
        /// Example: {"disable":["openWorldHint"],"require_approval":["destructiveHint"]}
        /// </param>
        /// <param name="requireApproval">
        /// Tool calls matched here pause until the user approves them. Setting this toolkit's own list, even an empty one, replaces the session-wide `tags.require_approval` for its tools.<br/>
        /// Example: [GITHUB_DELETE_A_REPOSITORY]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchToolRouterSessionBySessionIdRequestToolsVariant3(
            global::Composio.AnyOf<global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdRequestToolsVariant3Tag>, global::Composio.PatchToolRouterSessionBySessionIdRequestToolsVariant3Tags> tags,
            global::System.Collections.Generic.IList<string>? requireApproval)
        {
            this.Tags = tags;
            this.RequireApproval = requireApproval;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchToolRouterSessionBySessionIdRequestToolsVariant3" /> class.
        /// </summary>
        public PatchToolRouterSessionBySessionIdRequestToolsVariant3()
        {
        }

    }
}