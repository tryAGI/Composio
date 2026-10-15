
#nullable enable

namespace Composio
{
    /// <summary>
    /// Connection field values inherited by every connected account created under this auth config. Same value as shared_credentials; secret values are redacted.
    /// </summary>
    public sealed partial class GetAuthConfigsByNanoidResponseSharedConnectionFields
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}