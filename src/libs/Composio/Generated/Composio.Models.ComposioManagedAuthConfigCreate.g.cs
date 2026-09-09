
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ComposioManagedAuthConfigCreate
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.ComposioManagedAuthConfigCreateTypeJsonConverter))]
        public global::Composio.ComposioManagedAuthConfigCreateType Type { get; set; }

        /// <summary>
        /// The name of the integration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials")]
        public global::Composio.ComposioManagedAuthConfigCreateCredentials? Credentials { get; set; }

        /// <summary>
        /// DEPRECATED: use [Get required scopes](https://docs.composio.dev/reference/api-reference/toolkits/recommendToolkitScopes) to resolve the scopes for the tools you need, then pass those scopes in `credentials.scopes`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_access_config")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::Composio.ComposioManagedAuthConfigCreateToolAccessConfig? ToolAccessConfig { get; set; }

        /// <summary>
        /// List of tool slugs this auth config is restricted to use with. DEPRECATED: use [Get required scopes](https://docs.composio.dev/reference/api-reference/toolkits/recommendToolkitScopes) to resolve the scopes for the tools you need, then pass those scopes in `credentials.scopes`.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restrict_to_following_tools")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? RestrictToFollowingTools { get; set; }

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
        /// Initializes a new instance of the <see cref="ComposioManagedAuthConfigCreate" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name">
        /// The name of the integration
        /// </param>
        /// <param name="credentials">
        /// Default Value: {}
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
        public ComposioManagedAuthConfigCreate(
            global::Composio.ComposioManagedAuthConfigCreateType type,
            string? name,
            global::Composio.ComposioManagedAuthConfigCreateCredentials? credentials,
            global::System.Collections.Generic.Dictionary<string, object?>? sharedCredentials,
            bool? isEnabledForToolRouter)
        {
            this.Type = type;
            this.Name = name;
            this.Credentials = credentials;
            this.SharedCredentials = sharedCredentials;
            this.IsEnabledForToolRouter = isEnabledForToolRouter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComposioManagedAuthConfigCreate" /> class.
        /// </summary>
        public ComposioManagedAuthConfigCreate()
        {
        }

    }
}