
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PatchWebhookEndpointsByNanoIdRequest
    {
        /// <summary>
        /// Key-value pairs matching the toolkit's setup_fields. Only include fields you want to update — omitted fields are preserved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWebhookEndpointsByNanoIdRequest" /> class.
        /// </summary>
        /// <param name="data">
        /// Key-value pairs matching the toolkit's setup_fields. Only include fields you want to update — omitted fields are preserved.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchWebhookEndpointsByNanoIdRequest(
            global::System.Collections.Generic.Dictionary<string, string> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWebhookEndpointsByNanoIdRequest" /> class.
        /// </summary>
        public PatchWebhookEndpointsByNanoIdRequest()
        {
        }

    }
}