
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ToolScopeRequirementsAllOfItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("any_of")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Composio.AnyOf<string, global::Composio.ToolScopeRequirementsAllOfItemAnyOfItem>> AnyOf { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("when")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? When { get; set; }

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
        /// Initializes a new instance of the <see cref="ToolScopeRequirementsAllOfItem" /> class.
        /// </summary>
        /// <param name="anyOf"></param>
        /// <param name="when"></param>
        /// <param name="source"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolScopeRequirementsAllOfItem(
            global::System.Collections.Generic.IList<global::Composio.AnyOf<string, global::Composio.ToolScopeRequirementsAllOfItemAnyOfItem>> anyOf,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? when,
            global::System.Collections.Generic.IList<string>? source)
        {
            this.AnyOf = anyOf ?? throw new global::System.ArgumentNullException(nameof(anyOf));
            this.When = when;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolScopeRequirementsAllOfItem" /> class.
        /// </summary>
        public ToolScopeRequirementsAllOfItem()
        {
        }

    }
}