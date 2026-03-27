
#nullable enable

namespace Composio
{
    /// <summary>
    /// Reference to fetch full schema when hasFullSchema is false
    /// </summary>
    public sealed partial class PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRef
    {
        /// <summary>
        /// Tool to call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRefToolJsonConverter))]
        public global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRefTool Tool { get; set; }

        /// <summary>
        /// Arguments to pass to the tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("args")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRefArgs Args { get; set; }

        /// <summary>
        /// Instruction message for the LLM
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRef" /> class.
        /// </summary>
        /// <param name="tool">
        /// Tool to call
        /// </param>
        /// <param name="args">
        /// Arguments to pass to the tool
        /// </param>
        /// <param name="message">
        /// Instruction message for the LLM
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRef(
            global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRefArgs args,
            string message,
            global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRefTool tool)
        {
            this.Args = args ?? throw new global::System.ArgumentNullException(nameof(args));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Tool = tool;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRef" /> class.
        /// </summary>
        public PostToolRouterSessionBySessionIdSearchResponseToolSchemasSchemaRef()
        {
        }
    }
}