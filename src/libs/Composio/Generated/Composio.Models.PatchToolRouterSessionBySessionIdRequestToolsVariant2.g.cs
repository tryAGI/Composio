
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PatchToolRouterSessionBySessionIdRequestToolsVariant2
    {
        /// <summary>
        /// These specific tools will be disabled for this toolkit<br/>
        /// Example: [SLACK_ADD_EMOJI]
        /// </summary>
        /// <example>[SLACK_ADD_EMOJI]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Disable { get; set; }

        /// <summary>
        /// Tool calls matched here pause until the user approves them. A tool needs approval if its toolkit, the tool itself or any of its tags is listed.<br/>
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
        /// Initializes a new instance of the <see cref="PatchToolRouterSessionBySessionIdRequestToolsVariant2" /> class.
        /// </summary>
        /// <param name="disable">
        /// These specific tools will be disabled for this toolkit<br/>
        /// Example: [SLACK_ADD_EMOJI]
        /// </param>
        /// <param name="requireApproval">
        /// Tool calls matched here pause until the user approves them. A tool needs approval if its toolkit, the tool itself or any of its tags is listed.<br/>
        /// Example: [GITHUB_DELETE_A_REPOSITORY]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchToolRouterSessionBySessionIdRequestToolsVariant2(
            global::System.Collections.Generic.IList<string> disable,
            global::System.Collections.Generic.IList<string>? requireApproval)
        {
            this.Disable = disable ?? throw new global::System.ArgumentNullException(nameof(disable));
            this.RequireApproval = requireApproval;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchToolRouterSessionBySessionIdRequestToolsVariant2" /> class.
        /// </summary>
        public PatchToolRouterSessionBySessionIdRequestToolsVariant2()
        {
        }

    }
}