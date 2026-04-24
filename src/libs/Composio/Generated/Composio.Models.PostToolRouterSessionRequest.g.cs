
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolRouterSessionRequest
    {
        /// <summary>
        /// The identifier of the user who is initiating the session, ideally a unique identifier from your database like a user ID or email address<br/>
        /// Example: user_123456789
        /// </summary>
        /// <example>user_123456789</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Toolkit configuration - specify either enable toolkits (allowlist) or disable toolkits (denylist). Mutually exclusive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolkits")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.AnyOfJsonConverter<global::Composio.PostToolRouterSessionRequestToolkitsVariant1, global::Composio.PostToolRouterSessionRequestToolkitsVariant2>))]
        public global::Composio.AnyOf<global::Composio.PostToolRouterSessionRequestToolkitsVariant1, global::Composio.PostToolRouterSessionRequestToolkitsVariant2>? Toolkits { get; set; }

        /// <summary>
        /// The auth configs to use for the session. This will override the default behavior and use the given auth config when specific toolkits are being executed<br/>
        /// Example: {"gmail":"ac_1a2b3c4d5e6f","slack":"ac_7g8h9i0j1k2l"}
        /// </summary>
        /// <example>{"gmail":"ac_1a2b3c4d5e6f","slack":"ac_7g8h9i0j1k2l"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_configs")]
        public global::System.Collections.Generic.Dictionary<string, string>? AuthConfigs { get; set; }

        /// <summary>
        /// The connected accounts to use for the session. This will override the default behaviour and use the given connected account when specific toolkits are being executed. Each connected account must exist (not deleted or disabled) and belong to the same `user_id` as the session — otherwise session creation fails with a clear error explaining which account didn't match.<br/>
        /// Example: {"github":"ca_3m4n5o6p7q8r"}
        /// </summary>
        /// <example>{"github":"ca_3m4n5o6p7q8r"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("connected_accounts")]
        public global::System.Collections.Generic.Dictionary<string, string>? ConnectedAccounts { get; set; }

        /// <summary>
        /// Configuration for connection management settings<br/>
        /// Default Value: {"enable":true,"enable_wait_for_connections":false,"enable_connection_removal":true}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manage_connections")]
        public global::Composio.PostToolRouterSessionRequestManageConnections? ManageConnections { get; set; }

        /// <summary>
        /// Tool-level configuration per toolkit. Allows you to enable, disable, or filter by tags for specific tools within each toolkit. Every slug passed in `enable` / `disable` must be a valid Composio tool slug for that toolkit — invalid or typo'd slugs fail session creation with a clear error listing which ones didn't match.<br/>
        /// Example: {"gmail":{"enable":["GMAIL_SEND_EMAIL","GMAIL_FETCH_EMAILS"]},"slack":{"disable":["SLACK_ADD_EMOJI"]},"slack_bot":{"tags":{"enable":["destructiveHint"],"disable":["openWorldHint"]}}}
        /// </summary>
        /// <example>{"gmail":{"enable":["GMAIL_SEND_EMAIL","GMAIL_FETCH_EMAILS"]},"slack":{"disable":["SLACK_ADD_EMOJI"]},"slack_bot":{"tags":{"enable":["destructiveHint"],"disable":["openWorldHint"]}}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public object? Tools { get; set; }

        /// <summary>
        /// Global MCP tool annotation hints for filtering. Array format is treated as enabled list. Object format supports both enabled (tool must have at least one) and disabled (tool must NOT have any) lists. Toolkit-level tags override this. Toolkit enabled/disabled lists take precedence over tag filtering.<br/>
        /// Example: {"enable":["openWorldHint"],"disable":["destructiveHint"]}
        /// </summary>
        /// <example>{"enable":["openWorldHint"],"disable":["destructiveHint"]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionRequestTag>, global::Composio.PostToolRouterSessionRequestTags>))]
        public global::Composio.AnyOf<global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionRequestTag>, global::Composio.PostToolRouterSessionRequestTags>? Tags { get; set; }

        /// <summary>
        /// Configuration for workbench behavior<br/>
        /// Default Value: {"enable":true,"enable_proxy_execution":true}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workbench")]
        public global::Composio.PostToolRouterSessionRequestWorkbench? Workbench { get; set; }

        /// <summary>
        /// Configure multi-account behavior. When enabled, users can connect multiple accounts per toolkit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multi_account")]
        public global::Composio.PostToolRouterSessionRequestMultiAccount? MultiAccount { get; set; }

        /// <summary>
        /// Experimental features - not stable, may be modified or removed in future versions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experimental")]
        public global::Composio.PostToolRouterSessionRequestExperimental? Experimental { get; set; }

        /// <summary>
        /// Preload configuration. Controls which tools appear in `session.tools` and the MCP server tool list so the agent can call them directly without going through search first — useful for frequently used tools. Each slug must be allowed by the session filters (`toolkits`, `tools`, `tags`), otherwise session creation fails with a 400. Custom tools declared in `custom_tools` / `custom_toolkits` can also be preloaded. Not supported when multi-account is enabled. Each preloaded tool adds to the agent context window, so keep the list at or under ~20 tools.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preload")]
        public global::Composio.PostToolRouterSessionRequestPreload? Preload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequest" /> class.
        /// </summary>
        /// <param name="userId">
        /// The identifier of the user who is initiating the session, ideally a unique identifier from your database like a user ID or email address<br/>
        /// Example: user_123456789
        /// </param>
        /// <param name="toolkits">
        /// Toolkit configuration - specify either enable toolkits (allowlist) or disable toolkits (denylist). Mutually exclusive.
        /// </param>
        /// <param name="authConfigs">
        /// The auth configs to use for the session. This will override the default behavior and use the given auth config when specific toolkits are being executed<br/>
        /// Example: {"gmail":"ac_1a2b3c4d5e6f","slack":"ac_7g8h9i0j1k2l"}
        /// </param>
        /// <param name="connectedAccounts">
        /// The connected accounts to use for the session. This will override the default behaviour and use the given connected account when specific toolkits are being executed. Each connected account must exist (not deleted or disabled) and belong to the same `user_id` as the session — otherwise session creation fails with a clear error explaining which account didn't match.<br/>
        /// Example: {"github":"ca_3m4n5o6p7q8r"}
        /// </param>
        /// <param name="manageConnections">
        /// Configuration for connection management settings<br/>
        /// Default Value: {"enable":true,"enable_wait_for_connections":false,"enable_connection_removal":true}
        /// </param>
        /// <param name="tools">
        /// Tool-level configuration per toolkit. Allows you to enable, disable, or filter by tags for specific tools within each toolkit. Every slug passed in `enable` / `disable` must be a valid Composio tool slug for that toolkit — invalid or typo'd slugs fail session creation with a clear error listing which ones didn't match.<br/>
        /// Example: {"gmail":{"enable":["GMAIL_SEND_EMAIL","GMAIL_FETCH_EMAILS"]},"slack":{"disable":["SLACK_ADD_EMOJI"]},"slack_bot":{"tags":{"enable":["destructiveHint"],"disable":["openWorldHint"]}}}
        /// </param>
        /// <param name="tags">
        /// Global MCP tool annotation hints for filtering. Array format is treated as enabled list. Object format supports both enabled (tool must have at least one) and disabled (tool must NOT have any) lists. Toolkit-level tags override this. Toolkit enabled/disabled lists take precedence over tag filtering.<br/>
        /// Example: {"enable":["openWorldHint"],"disable":["destructiveHint"]}
        /// </param>
        /// <param name="workbench">
        /// Configuration for workbench behavior<br/>
        /// Default Value: {"enable":true,"enable_proxy_execution":true}
        /// </param>
        /// <param name="multiAccount">
        /// Configure multi-account behavior. When enabled, users can connect multiple accounts per toolkit.
        /// </param>
        /// <param name="experimental">
        /// Experimental features - not stable, may be modified or removed in future versions.
        /// </param>
        /// <param name="preload">
        /// Preload configuration. Controls which tools appear in `session.tools` and the MCP server tool list so the agent can call them directly without going through search first — useful for frequently used tools. Each slug must be allowed by the session filters (`toolkits`, `tools`, `tags`), otherwise session creation fails with a 400. Custom tools declared in `custom_tools` / `custom_toolkits` can also be preloaded. Not supported when multi-account is enabled. Each preloaded tool adds to the agent context window, so keep the list at or under ~20 tools.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolRouterSessionRequest(
            string userId,
            global::Composio.AnyOf<global::Composio.PostToolRouterSessionRequestToolkitsVariant1, global::Composio.PostToolRouterSessionRequestToolkitsVariant2>? toolkits,
            global::System.Collections.Generic.Dictionary<string, string>? authConfigs,
            global::System.Collections.Generic.Dictionary<string, string>? connectedAccounts,
            global::Composio.PostToolRouterSessionRequestManageConnections? manageConnections,
            object? tools,
            global::Composio.AnyOf<global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionRequestTag>, global::Composio.PostToolRouterSessionRequestTags>? tags,
            global::Composio.PostToolRouterSessionRequestWorkbench? workbench,
            global::Composio.PostToolRouterSessionRequestMultiAccount? multiAccount,
            global::Composio.PostToolRouterSessionRequestExperimental? experimental,
            global::Composio.PostToolRouterSessionRequestPreload? preload)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Toolkits = toolkits;
            this.AuthConfigs = authConfigs;
            this.ConnectedAccounts = connectedAccounts;
            this.ManageConnections = manageConnections;
            this.Tools = tools;
            this.Tags = tags;
            this.Workbench = workbench;
            this.MultiAccount = multiAccount;
            this.Experimental = experimental;
            this.Preload = preload;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequest" /> class.
        /// </summary>
        public PostToolRouterSessionRequest()
        {
        }
    }
}