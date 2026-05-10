
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAuthConfigsResponseItem
    {
        /// <summary>
        /// The unique ID of the authentication configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The UUID of the authentication configuration (for backward compatibility)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uuid { get; set; }

        /// <summary>
        /// The type of the authentication configuration (custom or default)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.GetAuthConfigsResponseItemTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.GetAuthConfigsResponseItemType Type { get; set; }

        /// <summary>
        /// Information about the associated integration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolkit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.GetAuthConfigsResponseItemToolkit Toolkit { get; set; }

        /// <summary>
        /// The display name of the authentication configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The authentication scheme used (e.g., OAuth2, API Key, etc.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_scheme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.GetAuthConfigsResponseItemAuthSchemeJsonConverter))]
        public global::Composio.GetAuthConfigsResponseItemAuthScheme? AuthScheme { get; set; }

        /// <summary>
        /// Whether this authentication configuration is managed by Composio or the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_composio_managed")]
        public bool? IsComposioManaged { get; set; }

        /// <summary>
        /// The authentication credentials (tokens, keys, etc.) - may be partially hidden for security
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials")]
        public global::System.Collections.Generic.Dictionary<string, object?>? Credentials { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proxy_config")]
        public global::Composio.GetAuthConfigsResponseItemProxyConfig? ProxyConfig { get; set; }

        /// <summary>
        /// Current status of the authentication configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.GetAuthConfigsResponseItemStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.GetAuthConfigsResponseItemStatus Status { get; set; }

        /// <summary>
        /// The identifier of the user who created the auth config
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// ISO 8601 date-time when the auth config was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// ISO 8601 date-time when the auth config was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_at")]
        public string? LastUpdatedAt { get; set; }

        /// <summary>
        /// The number of active connections using this auth config
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("no_of_connections")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double NoOfConnections { get; set; }

        /// <summary>
        /// Fields expected during connection initialization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expected_input_fields")]
        public global::System.Collections.Generic.IList<object>? ExpectedInputFields { get; set; }

        /// <summary>
        /// Use tool_access_config instead. This field will be deprecated in the future.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restrict_to_following_tools")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? RestrictToFollowingTools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_access_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.GetAuthConfigsResponseItemToolAccessConfig ToolAccessConfig { get; set; }

        /// <summary>
        /// [EXPERIMENTAL] Shared credentials that will be inherited by all connected accounts using this auth config
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shared_credentials")]
        public global::System.Collections.Generic.Dictionary<string, object?>? SharedCredentials { get; set; }

        /// <summary>
        /// Whether this auth config is enabled for tool router
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_enabled_for_tool_router")]
        public bool? IsEnabledForToolRouter { get; set; }

        /// <summary>
        /// DEPRECATED: This parameter will be removed in a future version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deprecated_params")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::Composio.GetAuthConfigsResponseItemDeprecatedParams? DeprecatedParams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAuthConfigsResponseItem" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the authentication configuration
        /// </param>
        /// <param name="uuid">
        /// The UUID of the authentication configuration (for backward compatibility)
        /// </param>
        /// <param name="type">
        /// The type of the authentication configuration (custom or default)
        /// </param>
        /// <param name="toolkit">
        /// Information about the associated integration
        /// </param>
        /// <param name="name">
        /// The display name of the authentication configuration
        /// </param>
        /// <param name="status">
        /// Current status of the authentication configuration
        /// </param>
        /// <param name="noOfConnections">
        /// The number of active connections using this auth config
        /// </param>
        /// <param name="toolAccessConfig"></param>
        /// <param name="authScheme">
        /// The authentication scheme used (e.g., OAuth2, API Key, etc.)
        /// </param>
        /// <param name="isComposioManaged">
        /// Whether this authentication configuration is managed by Composio or the user
        /// </param>
        /// <param name="credentials">
        /// The authentication credentials (tokens, keys, etc.) - may be partially hidden for security
        /// </param>
        /// <param name="proxyConfig"></param>
        /// <param name="createdBy">
        /// The identifier of the user who created the auth config
        /// </param>
        /// <param name="createdAt">
        /// ISO 8601 date-time when the auth config was created
        /// </param>
        /// <param name="lastUpdatedAt">
        /// ISO 8601 date-time when the auth config was last updated
        /// </param>
        /// <param name="expectedInputFields">
        /// Fields expected during connection initialization
        /// </param>
        /// <param name="sharedCredentials">
        /// [EXPERIMENTAL] Shared credentials that will be inherited by all connected accounts using this auth config
        /// </param>
        /// <param name="isEnabledForToolRouter">
        /// Whether this auth config is enabled for tool router
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAuthConfigsResponseItem(
            string id,
            string uuid,
            global::Composio.GetAuthConfigsResponseItemType type,
            global::Composio.GetAuthConfigsResponseItemToolkit toolkit,
            string name,
            global::Composio.GetAuthConfigsResponseItemStatus status,
            double noOfConnections,
            global::Composio.GetAuthConfigsResponseItemToolAccessConfig toolAccessConfig,
            global::Composio.GetAuthConfigsResponseItemAuthScheme? authScheme,
            bool? isComposioManaged,
            global::System.Collections.Generic.Dictionary<string, object?>? credentials,
            global::Composio.GetAuthConfigsResponseItemProxyConfig? proxyConfig,
            string? createdBy,
            string? createdAt,
            string? lastUpdatedAt,
            global::System.Collections.Generic.IList<object>? expectedInputFields,
            global::System.Collections.Generic.Dictionary<string, object?>? sharedCredentials,
            bool? isEnabledForToolRouter)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Uuid = uuid ?? throw new global::System.ArgumentNullException(nameof(uuid));
            this.Type = type;
            this.Toolkit = toolkit ?? throw new global::System.ArgumentNullException(nameof(toolkit));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AuthScheme = authScheme;
            this.IsComposioManaged = isComposioManaged;
            this.Credentials = credentials;
            this.ProxyConfig = proxyConfig;
            this.Status = status;
            this.CreatedBy = createdBy;
            this.CreatedAt = createdAt;
            this.LastUpdatedAt = lastUpdatedAt;
            this.NoOfConnections = noOfConnections;
            this.ExpectedInputFields = expectedInputFields;
            this.ToolAccessConfig = toolAccessConfig ?? throw new global::System.ArgumentNullException(nameof(toolAccessConfig));
            this.SharedCredentials = sharedCredentials;
            this.IsEnabledForToolRouter = isEnabledForToolRouter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAuthConfigsResponseItem" /> class.
        /// </summary>
        public GetAuthConfigsResponseItem()
        {
        }

    }
}