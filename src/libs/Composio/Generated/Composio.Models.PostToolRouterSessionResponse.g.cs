
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolRouterSessionResponse
    {
        /// <summary>
        /// The identifier of the session<br/>
        /// Example: trs_1a2b3c4d5e6f
        /// </summary>
        /// <example>trs_1a2b3c4d5e6f</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.PostToolRouterSessionResponseMcp Mcp { get; set; }

        /// <summary>
        /// List of available tools in this session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_router_tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ToolRouterTools { get; set; }

        /// <summary>
        /// The session configuration including user, toolkits, and overrides
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.PostToolRouterSessionResponseConfig Config { get; set; }

        /// <summary>
        /// Experimental features including the generated system prompt. Only returned on session creation, not on GET.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experimental")]
        public global::Composio.PostToolRouterSessionResponseExperimental? Experimental { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionResponse" /> class.
        /// </summary>
        /// <param name="sessionId">
        /// The identifier of the session<br/>
        /// Example: trs_1a2b3c4d5e6f
        /// </param>
        /// <param name="mcp"></param>
        /// <param name="toolRouterTools">
        /// List of available tools in this session
        /// </param>
        /// <param name="config">
        /// The session configuration including user, toolkits, and overrides
        /// </param>
        /// <param name="experimental">
        /// Experimental features including the generated system prompt. Only returned on session creation, not on GET.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolRouterSessionResponse(
            string sessionId,
            global::Composio.PostToolRouterSessionResponseMcp mcp,
            global::System.Collections.Generic.IList<string> toolRouterTools,
            global::Composio.PostToolRouterSessionResponseConfig config,
            global::Composio.PostToolRouterSessionResponseExperimental? experimental)
        {
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.Mcp = mcp ?? throw new global::System.ArgumentNullException(nameof(mcp));
            this.ToolRouterTools = toolRouterTools ?? throw new global::System.ArgumentNullException(nameof(toolRouterTools));
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.Experimental = experimental;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionResponse" /> class.
        /// </summary>
        public PostToolRouterSessionResponse()
        {
        }
    }
}