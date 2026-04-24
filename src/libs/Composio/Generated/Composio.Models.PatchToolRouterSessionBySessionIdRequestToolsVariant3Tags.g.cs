
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchToolRouterSessionBySessionIdRequestToolsVariant3Tags
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable")]
        public global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsEnableItem>? Enable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable")]
        public global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsDisableItem>? Disable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchToolRouterSessionBySessionIdRequestToolsVariant3Tags" /> class.
        /// </summary>
        /// <param name="enable"></param>
        /// <param name="disable"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchToolRouterSessionBySessionIdRequestToolsVariant3Tags(
            global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsEnableItem>? enable,
            global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsDisableItem>? disable)
        {
            this.Enable = enable;
            this.Disable = disable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchToolRouterSessionBySessionIdRequestToolsVariant3Tags" /> class.
        /// </summary>
        public PatchToolRouterSessionBySessionIdRequestToolsVariant3Tags()
        {
        }
    }
}