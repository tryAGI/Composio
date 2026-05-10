
#nullable enable

namespace Composio
{
    /// <summary>
    /// The session configuration including user, toolkits, and overrides
    /// </summary>
    public sealed partial class PatchToolRouterSessionBySessionIdResponseConfig
    {
        /// <summary>
        /// User identifier for this session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Toolkit configuration - either enabled list or disabled list
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolkits")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.AnyOfJsonConverter<global::Composio.PatchToolRouterSessionBySessionIdResponseConfigToolkitsVariant1, global::Composio.PatchToolRouterSessionBySessionIdResponseConfigToolkitsVariant2>))]
        public global::Composio.AnyOf<global::Composio.PatchToolRouterSessionBySessionIdResponseConfigToolkitsVariant1, global::Composio.PatchToolRouterSessionBySessionIdResponseConfigToolkitsVariant2>? Toolkits { get; set; }

        /// <summary>
        /// Auth config overrides per toolkit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_configs")]
        public global::System.Collections.Generic.Dictionary<string, string>? AuthConfigs { get; set; }

        /// <summary>
        /// Per-toolkit connected account override (single nano-ID). Returns the first override when multi-account is enabled; see `all_connected_accounts` for the full list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connected_accounts")]
        public global::System.Collections.Generic.Dictionary<string, string>? ConnectedAccounts { get; set; }

        /// <summary>
        /// Full per-toolkit connected account overrides as arrays. Populated whenever `connected_accounts` is non-empty; carries the complete list when multi-account is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("all_connected_accounts")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? AllConnectedAccounts { get; set; }

        /// <summary>
        /// Manage connections configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manage_connections")]
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigManageConnections? ManageConnections { get; set; }

        /// <summary>
        /// Tool-level configuration per toolkit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public object? Tools { get; set; }

        /// <summary>
        /// MCP tool annotation hints for filtering tools with enabled/disabled support. enabled: tags that the tool must have at least one of. disabled: tags that the tool must NOT have any of. Both conditions must be satisfied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigTags? Tags { get; set; }

        /// <summary>
        /// Workbench configuration<br/>
        /// Default Value: {"enable":true,"proxy_execution_enabled":true}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workbench")]
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigWorkbench? Workbench { get; set; }

        /// <summary>
        /// Multi-account configuration for this session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multi_account")]
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigMultiAccount? MultiAccount { get; set; }

        /// <summary>
        /// Preload configuration. Controls which tools appear in `session.tools` and the MCP server tool list, callable directly without going through search. Each preloaded tool adds to the agent context — roughly ≤20 tools is recommended. Always present in the response (empty `tools: []` when the session was created without a preload config).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preload")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.PatchToolRouterSessionBySessionIdResponseConfigPreload Preload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchToolRouterSessionBySessionIdResponseConfig" /> class.
        /// </summary>
        /// <param name="userId">
        /// User identifier for this session
        /// </param>
        /// <param name="preload">
        /// Preload configuration. Controls which tools appear in `session.tools` and the MCP server tool list, callable directly without going through search. Each preloaded tool adds to the agent context — roughly ≤20 tools is recommended. Always present in the response (empty `tools: []` when the session was created without a preload config).
        /// </param>
        /// <param name="toolkits">
        /// Toolkit configuration - either enabled list or disabled list
        /// </param>
        /// <param name="authConfigs">
        /// Auth config overrides per toolkit
        /// </param>
        /// <param name="connectedAccounts">
        /// Per-toolkit connected account override (single nano-ID). Returns the first override when multi-account is enabled; see `all_connected_accounts` for the full list.
        /// </param>
        /// <param name="allConnectedAccounts">
        /// Full per-toolkit connected account overrides as arrays. Populated whenever `connected_accounts` is non-empty; carries the complete list when multi-account is enabled.
        /// </param>
        /// <param name="manageConnections">
        /// Manage connections configuration
        /// </param>
        /// <param name="tools">
        /// Tool-level configuration per toolkit
        /// </param>
        /// <param name="tags">
        /// MCP tool annotation hints for filtering tools with enabled/disabled support. enabled: tags that the tool must have at least one of. disabled: tags that the tool must NOT have any of. Both conditions must be satisfied.
        /// </param>
        /// <param name="workbench">
        /// Workbench configuration<br/>
        /// Default Value: {"enable":true,"proxy_execution_enabled":true}
        /// </param>
        /// <param name="multiAccount">
        /// Multi-account configuration for this session.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchToolRouterSessionBySessionIdResponseConfig(
            string userId,
            global::Composio.PatchToolRouterSessionBySessionIdResponseConfigPreload preload,
            global::Composio.AnyOf<global::Composio.PatchToolRouterSessionBySessionIdResponseConfigToolkitsVariant1, global::Composio.PatchToolRouterSessionBySessionIdResponseConfigToolkitsVariant2>? toolkits,
            global::System.Collections.Generic.Dictionary<string, string>? authConfigs,
            global::System.Collections.Generic.Dictionary<string, string>? connectedAccounts,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? allConnectedAccounts,
            global::Composio.PatchToolRouterSessionBySessionIdResponseConfigManageConnections? manageConnections,
            object? tools,
            global::Composio.PatchToolRouterSessionBySessionIdResponseConfigTags? tags,
            global::Composio.PatchToolRouterSessionBySessionIdResponseConfigWorkbench? workbench,
            global::Composio.PatchToolRouterSessionBySessionIdResponseConfigMultiAccount? multiAccount)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Toolkits = toolkits;
            this.AuthConfigs = authConfigs;
            this.ConnectedAccounts = connectedAccounts;
            this.AllConnectedAccounts = allConnectedAccounts;
            this.ManageConnections = manageConnections;
            this.Tools = tools;
            this.Tags = tags;
            this.Workbench = workbench;
            this.MultiAccount = multiAccount;
            this.Preload = preload ?? throw new global::System.ArgumentNullException(nameof(preload));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchToolRouterSessionBySessionIdResponseConfig" /> class.
        /// </summary>
        public PatchToolRouterSessionBySessionIdResponseConfig()
        {
        }

    }
}