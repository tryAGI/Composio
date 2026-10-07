
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PostToolRouterSessionRequestToolsVariant4
    {
        /// <summary>
        /// Experimental: tool calls matched here pause until the user approves them. A tool needs approval if its toolkit, the tool itself or any of its tags is listed.<br/>
        /// Example: [GITHUB_DELETE_A_REPOSITORY]
        /// </summary>
        /// <example>[GITHUB_DELETE_A_REPOSITORY]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_approval")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> RequireApproval { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequestToolsVariant4" /> class.
        /// </summary>
        /// <param name="requireApproval">
        /// Experimental: tool calls matched here pause until the user approves them. A tool needs approval if its toolkit, the tool itself or any of its tags is listed.<br/>
        /// Example: [GITHUB_DELETE_A_REPOSITORY]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolRouterSessionRequestToolsVariant4(
            global::System.Collections.Generic.IList<string> requireApproval)
        {
            this.RequireApproval = requireApproval ?? throw new global::System.ArgumentNullException(nameof(requireApproval));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequestToolsVariant4" /> class.
        /// </summary>
        public PostToolRouterSessionRequestToolsVariant4()
        {
        }

    }
}