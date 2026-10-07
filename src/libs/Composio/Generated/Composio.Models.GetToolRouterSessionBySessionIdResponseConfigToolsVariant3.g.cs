
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetToolRouterSessionBySessionIdResponseConfigToolsVariant3
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3Tags Tags { get; set; }

        /// <summary>
        /// Tool calls matched here pause until the user approves them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_approval")]
        public global::System.Collections.Generic.IList<string>? RequireApproval { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolRouterSessionBySessionIdResponseConfigToolsVariant3" /> class.
        /// </summary>
        /// <param name="tags"></param>
        /// <param name="requireApproval">
        /// Tool calls matched here pause until the user approves them.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetToolRouterSessionBySessionIdResponseConfigToolsVariant3(
            global::Composio.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3Tags tags,
            global::System.Collections.Generic.IList<string>? requireApproval)
        {
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.RequireApproval = requireApproval;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolRouterSessionBySessionIdResponseConfigToolsVariant3" /> class.
        /// </summary>
        public GetToolRouterSessionBySessionIdResponseConfigToolsVariant3()
        {
        }

    }
}