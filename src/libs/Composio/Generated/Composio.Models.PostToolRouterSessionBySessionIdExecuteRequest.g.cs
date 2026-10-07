
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PostToolRouterSessionBySessionIdExecuteRequest
    {
        /// <summary>
        /// The unique slug identifier of the tool to execute. Supports both meta tools and app tools exposed by the session.<br/>
        /// Example: GITHUB_CREATE_AN_ISSUE
        /// </summary>
        /// <example>GITHUB_CREATE_AN_ISSUE</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolSlug { get; set; }

        /// <summary>
        /// The arguments required by the tool<br/>
        /// Default Value: {}<br/>
        /// Example: {"repository":"octocat/Hello-World","workflow_id":"main.yml","ref":"main","inputs":{"environment":"production"}}
        /// </summary>
        /// <example>{"repository":"octocat/Hello-World","workflow_id":"main.yml","ref":"main","inputs":{"environment":"production"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public global::System.Collections.Generic.Dictionary<string, object?>? Arguments { get; set; }

        /// <summary>
        /// Account identifier to specify which connected account to use for direct tool execution. Use the account ID (e.g. "coup_hurricane_dal_analytical") or an alias. When omitted with a single account, the default is used. When omitted with multiple accounts, an error lists available accounts. Meta/helper tools either ignore this top-level field or define their own account-selection fields, for example COMPOSIO_MULTI_EXECUTE_TOOL.tools[].account.<br/>
        /// Example: coup_hurricane_dal_analytical
        /// </summary>
        /// <example>coup_hurricane_dal_analytical</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("account")]
        public string? Account { get; set; }

        /// <summary>
        /// When true, direct non-meta tool execution may return a workbench offload preview if the response exceeds the configured threshold and the session workbench is enabled. When omitted or false, direct tool execution returns the normal inline response. Meta/helper tools are unaffected, and COMPOSIO_MULTI_EXECUTE_TOOL uses session.workbench configuration for its own batch-level offload behavior.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_auto_workbench_offload")]
        public bool? EnableAutoWorkbenchOffload { get; set; }

        /// <summary>
        /// The user's answers to an `input_required` response, keyed by the ids in its `input_requests`. Send them by repeating the same call (same tool and arguments) with this field added, along with the response's `request_state` if present. An approved call runs; a denied or declined one returns `failed`.<br/>
        /// Example: {"approval_3f9a1c2b7d4e5f60":{"action":"accept","content":{"decision":"approve"}}}
        /// </summary>
        /// <example>{"approval_3f9a1c2b7d4e5f60":{"action":"accept","content":{"decision":"approve"}}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_responses")]
        public global::System.Collections.Generic.Dictionary<string, global::Composio.UserInputResponse>? InputResponses { get; set; }

        /// <summary>
        /// The `request_state` from the `input_required` response, sent back unchanged with `input_responses`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_state")]
        public string? RequestState { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdExecuteRequest" /> class.
        /// </summary>
        /// <param name="toolSlug">
        /// The unique slug identifier of the tool to execute. Supports both meta tools and app tools exposed by the session.<br/>
        /// Example: GITHUB_CREATE_AN_ISSUE
        /// </param>
        /// <param name="arguments">
        /// The arguments required by the tool<br/>
        /// Default Value: {}<br/>
        /// Example: {"repository":"octocat/Hello-World","workflow_id":"main.yml","ref":"main","inputs":{"environment":"production"}}
        /// </param>
        /// <param name="account">
        /// Account identifier to specify which connected account to use for direct tool execution. Use the account ID (e.g. "coup_hurricane_dal_analytical") or an alias. When omitted with a single account, the default is used. When omitted with multiple accounts, an error lists available accounts. Meta/helper tools either ignore this top-level field or define their own account-selection fields, for example COMPOSIO_MULTI_EXECUTE_TOOL.tools[].account.<br/>
        /// Example: coup_hurricane_dal_analytical
        /// </param>
        /// <param name="enableAutoWorkbenchOffload">
        /// When true, direct non-meta tool execution may return a workbench offload preview if the response exceeds the configured threshold and the session workbench is enabled. When omitted or false, direct tool execution returns the normal inline response. Meta/helper tools are unaffected, and COMPOSIO_MULTI_EXECUTE_TOOL uses session.workbench configuration for its own batch-level offload behavior.<br/>
        /// Example: true
        /// </param>
        /// <param name="inputResponses">
        /// The user's answers to an `input_required` response, keyed by the ids in its `input_requests`. Send them by repeating the same call (same tool and arguments) with this field added, along with the response's `request_state` if present. An approved call runs; a denied or declined one returns `failed`.<br/>
        /// Example: {"approval_3f9a1c2b7d4e5f60":{"action":"accept","content":{"decision":"approve"}}}
        /// </param>
        /// <param name="requestState">
        /// The `request_state` from the `input_required` response, sent back unchanged with `input_responses`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolRouterSessionBySessionIdExecuteRequest(
            string toolSlug,
            global::System.Collections.Generic.Dictionary<string, object?>? arguments,
            string? account,
            bool? enableAutoWorkbenchOffload,
            global::System.Collections.Generic.Dictionary<string, global::Composio.UserInputResponse>? inputResponses,
            string? requestState)
        {
            this.ToolSlug = toolSlug ?? throw new global::System.ArgumentNullException(nameof(toolSlug));
            this.Arguments = arguments;
            this.Account = account;
            this.EnableAutoWorkbenchOffload = enableAutoWorkbenchOffload;
            this.InputResponses = inputResponses;
            this.RequestState = requestState;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdExecuteRequest" /> class.
        /// </summary>
        public PostToolRouterSessionBySessionIdExecuteRequest()
        {
        }

    }
}