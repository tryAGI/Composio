
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostV31ToolsExecuteByToolSlugRequest
    {
        /// <summary>
        /// Unique identifier for the connected account to use for authentication<br/>
        /// Example: ca_1a2b3c4d5e6f
        /// </summary>
        /// <example>ca_1a2b3c4d5e6f</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("connected_account_id")]
        public string? ConnectedAccountId { get; set; }

        /// <summary>
        /// Deprecated: please use user_id instead. Entity identifier for multi-entity connected accounts (e.g. multiple repositories, organizations)<br/>
        /// Example: repo-123
        /// </summary>
        /// <example>repo-123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? EntityId { get; set; }

        /// <summary>
        /// User id for multi-user connected accounts (e.g. multiple users, organizations)<br/>
        /// Example: user-123
        /// </summary>
        /// <example>user-123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Tool version to execute (defaults to "00000000_00" if not specified)<br/>
        /// Example: latest
        /// </summary>
        /// <example>latest</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Custom authentication parameters for tools that support parameterized authentication<br/>
        /// Example: {"base_url":"https://api.example.com","parameters":[{"name":"x-api-key","value":"secret-key","in":"header"}]}
        /// </summary>
        /// <example>{"base_url":"https://api.example.com","parameters":[{"name":"x-api-key","value":"secret-key","in":"header"}]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_auth_params")]
        public global::Composio.PostV31ToolsExecuteByToolSlugRequestCustomAuthParams? CustomAuthParams { get; set; }

        /// <summary>
        /// Custom connection data for tools that support custom connection data<br/>
        /// Example: {"authScheme":"OAUTH2","toolkitSlug":"github","val":{"access_token":"secret-token"}}
        /// </summary>
        /// <example>{"authScheme":"OAUTH2","toolkitSlug":"github","val":{"access_token":"secret-token"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_connection_data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant1, global::Composio.PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant2, global::Composio.PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant3, global::Composio.PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant4, global::Composio.PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant5, global::Composio.PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant6, global::Composio.PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant7, global::Composio.PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant8, global::Composio.PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant9, global::Composio.PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant10, global::Composio.PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant11>))]
        public global::Composio.OneOf<global::Composio.PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant1, global::Composio.PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant2, global::Composio.PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant3, global::Composio.PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant4, global::Composio.PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant5, global::Composio.PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant6, global::Composio.PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant7, global::Composio.PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant8, global::Composio.PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant9, global::Composio.PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant10, global::Composio.PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant11>? CustomConnectionData { get; set; }

        /// <summary>
        /// Key-value pairs of arguments required by the tool (mutually exclusive with text)<br/>
        /// Example: {"repository":"octocat/Hello-World","workflow_id":"main.yml","ref":"main","inputs":{"environment":"production"}}
        /// </summary>
        /// <example>{"repository":"octocat/Hello-World","workflow_id":"main.yml","ref":"main","inputs":{"environment":"production"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public global::System.Collections.Generic.Dictionary<string, object?>? Arguments { get; set; }

        /// <summary>
        /// Natural language description of the task to perform (mutually exclusive with arguments)<br/>
        /// Example: Trigger the main workflow in the octocat/Hello-World repository on the main branch for the production environment
        /// </summary>
        /// <example>Trigger the main workflow in the octocat/Hello-World repository on the main branch for the production environment</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Deprecated. Enable debug tracing for tool execution (useful for debugging)<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_tracing")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? AllowTracing { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostV31ToolsExecuteByToolSlugRequest" /> class.
        /// </summary>
        /// <param name="connectedAccountId">
        /// Unique identifier for the connected account to use for authentication<br/>
        /// Example: ca_1a2b3c4d5e6f
        /// </param>
        /// <param name="userId">
        /// User id for multi-user connected accounts (e.g. multiple users, organizations)<br/>
        /// Example: user-123
        /// </param>
        /// <param name="version">
        /// Tool version to execute (defaults to "00000000_00" if not specified)<br/>
        /// Example: latest
        /// </param>
        /// <param name="customAuthParams">
        /// Custom authentication parameters for tools that support parameterized authentication<br/>
        /// Example: {"base_url":"https://api.example.com","parameters":[{"name":"x-api-key","value":"secret-key","in":"header"}]}
        /// </param>
        /// <param name="customConnectionData">
        /// Custom connection data for tools that support custom connection data<br/>
        /// Example: {"authScheme":"OAUTH2","toolkitSlug":"github","val":{"access_token":"secret-token"}}
        /// </param>
        /// <param name="arguments">
        /// Key-value pairs of arguments required by the tool (mutually exclusive with text)<br/>
        /// Example: {"repository":"octocat/Hello-World","workflow_id":"main.yml","ref":"main","inputs":{"environment":"production"}}
        /// </param>
        /// <param name="text">
        /// Natural language description of the task to perform (mutually exclusive with arguments)<br/>
        /// Example: Trigger the main workflow in the octocat/Hello-World repository on the main branch for the production environment
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostV31ToolsExecuteByToolSlugRequest(
            string? connectedAccountId,
            string? userId,
            string? version,
            global::Composio.PostV31ToolsExecuteByToolSlugRequestCustomAuthParams? customAuthParams,
            global::Composio.OneOf<global::Composio.PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant1, global::Composio.PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant2, global::Composio.PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant3, global::Composio.PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant4, global::Composio.PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant5, global::Composio.PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant6, global::Composio.PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant7, global::Composio.PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant8, global::Composio.PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant9, global::Composio.PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant10, global::Composio.PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant11>? customConnectionData,
            global::System.Collections.Generic.Dictionary<string, object?>? arguments,
            string? text)
        {
            this.ConnectedAccountId = connectedAccountId;
            this.UserId = userId;
            this.Version = version;
            this.CustomAuthParams = customAuthParams;
            this.CustomConnectionData = customConnectionData;
            this.Arguments = arguments;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostV31ToolsExecuteByToolSlugRequest" /> class.
        /// </summary>
        public PostV31ToolsExecuteByToolSlugRequest()
        {
        }
    }
}