
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PostToolRouterSessionResponseConfigToolkitsVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Disabled { get; set; }

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
        /// Initializes a new instance of the <see cref="PostToolRouterSessionResponseConfigToolkitsVariant2" /> class.
        /// </summary>
        /// <param name="disabled"></param>
        /// <param name="requireApproval">
        /// Tool calls matched here pause until the user approves them.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolRouterSessionResponseConfigToolkitsVariant2(
            global::System.Collections.Generic.IList<string> disabled,
            global::System.Collections.Generic.IList<string>? requireApproval)
        {
            this.Disabled = disabled ?? throw new global::System.ArgumentNullException(nameof(disabled));
            this.RequireApproval = requireApproval;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionResponseConfigToolkitsVariant2" /> class.
        /// </summary>
        public PostToolRouterSessionResponseConfigToolkitsVariant2()
        {
        }

    }
}