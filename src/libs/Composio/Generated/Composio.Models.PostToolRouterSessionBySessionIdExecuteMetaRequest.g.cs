
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PostToolRouterSessionBySessionIdExecuteMetaRequest
    {
        /// <summary>
        /// The unique slug identifier of the meta tool to execute<br/>
        /// Example: COMPOSIO_MANAGE_CONNECTIONS
        /// </summary>
        /// <example>COMPOSIO_MANAGE_CONNECTIONS</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PostToolRouterSessionBySessionIdExecuteMetaRequestSlugJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.PostToolRouterSessionBySessionIdExecuteMetaRequestSlug Slug { get; set; }

        /// <summary>
        /// The arguments required by the meta tool<br/>
        /// Default Value: {}<br/>
        /// Example: {"toolkits":["github"],"reinitiate_all":false}
        /// </summary>
        /// <example>{"toolkits":["github"],"reinitiate_all":false}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public global::System.Collections.Generic.Dictionary<string, object?>? Arguments { get; set; }

        /// <summary>
        /// Experimental: the user's answers to the questions an earlier response asked, keyed by the same ids. Send them with the same tool call to continue it.<br/>
        /// Example: {"approval_3f9a1c2b7d4e5f60":{"action":"accept","content":{"decision":"approve"}}}
        /// </summary>
        /// <example>{"approval_3f9a1c2b7d4e5f60":{"action":"accept","content":{"decision":"approve"}}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_responses")]
        public global::System.Collections.Generic.Dictionary<string, object?>? InputResponses { get; set; }

        /// <summary>
        /// Experimental: state from an earlier response that asked the user for input, sent back unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_state")]
        public string? RequestState { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdExecuteMetaRequest" /> class.
        /// </summary>
        /// <param name="slug">
        /// The unique slug identifier of the meta tool to execute<br/>
        /// Example: COMPOSIO_MANAGE_CONNECTIONS
        /// </param>
        /// <param name="arguments">
        /// The arguments required by the meta tool<br/>
        /// Default Value: {}<br/>
        /// Example: {"toolkits":["github"],"reinitiate_all":false}
        /// </param>
        /// <param name="inputResponses">
        /// Experimental: the user's answers to the questions an earlier response asked, keyed by the same ids. Send them with the same tool call to continue it.<br/>
        /// Example: {"approval_3f9a1c2b7d4e5f60":{"action":"accept","content":{"decision":"approve"}}}
        /// </param>
        /// <param name="requestState">
        /// Experimental: state from an earlier response that asked the user for input, sent back unchanged.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolRouterSessionBySessionIdExecuteMetaRequest(
            global::Composio.PostToolRouterSessionBySessionIdExecuteMetaRequestSlug slug,
            global::System.Collections.Generic.Dictionary<string, object?>? arguments,
            global::System.Collections.Generic.Dictionary<string, object?>? inputResponses,
            string? requestState)
        {
            this.Slug = slug;
            this.Arguments = arguments;
            this.InputResponses = inputResponses;
            this.RequestState = requestState;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdExecuteMetaRequest" /> class.
        /// </summary>
        public PostToolRouterSessionBySessionIdExecuteMetaRequest()
        {
        }

    }
}