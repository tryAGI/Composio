
#nullable enable

namespace Composio
{
    /// <summary>
    /// Key-value pairs for ALL required setup_fields. Unlike PATCH, all required fields must be provided — this is initial configuration.
    /// </summary>
    public sealed partial class PostWebhookEndpointsByNanoIdRequestData
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}