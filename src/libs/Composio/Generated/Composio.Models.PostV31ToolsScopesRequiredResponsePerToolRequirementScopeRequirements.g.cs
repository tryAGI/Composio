
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostV31ToolsScopesRequiredResponsePerToolRequirementScopeRequirements
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("all_of")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Composio.AnyOf<string, global::Composio.PostV31ToolsScopesRequiredResponsePerToolRequirementScopeRequirementsAllOfItem>> AllOf { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostV31ToolsScopesRequiredResponsePerToolRequirementScopeRequirements" /> class.
        /// </summary>
        /// <param name="allOf"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostV31ToolsScopesRequiredResponsePerToolRequirementScopeRequirements(
            global::System.Collections.Generic.IList<global::Composio.AnyOf<string, global::Composio.PostV31ToolsScopesRequiredResponsePerToolRequirementScopeRequirementsAllOfItem>> allOf)
        {
            this.AllOf = allOf ?? throw new global::System.ArgumentNullException(nameof(allOf));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostV31ToolsScopesRequiredResponsePerToolRequirementScopeRequirements" /> class.
        /// </summary>
        public PostV31ToolsScopesRequiredResponsePerToolRequirementScopeRequirements()
        {
        }
    }
}