
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PostToolRouterSessionResponseConfigToolsVariant4
    {
        /// <summary>
        /// Tool calls matched here pause until the user approves them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_approval")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> RequireApproval { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionResponseConfigToolsVariant4" /> class.
        /// </summary>
        /// <param name="requireApproval">
        /// Tool calls matched here pause until the user approves them.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolRouterSessionResponseConfigToolsVariant4(
            global::System.Collections.Generic.IList<string> requireApproval)
        {
            this.RequireApproval = requireApproval ?? throw new global::System.ArgumentNullException(nameof(requireApproval));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionResponseConfigToolsVariant4" /> class.
        /// </summary>
        public PostToolRouterSessionResponseConfigToolsVariant4()
        {
        }

    }
}