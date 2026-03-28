
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
        /// Shared credentials that will be inherited by connected accounts. For eg: this can be used to share the API key for a tool with all connected accounts using this auth config.
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
        /// <param name="proxyConfig"></param>
        /// <param name="toolAccessConfig"></param>
        /// <param name="sharedCredentials">
        /// Shared credentials that will be inherited by connected accounts. For eg: this can be used to share the API key for a tool with all connected accounts using this auth config.
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
            global::Composio.PatchAuthConfigsByNanoidRequestVariant1ProxyConfig? proxyConfig,
            global::Composio.PatchAuthConfigsByNanoidRequestVariant1ToolAccessConfig? toolAccessConfig,
            global::System.Collections.Generic.Dictionary<string, object?>? sharedCredentials,
            bool? isEnabledForToolRouter)
        {
            this.Type = type;
            this.Name = name;
            this.Credentials = credentials;
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