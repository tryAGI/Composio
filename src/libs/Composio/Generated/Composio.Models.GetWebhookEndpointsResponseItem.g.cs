
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWebhookEndpointsResponseItem
    {
        /// <summary>
        /// Webhook endpoint nano ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Toolkit this endpoint is for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolkit_slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolkitSlug { get; set; }

        /// <summary>
        /// OAuth app client ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        public string? ClientId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWebhookEndpointsResponseItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Webhook endpoint nano ID
        /// </param>
        /// <param name="toolkitSlug">
        /// Toolkit this endpoint is for
        /// </param>
        /// <param name="clientId">
        /// OAuth app client ID
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWebhookEndpointsResponseItem(
            string id,
            string toolkitSlug,
            string? clientId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ToolkitSlug = toolkitSlug ?? throw new global::System.ArgumentNullException(nameof(toolkitSlug));
            this.ClientId = clientId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWebhookEndpointsResponseItem" /> class.
        /// </summary>
        public GetWebhookEndpointsResponseItem()
        {
        }
    }
}