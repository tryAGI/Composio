
#nullable enable

namespace Composio
{
    /// <summary>
    /// Shared credentials that will be inherited by all connected accounts using this auth config. DEPRECATED: use `shared_connection_fields` instead. It takes the same value and behaves the same way.
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class ComposioManagedAuthConfigCreateSharedCredentials
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}