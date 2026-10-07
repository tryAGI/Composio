
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PatchToolRouterSessionBySessionIdRequestToolsVariant1
    {
        /// <summary>
        /// Only these specific tools will be available for this toolkit<br/>
        /// Example: [GMAIL_SEND_EMAIL, GMAIL_FETCH_EMAILS]
        /// </summary>
        /// <example>[GMAIL_SEND_EMAIL, GMAIL_FETCH_EMAILS]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Enable { get; set; }

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
        /// Initializes a new instance of the <see cref="PatchToolRouterSessionBySessionIdRequestToolsVariant1" /> class.
        /// </summary>
        /// <param name="enable">
        /// Only these specific tools will be available for this toolkit<br/>
        /// Example: [GMAIL_SEND_EMAIL, GMAIL_FETCH_EMAILS]
        /// </param>
        /// <param name="requireApproval">
        /// Tool calls matched here pause until the user approves them. A tool needs approval if its toolkit, the tool itself or any of its tags is listed.<br/>
        /// Example: [GITHUB_DELETE_A_REPOSITORY]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchToolRouterSessionBySessionIdRequestToolsVariant1(
            global::System.Collections.Generic.IList<string> enable,
            global::System.Collections.Generic.IList<string>? requireApproval)
        {
            this.Enable = enable ?? throw new global::System.ArgumentNullException(nameof(enable));
            this.RequireApproval = requireApproval;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchToolRouterSessionBySessionIdRequestToolsVariant1" /> class.
        /// </summary>
        public PatchToolRouterSessionBySessionIdRequestToolsVariant1()
        {
        }

    }
}