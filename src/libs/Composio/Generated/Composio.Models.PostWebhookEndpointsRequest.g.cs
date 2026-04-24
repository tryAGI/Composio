
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostWebhookEndpointsRequest
    {
        /// <summary>
        /// Toolkit identifier (e.g., slack, discord)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolkit_slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolkitSlug { get; set; }

        /// <summary>
        /// OAuth app client ID — identifies which app this endpoint is for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostWebhookEndpointsRequest" /> class.
        /// </summary>
        /// <param name="toolkitSlug">
        /// Toolkit identifier (e.g., slack, discord)
        /// </param>
        /// <param name="clientId">
        /// OAuth app client ID — identifies which app this endpoint is for
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostWebhookEndpointsRequest(
            string toolkitSlug,
            string clientId)
        {
            this.ToolkitSlug = toolkitSlug ?? throw new global::System.ArgumentNullException(nameof(toolkitSlug));
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostWebhookEndpointsRequest" /> class.
        /// </summary>
        public PostWebhookEndpointsRequest()
        {
        }
    }
}