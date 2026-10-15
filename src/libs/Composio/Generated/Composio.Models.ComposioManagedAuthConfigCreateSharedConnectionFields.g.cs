
#nullable enable

namespace Composio
{
    /// <summary>
    /// Connection field values inherited by every connected account created under this auth config (for example a region or subdomain). Non-secret values pre-fill the hosted Connect Link form; secret values are redacted in responses and never sent to the end user.
    /// </summary>
    public sealed partial class ComposioManagedAuthConfigCreateSharedConnectionFields
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}