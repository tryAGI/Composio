
#nullable enable

namespace Composio
{
    /// <summary>
    /// Shared credentials inherited by all connected accounts using this auth config. Secret values are redacted in responses, so provide the real values when updating; omit this field to leave them unchanged.
    /// </summary>
    public sealed partial class PatchAuthConfigsByNanoidRequestVariant1SharedCredentials
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}