
#nullable enable

namespace Composio
{
    /// <summary>
    /// With `accept`, the user's answer: fields matching the question's `requested_schema`
    /// </summary>
    public sealed partial class UserInputResponseContent
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}