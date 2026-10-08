
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PostOrgOwnerProjectNewRequest
    {
        /// <summary>
        /// A unique name for your project that follows the required format rules<br/>
        /// Example: my-awesome-project
        /// </summary>
        /// <example>my-awesome-project</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Whether to create an API key for the project. If true, the API key will be created and returned in the response.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("should_create_api_key")]
        public bool? ShouldCreateApiKey { get; set; }

        /// <summary>
        /// IPv4 or IPv6 addresses allowed to use the project API key. Requires should_create_api_key to be true. Omit to allow requests from any IP address.<br/>
        /// Example: [203.0.113.10]
        /// </summary>
        /// <example>[203.0.113.10]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_allowed_ips")]
        public global::System.Collections.Generic.IList<string>? ApiKeyAllowedIps { get; set; }

        /// <summary>
        /// Permission levels for the project API key. Requires should_create_api_key to be true. Omit to create a full-access API key.<br/>
        /// Example: [{"preset":"tool_execution","access":"write"}]
        /// </summary>
        /// <example>[{"preset":"tool_execution","access":"write"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_permissions")]
        public global::System.Collections.Generic.IList<global::Composio.PostOrgOwnerProjectNewRequestApiKeyPermission>? ApiKeyPermissions { get; set; }

        /// <summary>
        /// Configuration for the project. Use zdr_enabled for Zero Data Retention; log_visibility_setting remains supported for existing clients. Do not send both fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::Composio.PostOrgOwnerProjectNewRequestConfig? Config { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostOrgOwnerProjectNewRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// A unique name for your project that follows the required format rules<br/>
        /// Example: my-awesome-project
        /// </param>
        /// <param name="shouldCreateApiKey">
        /// Whether to create an API key for the project. If true, the API key will be created and returned in the response.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="apiKeyAllowedIps">
        /// IPv4 or IPv6 addresses allowed to use the project API key. Requires should_create_api_key to be true. Omit to allow requests from any IP address.<br/>
        /// Example: [203.0.113.10]
        /// </param>
        /// <param name="apiKeyPermissions">
        /// Permission levels for the project API key. Requires should_create_api_key to be true. Omit to create a full-access API key.<br/>
        /// Example: [{"preset":"tool_execution","access":"write"}]
        /// </param>
        /// <param name="config">
        /// Configuration for the project. Use zdr_enabled for Zero Data Retention; log_visibility_setting remains supported for existing clients. Do not send both fields.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostOrgOwnerProjectNewRequest(
            string name,
            bool? shouldCreateApiKey,
            global::System.Collections.Generic.IList<string>? apiKeyAllowedIps,
            global::System.Collections.Generic.IList<global::Composio.PostOrgOwnerProjectNewRequestApiKeyPermission>? apiKeyPermissions,
            global::Composio.PostOrgOwnerProjectNewRequestConfig? config)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ShouldCreateApiKey = shouldCreateApiKey;
            this.ApiKeyAllowedIps = apiKeyAllowedIps;
            this.ApiKeyPermissions = apiKeyPermissions;
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostOrgOwnerProjectNewRequest" /> class.
        /// </summary>
        public PostOrgOwnerProjectNewRequest()
        {
        }

    }
}