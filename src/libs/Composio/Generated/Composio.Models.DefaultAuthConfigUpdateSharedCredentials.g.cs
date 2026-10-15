
#nullable enable

namespace Composio
{
    /// <summary>
    /// Shared credentials inherited by all connected accounts using this auth config. Secret values are redacted in responses, so provide the real values when updating; omit this field to leave them unchanged. DEPRECATED: use `shared_connection_fields` instead. It takes the same value and behaves the same way.
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class DefaultAuthConfigUpdateSharedCredentials
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}