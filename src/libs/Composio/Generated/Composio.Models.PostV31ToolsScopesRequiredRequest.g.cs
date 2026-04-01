
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostV31ToolsScopesRequiredRequest
    {
        /// <summary>
        /// Tool slugs to resolve scopes for. All tools must belong to the same toolkit.<br/>
        /// Example: [gmail_view_email, gmail_send_email]
        /// </summary>
        /// <example>[gmail_view_email, gmail_send_email]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Tools { get; set; }

        /// <summary>
        /// Toolkit version to resolve scopes against for the requested toolkit. Defaults to the pinned HTTP version when omitted.<br/>
        /// Example: latest
        /// </summary>
        /// <example>latest</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostV31ToolsScopesRequiredRequest" /> class.
        /// </summary>
        /// <param name="tools">
        /// Tool slugs to resolve scopes for. All tools must belong to the same toolkit.<br/>
        /// Example: [gmail_view_email, gmail_send_email]
        /// </param>
        /// <param name="version">
        /// Toolkit version to resolve scopes against for the requested toolkit. Defaults to the pinned HTTP version when omitted.<br/>
        /// Example: latest
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostV31ToolsScopesRequiredRequest(
            global::System.Collections.Generic.IList<string> tools,
            string? version)
        {
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostV31ToolsScopesRequiredRequest" /> class.
        /// </summary>
        public PostV31ToolsScopesRequiredRequest()
        {
        }
    }
}