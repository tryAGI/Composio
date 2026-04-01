
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostV31ToolsScopesRequiredResponsePerToolRequirement
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tool { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope_requirements")]
        public global::Composio.PostV31ToolsScopesRequiredResponsePerToolRequirementScopeRequirements? ScopeRequirements { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostV31ToolsScopesRequiredResponsePerToolRequirement" /> class.
        /// </summary>
        /// <param name="tool"></param>
        /// <param name="scopeRequirements"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostV31ToolsScopesRequiredResponsePerToolRequirement(
            string tool,
            global::Composio.PostV31ToolsScopesRequiredResponsePerToolRequirementScopeRequirements? scopeRequirements)
        {
            this.Tool = tool ?? throw new global::System.ArgumentNullException(nameof(tool));
            this.ScopeRequirements = scopeRequirements;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostV31ToolsScopesRequiredResponsePerToolRequirement" /> class.
        /// </summary>
        public PostV31ToolsScopesRequiredResponsePerToolRequirement()
        {
        }
    }
}