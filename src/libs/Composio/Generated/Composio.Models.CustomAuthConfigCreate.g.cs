
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomAuthConfigCreate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.CustomAuthConfigCreateTypeJsonConverter))]
        public global::Composio.CustomAuthConfigCreateType Type { get; set; }

        /// <summary>
        /// The name of the integration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authScheme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.CustomAuthConfigCreateAuthSchemeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.CustomAuthConfigCreateAuthScheme AuthScheme { get; set; }

        /// <summary>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials")]
        public global::Composio.CustomAuthConfigCreateCredentials? Credentials { get; set; }

        /// <summary>
        /// [EXPERIMENTAL] Client-sealed secret fields to redeem through the organization keyring instance (GET /api/v3.1/keyring/transfer_keys). The plaintext must not also appear in credentials.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sealed_credentials")]
        public global::System.Collections.Generic.Dictionary<string, string>? SealedCredentials { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proxy_config")]
        public global::Composio.CustomAuthConfigCreateProxyConfig? ProxyConfig { get; set; }

        /// <summary>
        /// Use tool_access_config instead. This field will be deprecated in the future.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restrict_to_following_tools")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? RestrictToFollowingTools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_access_config")]
        public global::Composio.CustomAuthConfigCreateToolAccessConfig? ToolAccessConfig { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomAuthConfigCreate" /> class.
        /// </summary>
        /// <param name="authScheme"></param>
        /// <param name="type"></param>
        /// <param name="name">
        /// The name of the integration
        /// </param>
        /// <param name="credentials">
        /// Default Value: {}
        /// </param>
        /// <param name="sealedCredentials">
        /// [EXPERIMENTAL] Client-sealed secret fields to redeem through the organization keyring instance (GET /api/v3.1/keyring/transfer_keys). The plaintext must not also appear in credentials.
        /// </param>
        /// <param name="proxyConfig"></param>
        /// <param name="toolAccessConfig"></param>
        /// <param name="sharedCredentials">
        /// [EXPERIMENTAL] Shared credentials that will be inherited by all connected accounts using this auth config
        /// </param>
        /// <param name="isEnabledForToolRouter">
        /// Whether this auth config is enabled for tool router
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomAuthConfigCreate(
            global::Composio.CustomAuthConfigCreateAuthScheme authScheme,
            global::Composio.CustomAuthConfigCreateType type,
            string? name,
            global::Composio.CustomAuthConfigCreateCredentials? credentials,
            global::System.Collections.Generic.Dictionary<string, string>? sealedCredentials,
            global::Composio.CustomAuthConfigCreateProxyConfig? proxyConfig,
            global::Composio.CustomAuthConfigCreateToolAccessConfig? toolAccessConfig,
            global::System.Collections.Generic.Dictionary<string, object?>? sharedCredentials,
            bool? isEnabledForToolRouter)
        {
            this.Type = type;
            this.Name = name;
            this.AuthScheme = authScheme;
            this.Credentials = credentials;
            this.SealedCredentials = sealedCredentials;
            this.ProxyConfig = proxyConfig;
            this.ToolAccessConfig = toolAccessConfig;
            this.SharedCredentials = sharedCredentials;
            this.IsEnabledForToolRouter = isEnabledForToolRouter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomAuthConfigCreate" /> class.
        /// </summary>
        public CustomAuthConfigCreate()
        {
        }

    }
}