
#nullable enable

namespace Composio
{
    /// <summary>
    /// Response containing the generated MCP URLs
    /// </summary>
    public sealed partial class PostMcpServersGenerateResponse
    {
        /// <summary>
        /// Base MCP URL without any query parameters<br/>
        /// Example: https://backend.composio.dev/v3/mcp/550e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>https://backend.composio.dev/v3/mcp/550e8400-e29b-41d4-a716-446655440000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string McpUrl { get; set; }

        /// <summary>
        /// List of URLs generated for each connected account ID. URLs may carry the include_composio_helper_actions query parameter. DEPRECATED: The include_composio_helper_actions query parameter will be removed in a future version. Switch to Composio Sessions (POST /api/v3/tool_router/session), whose MCP URL includes connection-management tools.<br/>
        /// Example: [https://backend.composio.dev/v3/mcp/550e8400-e29b-41d4-a716-446655440000?include_composio_helper_actions=true&amp;connected_account_id=ca_1a2b3c4d5e6f, https://backend.composio.dev/v3/mcp/550e8400-e29b-41d4-a716-446655440000?include_composio_helper_actions=true&amp;connected_account_id=ca_7g8h9i0j1k2l]
        /// </summary>
        /// <example>[https://backend.composio.dev/v3/mcp/550e8400-e29b-41d4-a716-446655440000?include_composio_helper_actions=true&amp;connected_account_id=ca_1a2b3c4d5e6f, https://backend.composio.dev/v3/mcp/550e8400-e29b-41d4-a716-446655440000?include_composio_helper_actions=true&amp;connected_account_id=ca_7g8h9i0j1k2l]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("connected_account_urls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ConnectedAccountUrls { get; set; }

        /// <summary>
        /// List of URLs generated for each user ID. URLs may carry the include_composio_helper_actions query parameter. DEPRECATED: The include_composio_helper_actions query parameter will be removed in a future version. Switch to Composio Sessions (POST /api/v3/tool_router/session), whose MCP URL includes connection-management tools.<br/>
        /// Example: [https://backend.composio.dev/v3/mcp/550e8400-e29b-41d4-a716-446655440000?include_composio_helper_actions=true&amp;user_id=user_123456, https://backend.composio.dev/v3/mcp/550e8400-e29b-41d4-a716-446655440000?include_composio_helper_actions=true&amp;user_id=user_789012]
        /// </summary>
        /// <example>[https://backend.composio.dev/v3/mcp/550e8400-e29b-41d4-a716-446655440000?include_composio_helper_actions=true&amp;user_id=user_123456, https://backend.composio.dev/v3/mcp/550e8400-e29b-41d4-a716-446655440000?include_composio_helper_actions=true&amp;user_id=user_789012]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_ids_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> UserIdsUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostMcpServersGenerateResponse" /> class.
        /// </summary>
        /// <param name="mcpUrl">
        /// Base MCP URL without any query parameters<br/>
        /// Example: https://backend.composio.dev/v3/mcp/550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="connectedAccountUrls">
        /// List of URLs generated for each connected account ID. URLs may carry the include_composio_helper_actions query parameter. DEPRECATED: The include_composio_helper_actions query parameter will be removed in a future version. Switch to Composio Sessions (POST /api/v3/tool_router/session), whose MCP URL includes connection-management tools.<br/>
        /// Example: [https://backend.composio.dev/v3/mcp/550e8400-e29b-41d4-a716-446655440000?include_composio_helper_actions=true&amp;connected_account_id=ca_1a2b3c4d5e6f, https://backend.composio.dev/v3/mcp/550e8400-e29b-41d4-a716-446655440000?include_composio_helper_actions=true&amp;connected_account_id=ca_7g8h9i0j1k2l]
        /// </param>
        /// <param name="userIdsUrl">
        /// List of URLs generated for each user ID. URLs may carry the include_composio_helper_actions query parameter. DEPRECATED: The include_composio_helper_actions query parameter will be removed in a future version. Switch to Composio Sessions (POST /api/v3/tool_router/session), whose MCP URL includes connection-management tools.<br/>
        /// Example: [https://backend.composio.dev/v3/mcp/550e8400-e29b-41d4-a716-446655440000?include_composio_helper_actions=true&amp;user_id=user_123456, https://backend.composio.dev/v3/mcp/550e8400-e29b-41d4-a716-446655440000?include_composio_helper_actions=true&amp;user_id=user_789012]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostMcpServersGenerateResponse(
            string mcpUrl,
            global::System.Collections.Generic.IList<string> connectedAccountUrls,
            global::System.Collections.Generic.IList<string> userIdsUrl)
        {
            this.McpUrl = mcpUrl ?? throw new global::System.ArgumentNullException(nameof(mcpUrl));
            this.ConnectedAccountUrls = connectedAccountUrls ?? throw new global::System.ArgumentNullException(nameof(connectedAccountUrls));
            this.UserIdsUrl = userIdsUrl ?? throw new global::System.ArgumentNullException(nameof(userIdsUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostMcpServersGenerateResponse" /> class.
        /// </summary>
        public PostMcpServersGenerateResponse()
        {
        }

    }
}