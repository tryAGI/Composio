
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PatchWebhookEndpointsByNanoIdResponse
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
        /// The webhook URL to register with the provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WebhookUrl { get; set; }

        /// <summary>
        /// Configured fields with secret values masked
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.Dictionary<string, string>? Data { get; set; }

        /// <summary>
        /// ISO 8601 timestamp
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWebhookEndpointsByNanoIdResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Webhook endpoint nano ID
        /// </param>
        /// <param name="toolkitSlug">
        /// Toolkit this endpoint is for
        /// </param>
        /// <param name="webhookUrl">
        /// The webhook URL to register with the provider
        /// </param>
        /// <param name="createdAt">
        /// ISO 8601 timestamp
        /// </param>
        /// <param name="clientId">
        /// OAuth app client ID
        /// </param>
        /// <param name="data">
        /// Configured fields with secret values masked
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchWebhookEndpointsByNanoIdResponse(
            string id,
            string toolkitSlug,
            string webhookUrl,
            string createdAt,
            string? clientId,
            global::System.Collections.Generic.Dictionary<string, string>? data)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ToolkitSlug = toolkitSlug ?? throw new global::System.ArgumentNullException(nameof(toolkitSlug));
            this.ClientId = clientId;
            this.WebhookUrl = webhookUrl ?? throw new global::System.ArgumentNullException(nameof(webhookUrl));
            this.Data = data;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchWebhookEndpointsByNanoIdResponse" /> class.
        /// </summary>
        public PatchWebhookEndpointsByNanoIdResponse()
        {
        }

    }
}