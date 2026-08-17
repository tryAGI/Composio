
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchAuthConfigsByNanoidRequestVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PatchAuthConfigsByNanoidRequestVariant1TypeJsonConverter))]
        public global::Composio.PatchAuthConfigsByNanoidRequestVariant1Type Type { get; set; }

        /// <summary>
        /// The display name of the authentication configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials")]
        public global::Composio.PatchAuthConfigsByNanoidRequestVariant1Credentials? Credentials { get; set; }

        /// <summary>
        /// [EXPERIMENTAL] Client-sealed secret fields to redeem through the organization keyring instance (GET /api/v3.1/keyring/transfer_keys). The plaintext must not also appear in credentials. Rotates the stored client_secret without Apollo ever holding it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sealed_credentials")]
        public global::System.Collections.Generic.Dictionary<string, string>? SealedCredentials { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proxy_config")]
        public global::Composio.PatchAuthConfigsByNanoidRequestVariant1ProxyConfig? ProxyConfig { get; set; }

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
        public global::Composio.PatchAuthConfigsByNanoidRequestVariant1ToolAccessConfig? ToolAccessConfig { get; set; }

        /// <summary>
        /// Shared credentials inherited by all connected accounts using this auth config. Secret values are redacted in responses, so provide the real values when updating; omit this field to leave them unchanged.
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
        /// Initializes a new instance of the <see cref="PatchAuthConfigsByNanoidRequestVariant1" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name">
        /// The display name of the authentication configuration
        /// </param>
        /// <param name="credentials"></param>
        /// <param name="sealedCredentials">
        /// [EXPERIMENTAL] Client-sealed secret fields to redeem through the organization keyring instance (GET /api/v3.1/keyring/transfer_keys). The plaintext must not also appear in credentials. Rotates the stored client_secret without Apollo ever holding it.
        /// </param>
        /// <param name="proxyConfig"></param>
        /// <param name="toolAccessConfig"></param>
        /// <param name="sharedCredentials">
        /// Shared credentials inherited by all connected accounts using this auth config. Secret values are redacted in responses, so provide the real values when updating; omit this field to leave them unchanged.
        /// </param>
        /// <param name="isEnabledForToolRouter">
        /// Whether this auth config is enabled for tool router
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchAuthConfigsByNanoidRequestVariant1(
            global::Composio.PatchAuthConfigsByNanoidRequestVariant1Type type,
            string? name,
            global::Composio.PatchAuthConfigsByNanoidRequestVariant1Credentials? credentials,
            global::System.Collections.Generic.Dictionary<string, string>? sealedCredentials,
            global::Composio.PatchAuthConfigsByNanoidRequestVariant1ProxyConfig? proxyConfig,
            global::Composio.PatchAuthConfigsByNanoidRequestVariant1ToolAccessConfig? toolAccessConfig,
            global::System.Collections.Generic.Dictionary<string, object?>? sharedCredentials,
            bool? isEnabledForToolRouter)
        {
            this.Type = type;
            this.Name = name;
            this.Credentials = credentials;
            this.SealedCredentials = sealedCredentials;
            this.ProxyConfig = proxyConfig;
            this.ToolAccessConfig = toolAccessConfig;
            this.SharedCredentials = sharedCredentials;
            this.IsEnabledForToolRouter = isEnabledForToolRouter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchAuthConfigsByNanoidRequestVariant1" /> class.
        /// </summary>
        public PatchAuthConfigsByNanoidRequestVariant1()
        {
        }

    }
}