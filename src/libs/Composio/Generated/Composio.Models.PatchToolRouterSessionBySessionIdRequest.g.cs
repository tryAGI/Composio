
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchToolRouterSessionBySessionIdRequest
    {
        /// <summary>
        /// Toolkit configuration - specify either enable toolkits (allowlist) or disable toolkits (denylist). Mutually exclusive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolkits")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.AnyOfJsonConverter<global::Composio.PatchToolRouterSessionBySessionIdRequestToolkitsVariant1, global::Composio.PatchToolRouterSessionBySessionIdRequestToolkitsVariant2>))]
        public global::Composio.AnyOf<global::Composio.PatchToolRouterSessionBySessionIdRequestToolkitsVariant1, global::Composio.PatchToolRouterSessionBySessionIdRequestToolkitsVariant2>? Toolkits { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manage_connections")]
        public global::Composio.PatchToolRouterSessionBySessionIdRequestManageConnections? ManageConnections { get; set; }

        /// <summary>
        /// Tool-level configuration per toolkit. Allows you to enable, disable, or filter by tags for specific tools within each toolkit. Every slug passed in `enable` / `disable` must be a valid Composio tool slug for that toolkit — invalid or typo'd slugs fail session creation with a clear error listing which ones didn't match.<br/>
        /// Example: {"gmail":{"enable":["GMAIL_SEND_EMAIL","GMAIL_FETCH_EMAILS"]},"slack":{"disable":["SLACK_ADD_EMOJI"]},"slackbot":{"tags":{"enable":["destructiveHint"],"disable":["openWorldHint"]}}}
        /// </summary>
        /// <example>{"gmail":{"enable":["GMAIL_SEND_EMAIL","GMAIL_FETCH_EMAILS"]},"slack":{"disable":["SLACK_ADD_EMOJI"]},"slackbot":{"tags":{"enable":["destructiveHint"],"disable":["openWorldHint"]}}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public object? Tools { get; set; }

        /// <summary>
        /// Global MCP tool annotation hints for filtering. Array format is treated as enabled list. Object format supports both enabled (tool must have at least one) and disabled (tool must NOT have any) lists. Toolkit-level tags override this. Toolkit enabled/disabled lists take precedence over tag filtering.<br/>
        /// Example: {"enable":["openWorldHint"],"disable":["destructiveHint"]}
        /// </summary>
        /// <example>{"enable":["openWorldHint"],"disable":["destructiveHint"]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdRequestTag>, global::Composio.PatchToolRouterSessionBySessionIdRequestTags>))]
        public global::Composio.AnyOf<global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdRequestTag>, global::Composio.PatchToolRouterSessionBySessionIdRequestTags>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workbench")]
        public global::Composio.PatchToolRouterSessionBySessionIdRequestWorkbench? Workbench { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multi_account")]
        public global::Composio.PatchToolRouterSessionBySessionIdRequestMultiAccount? MultiAccount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchToolRouterSessionBySessionIdRequest" /> class.
        /// </summary>
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
        /// <param name="manageConnections"></param>
        /// <param name="tools">
        /// Tool-level configuration per toolkit. Allows you to enable, disable, or filter by tags for specific tools within each toolkit. Every slug passed in `enable` / `disable` must be a valid Composio tool slug for that toolkit — invalid or typo'd slugs fail session creation with a clear error listing which ones didn't match.<br/>
        /// Example: {"gmail":{"enable":["GMAIL_SEND_EMAIL","GMAIL_FETCH_EMAILS"]},"slack":{"disable":["SLACK_ADD_EMOJI"]},"slackbot":{"tags":{"enable":["destructiveHint"],"disable":["openWorldHint"]}}}
        /// </param>
        /// <param name="tags">
        /// Global MCP tool annotation hints for filtering. Array format is treated as enabled list. Object format supports both enabled (tool must have at least one) and disabled (tool must NOT have any) lists. Toolkit-level tags override this. Toolkit enabled/disabled lists take precedence over tag filtering.<br/>
        /// Example: {"enable":["openWorldHint"],"disable":["destructiveHint"]}
        /// </param>
        /// <param name="workbench"></param>
        /// <param name="multiAccount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchToolRouterSessionBySessionIdRequest(
            global::Composio.AnyOf<global::Composio.PatchToolRouterSessionBySessionIdRequestToolkitsVariant1, global::Composio.PatchToolRouterSessionBySessionIdRequestToolkitsVariant2>? toolkits,
            global::System.Collections.Generic.Dictionary<string, string>? authConfigs,
            global::System.Collections.Generic.Dictionary<string, string>? connectedAccounts,
            global::Composio.PatchToolRouterSessionBySessionIdRequestManageConnections? manageConnections,
            object? tools,
            global::Composio.AnyOf<global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdRequestTag>, global::Composio.PatchToolRouterSessionBySessionIdRequestTags>? tags,
            global::Composio.PatchToolRouterSessionBySessionIdRequestWorkbench? workbench,
            global::Composio.PatchToolRouterSessionBySessionIdRequestMultiAccount? multiAccount)
        {
            this.Toolkits = toolkits;
            this.AuthConfigs = authConfigs;
            this.ConnectedAccounts = connectedAccounts;
            this.ManageConnections = manageConnections;
            this.Tools = tools;
            this.Tags = tags;
            this.Workbench = workbench;
            this.MultiAccount = multiAccount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchToolRouterSessionBySessionIdRequest" /> class.
        /// </summary>
        public PatchToolRouterSessionBySessionIdRequest()
        {
        }
    }
}