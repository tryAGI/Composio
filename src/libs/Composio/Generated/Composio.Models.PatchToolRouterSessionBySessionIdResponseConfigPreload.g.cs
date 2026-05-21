
#nullable enable

namespace Composio
{
    /// <summary>
    /// Preload configuration. Controls which tools appear in `session.tools` and the MCP server tool list, callable directly without going through search. Each preloaded tool adds to the agent context — roughly ≤20 tools is recommended. Always present in the response (empty `tools: []` when the session was created without a preload config).
    /// </summary>
    public sealed partial class PatchToolRouterSessionBySessionIdResponseConfigPreload
    {
        /// <summary>
        /// Tool slugs preloaded for this session. Appear in `session.tools` and the MCP server tool list, callable directly without going through search. Empty array when no preload was configured.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchToolRouterSessionBySessionIdResponseConfigPreload" /> class.
        /// </summary>
        /// <param name="tools">
        /// Tool slugs preloaded for this session. Appear in `session.tools` and the MCP server tool list, callable directly without going through search. Empty array when no preload was configured.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchToolRouterSessionBySessionIdResponseConfigPreload(
            global::System.Collections.Generic.IList<string> tools)
        {
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchToolRouterSessionBySessionIdResponseConfigPreload" /> class.
        /// </summary>
        public PatchToolRouterSessionBySessionIdResponseConfigPreload()
        {
        }

    }
}