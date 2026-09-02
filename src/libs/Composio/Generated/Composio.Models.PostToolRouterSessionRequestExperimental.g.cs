
#nullable enable

namespace Composio
{
    /// <summary>
    /// Experimental features - not stable, may be modified or removed in future versions.
    /// </summary>
    public sealed partial class PostToolRouterSessionRequestExperimental
    {
        /// <summary>
        /// Customize assistive prompt generation (e.g., timezone).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistive_prompt_config")]
        public global::Composio.PostToolRouterSessionRequestExperimentalAssistivePromptConfig? AssistivePromptConfig { get; set; }

        /// <summary>
        /// Custom toolkits with grouped tools. Toolkit slugs must not conflict with existing Composio toolkits. All tools are no-auth.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_toolkits")]
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionRequestExperimentalCustomToolkit>? CustomToolkits { get; set; }

        /// <summary>
        /// Custom tools to include in search. Standalone tools need no auth. Tools with extends_toolkit inherit the Composio toolkit's connection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_tools")]
        public global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionRequestExperimentalCustomTool>? CustomTools { get; set; }

        /// <summary>
        /// Per-tool elicitation permission config. Default behavior + per-tool always_allow/always_deny overrides. Mutation via PATCH.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public global::Composio.PostToolRouterSessionRequestExperimentalPermissions? Permissions { get; set; }

        /// <summary>
        /// Experimental base URL override for connection link redirects created from this tool-router session. When set, link creation returns `${link_url_overwrite}/link/{link_token}` instead of the default Composio Connect base URL. Use only when your integration needs links to open through a custom Connect host.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("link_url_overwrite")]
        public string? LinkUrlOverwrite { get; set; }

        /// <summary>
        /// Experimental flag to skip the LLM reranker in tool search and serve embeddings/BM25-only results. Also skips plan search entirely, so responses will not include cached-plan fields (recommended_plan_steps, known_pitfalls, reference_workbench_snippets) or plan-derived execution guidance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fast_mode")]
        public bool? FastMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequestExperimental" /> class.
        /// </summary>
        /// <param name="assistivePromptConfig">
        /// Customize assistive prompt generation (e.g., timezone).
        /// </param>
        /// <param name="customToolkits">
        /// Custom toolkits with grouped tools. Toolkit slugs must not conflict with existing Composio toolkits. All tools are no-auth.
        /// </param>
        /// <param name="customTools">
        /// Custom tools to include in search. Standalone tools need no auth. Tools with extends_toolkit inherit the Composio toolkit's connection.
        /// </param>
        /// <param name="permissions">
        /// Per-tool elicitation permission config. Default behavior + per-tool always_allow/always_deny overrides. Mutation via PATCH.
        /// </param>
        /// <param name="linkUrlOverwrite">
        /// Experimental base URL override for connection link redirects created from this tool-router session. When set, link creation returns `${link_url_overwrite}/link/{link_token}` instead of the default Composio Connect base URL. Use only when your integration needs links to open through a custom Connect host.
        /// </param>
        /// <param name="fastMode">
        /// Experimental flag to skip the LLM reranker in tool search and serve embeddings/BM25-only results. Also skips plan search entirely, so responses will not include cached-plan fields (recommended_plan_steps, known_pitfalls, reference_workbench_snippets) or plan-derived execution guidance.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolRouterSessionRequestExperimental(
            global::Composio.PostToolRouterSessionRequestExperimentalAssistivePromptConfig? assistivePromptConfig,
            global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionRequestExperimentalCustomToolkit>? customToolkits,
            global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionRequestExperimentalCustomTool>? customTools,
            global::Composio.PostToolRouterSessionRequestExperimentalPermissions? permissions,
            string? linkUrlOverwrite,
            bool? fastMode)
        {
            this.AssistivePromptConfig = assistivePromptConfig;
            this.CustomToolkits = customToolkits;
            this.CustomTools = customTools;
            this.Permissions = permissions;
            this.LinkUrlOverwrite = linkUrlOverwrite;
            this.FastMode = fastMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequestExperimental" /> class.
        /// </summary>
        public PostToolRouterSessionRequestExperimental()
        {
        }

    }
}