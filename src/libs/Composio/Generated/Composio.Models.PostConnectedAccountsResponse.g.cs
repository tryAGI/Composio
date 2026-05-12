
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostConnectedAccountsResponse
    {
        /// <summary>
        /// The id of the connected account
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The connection data of the connected account
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectionData")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostConnectedAccountsResponseConnectionDataVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant4, global::Composio.PostConnectedAccountsResponseConnectionDataVariant5, global::Composio.PostConnectedAccountsResponseConnectionDataVariant6, global::Composio.PostConnectedAccountsResponseConnectionDataVariant7, global::Composio.PostConnectedAccountsResponseConnectionDataVariant8, global::Composio.PostConnectedAccountsResponseConnectionDataVariant9, global::Composio.PostConnectedAccountsResponseConnectionDataVariant10, global::Composio.PostConnectedAccountsResponseConnectionDataVariant11, global::Composio.PostConnectedAccountsResponseConnectionDataVariant12, global::Composio.PostConnectedAccountsResponseConnectionDataVariant13, global::Composio.PostConnectedAccountsResponseConnectionDataVariant14>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.OneOf<global::Composio.PostConnectedAccountsResponseConnectionDataVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant4, global::Composio.PostConnectedAccountsResponseConnectionDataVariant5, global::Composio.PostConnectedAccountsResponseConnectionDataVariant6, global::Composio.PostConnectedAccountsResponseConnectionDataVariant7, global::Composio.PostConnectedAccountsResponseConnectionDataVariant8, global::Composio.PostConnectedAccountsResponseConnectionDataVariant9, global::Composio.PostConnectedAccountsResponseConnectionDataVariant10, global::Composio.PostConnectedAccountsResponseConnectionDataVariant11, global::Composio.PostConnectedAccountsResponseConnectionDataVariant12, global::Composio.PostConnectedAccountsResponseConnectionDataVariant13, global::Composio.PostConnectedAccountsResponseConnectionDataVariant14> ConnectionData { get; set; }

        /// <summary>
        /// DEPRECATED: This field will be removed in a future version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.PostConnectedAccountsResponseStatus Status { get; set; }

        /// <summary>
        /// DEPRECATED: This field will be removed in a future version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect_url")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? RedirectUrl { get; set; }

        /// <summary>
        /// DEPRECATED: This field will be removed in a future version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect_uri")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? RedirectUri { get; set; }

        /// <summary>
        /// DEPRECATED: This field will be removed in a future version. Please use id and auth_config.id instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deprecated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.PostConnectedAccountsResponseDeprecated Deprecated { get; set; }

        /// <summary>
        /// Experimental features - not stable, may be modified or removed in future versions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experimental")]
        public global::Composio.PostConnectedAccountsResponseExperimental? Experimental { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The id of the connected account
        /// </param>
        /// <param name="connectionData">
        /// The connection data of the connected account
        /// </param>
        /// <param name="status">
        /// DEPRECATED: This field will be removed in a future version
        /// </param>
        /// <param name="deprecated">
        /// DEPRECATED: This field will be removed in a future version. Please use id and auth_config.id instead.
        /// </param>
        /// <param name="experimental">
        /// Experimental features - not stable, may be modified or removed in future versions.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostConnectedAccountsResponse(
            string id,
            global::Composio.OneOf<global::Composio.PostConnectedAccountsResponseConnectionDataVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant4, global::Composio.PostConnectedAccountsResponseConnectionDataVariant5, global::Composio.PostConnectedAccountsResponseConnectionDataVariant6, global::Composio.PostConnectedAccountsResponseConnectionDataVariant7, global::Composio.PostConnectedAccountsResponseConnectionDataVariant8, global::Composio.PostConnectedAccountsResponseConnectionDataVariant9, global::Composio.PostConnectedAccountsResponseConnectionDataVariant10, global::Composio.PostConnectedAccountsResponseConnectionDataVariant11, global::Composio.PostConnectedAccountsResponseConnectionDataVariant12, global::Composio.PostConnectedAccountsResponseConnectionDataVariant13, global::Composio.PostConnectedAccountsResponseConnectionDataVariant14> connectionData,
            global::Composio.PostConnectedAccountsResponseStatus status,
            global::Composio.PostConnectedAccountsResponseDeprecated deprecated,
            global::Composio.PostConnectedAccountsResponseExperimental? experimental)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ConnectionData = connectionData;
            this.Status = status;
            this.Deprecated = deprecated ?? throw new global::System.ArgumentNullException(nameof(deprecated));
            this.Experimental = experimental;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsResponse" /> class.
        /// </summary>
        public PostConnectedAccountsResponse()
        {
        }

    }
}