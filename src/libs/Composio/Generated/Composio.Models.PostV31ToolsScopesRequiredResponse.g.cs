
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostV31ToolsScopesRequiredResponse
    {
        /// <summary>
        /// A combined list of all unique scopes required by the specified tools<br/>
        /// Example: [channels:read, chat:write, https://www.googleapis.com/auth/gmail.modify, repo, user:email]
        /// </summary>
        /// <example>[channels:read, chat:write, https://www.googleapis.com/auth/gmail.modify, repo, user:email]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes_required")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ScopesRequired { get; set; }

        /// <summary>
        /// Per-tool structured scope requirements. Null scope_requirements marks unmigrated legacy tools.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("per_tool_requirements")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Composio.PostV31ToolsScopesRequiredResponsePerToolRequirement> PerToolRequirements { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostV31ToolsScopesRequiredResponse" /> class.
        /// </summary>
        /// <param name="scopesRequired">
        /// A combined list of all unique scopes required by the specified tools<br/>
        /// Example: [channels:read, chat:write, https://www.googleapis.com/auth/gmail.modify, repo, user:email]
        /// </param>
        /// <param name="perToolRequirements">
        /// Per-tool structured scope requirements. Null scope_requirements marks unmigrated legacy tools.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostV31ToolsScopesRequiredResponse(
            global::System.Collections.Generic.IList<string> scopesRequired,
            global::System.Collections.Generic.IList<global::Composio.PostV31ToolsScopesRequiredResponsePerToolRequirement> perToolRequirements)
        {
            this.ScopesRequired = scopesRequired ?? throw new global::System.ArgumentNullException(nameof(scopesRequired));
            this.PerToolRequirements = perToolRequirements ?? throw new global::System.ArgumentNullException(nameof(perToolRequirements));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostV31ToolsScopesRequiredResponse" /> class.
        /// </summary>
        public PostV31ToolsScopesRequiredResponse()
        {
        }
    }
}