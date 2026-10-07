
#nullable enable

namespace Composio
{
    /// <summary>
    /// JSON Schema for the answer. As in MCP form mode, it is a flat object whose fields are strings, numbers, booleans, or single- or multi-select enums.
    /// </summary>
    public sealed partial class UserInputRequestRequestedSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}