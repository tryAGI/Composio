
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolsExecuteProxyRequest
    {
        /// <summary>
        /// The ID of the connected account to use for authentication (if not provided, will use the default account for the project)<br/>
        /// Example: ca_1a2b3c4d5e6f
        /// </summary>
        /// <example>ca_1a2b3c4d5e6f</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("connected_account_id")]
        public string? ConnectedAccountId { get; set; }

        /// <summary>
        /// The API endpoint to call (absolute URL or path relative to base URL of the connected account)<br/>
        /// Example: /api/v1/resources
        /// </summary>
        /// <example>/api/v1/resources</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Endpoint { get; set; }

        /// <summary>
        /// The HTTP method to use for the request<br/>
        /// Example: GET
        /// </summary>
        /// <example>GET</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PostToolsExecuteProxyRequestMethodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.PostToolsExecuteProxyRequestMethod Method { get; set; }

        /// <summary>
        /// The request body (for POST, PUT, and PATCH requests)<br/>
        /// Example: {"name":"New Resource","description":"This is a new resource"}
        /// </summary>
        /// <example>{"name":"New Resource","description":"This is a new resource"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public object? Body { get; set; }

        /// <summary>
        /// Binary body to send. For binary upload via URL: use {url: "https://...", content_type?: "..."}. For binary upload via base64: use {base64: "...", content_type?: "..."}.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("binary_body")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.AnyOfJsonConverter<global::Composio.PostToolsExecuteProxyRequestBinaryBodyVariant1, global::Composio.PostToolsExecuteProxyRequestBinaryBodyVariant2>))]
        public global::Composio.AnyOf<global::Composio.PostToolsExecuteProxyRequestBinaryBodyVariant1, global::Composio.PostToolsExecuteProxyRequestBinaryBodyVariant2>? BinaryBody { get; set; }

        /// <summary>
        /// Additional HTTP headers or query parameters to include in the request<br/>
        /// Example: [{"name":"x-api-key","value":"abc123def456","type":"header"}, {"name":"filter","value":"active","type":"query"}]
        /// </summary>
        /// <example>[{"name":"x-api-key","value":"abc123def456","type":"header"}, {"name":"filter","value":"active","type":"query"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::System.Collections.Generic.IList<global::Composio.PostToolsExecuteProxyRequestParameter>? Parameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_connection_data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant1, global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant2, global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant3, global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant4, global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant5, global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant6, global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant7, global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant8, global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant9, global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant10, global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant11>))]
        public global::Composio.OneOf<global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant1, global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant2, global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant3, global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant4, global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant5, global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant6, global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant7, global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant8, global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant9, global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant10, global::Composio.PostToolsExecuteProxyRequestCustomConnectionDataVariant11>? CustomConnectionData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolsExecuteProxyRequest" /> class.
        /// </summary>
        /// <param name="connectedAccountId">
        /// The ID of the connected account to use for authentication (if not provided, will use the default account for the project)<br/>
        /// Example: ca_1a2b3c4d5e6f
        /// </param>
        /// <param name="endpoint">
        /// The API endpoint to call (absolute URL or path relative to base URL of the connected account)<br/>
        /// Example: /api/v1/resources
        /// </param>
        /// <param name="method">
        /// The HTTP method to use for the request<br/>
        /// Example: GET
        /// </param>
        /// <param name="body">
        /// The request body (for POST, PUT, and PATCH requests)<br/>
        /// Example: {"name":"New Resource","description":"This is a new resource"}
        /// </param>
        /// <param name="binaryBody">
        /// Binary body to send. For binary upload via URL: use {url: "https://...", content_type?: "..."}. For binary upload via base64: use {base64: "...", content_type?: "..."}.
        /// </param>
        /// <param name="parameters">
        /// Additional HTTP headers or query parameters to include in the request<br/>
        /// Example: [{"name":"x-api-key","value":"abc123def456","type":"header"}, {"name":"filter","value":"active","type":"query"}]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolsExecuteProxyRequest(
            string endpoint,
            global::Composio.PostToolsExecuteProxyRequestMethod method,
            string? connectedAccountId,
            object? body,
            global::Composio.AnyOf<global::Composio.PostToolsExecuteProxyRequestBinaryBodyVariant1, global::Composio.PostToolsExecuteProxyRequestBinaryBodyVariant2>? binaryBody,
            global::System.Collections.Generic.IList<global::Composio.PostToolsExecuteProxyRequestParameter>? parameters)
        {
            this.Endpoint = endpoint ?? throw new global::System.ArgumentNullException(nameof(endpoint));
            this.Method = method;
            this.ConnectedAccountId = connectedAccountId;
            this.Body = body;
            this.BinaryBody = binaryBody;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolsExecuteProxyRequest" /> class.
        /// </summary>
        public PostToolsExecuteProxyRequest()
        {
        }
    }
}