
#nullable enable

namespace Composio
{
    /// <summary>
    /// Preload configuration. Controls which tools appear in `session.tools` and the MCP server tool list so the agent can call them directly without going through search first — useful for frequently used tools. Each slug must be allowed by the session filters (`toolkits`, `tools`, `tags`), otherwise session creation fails with a 400. Custom tools declared in `custom_tools` / `custom_toolkits` can also be preloaded. Not supported when multi-account is enabled. Each preloaded tool adds to the agent context window, so keep the list at or under ~20 tools.
    /// </summary>
    public sealed partial class PostToolRouterSessionRequestPreload
    {
        /// <summary>
        /// Tool slugs to preload. Each slug must be allowed by the session filters (`toolkits`, `tools`, `tags`) and exist either in the Composio tool catalog or in `custom_tools` / `custom_toolkits` — unknown or blocked slugs return a 400 at session creation.<br/>
        /// Example: [GMAIL_FETCH_EMAILS, SLACK_SEND_MESSAGE]
        /// </summary>
        /// <example>[GMAIL_FETCH_EMAILS, SLACK_SEND_MESSAGE]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<string>? Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequestPreload" /> class.
        /// </summary>
        /// <param name="tools">
        /// Tool slugs to preload. Each slug must be allowed by the session filters (`toolkits`, `tools`, `tags`) and exist either in the Composio tool catalog or in `custom_tools` / `custom_toolkits` — unknown or blocked slugs return a 400 at session creation.<br/>
        /// Example: [GMAIL_FETCH_EMAILS, SLACK_SEND_MESSAGE]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolRouterSessionRequestPreload(
            global::System.Collections.Generic.IList<string>? tools)
        {
            this.Tools = tools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequestPreload" /> class.
        /// </summary>
        public PostToolRouterSessionRequestPreload()
        {
        }
    }
}