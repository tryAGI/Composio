
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolScopeRequirementsAllOfItemAnyOfItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("all_of")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AllOf { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public global::System.Collections.Generic.IList<string>? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolScopeRequirementsAllOfItemAnyOfItem" /> class.
        /// </summary>
        /// <param name="allOf"></param>
        /// <param name="source"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolScopeRequirementsAllOfItemAnyOfItem(
            global::System.Collections.Generic.IList<string> allOf,
            global::System.Collections.Generic.IList<string>? source)
        {
            this.AllOf = allOf ?? throw new global::System.ArgumentNullException(nameof(allOf));
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolScopeRequirementsAllOfItemAnyOfItem" /> class.
        /// </summary>
        public ToolScopeRequirementsAllOfItemAnyOfItem()
        {
        }

    }
}