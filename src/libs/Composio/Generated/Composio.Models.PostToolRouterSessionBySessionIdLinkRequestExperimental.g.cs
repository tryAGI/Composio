
#nullable enable

namespace Composio
{
    /// <summary>
    /// Experimental features - not stable, may be modified or removed in future versions.
    /// </summary>
    public sealed partial class PostToolRouterSessionBySessionIdLinkRequestExperimental
    {
        /// <summary>
        /// Sharing model for this connected account. PRIVATE (default) is usable only by the owning user_id. SHARED is reachable from a tool-router session ONLY when explicitly pinned in the session config — at most one SHARED connection per toolkit per session. Sessions never use a SHARED connection implicitly.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PostToolRouterSessionBySessionIdLinkRequestExperimentalAccountTypeJsonConverter))]
        public global::Composio.PostToolRouterSessionBySessionIdLinkRequestExperimentalAccountType? AccountType { get; set; }

        /// <summary>
        /// Access control for SHARED connections. Resolution rule (only fires when caller != creator): user in not_allowed_user_ids → DENY; allow_all_users=true → ALLOW; user in allowed_user_ids → ALLOW; else DENY. Default state (omitted or {}) is deny-by-default — only the creator can use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acl_config_for_shared")]
        public global::Composio.PostToolRouterSessionBySessionIdLinkRequestExperimentalAclConfigForShared? AclConfigForShared { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdLinkRequestExperimental" /> class.
        /// </summary>
        /// <param name="accountType">
        /// Sharing model for this connected account. PRIVATE (default) is usable only by the owning user_id. SHARED is reachable from a tool-router session ONLY when explicitly pinned in the session config — at most one SHARED connection per toolkit per session. Sessions never use a SHARED connection implicitly.
        /// </param>
        /// <param name="aclConfigForShared">
        /// Access control for SHARED connections. Resolution rule (only fires when caller != creator): user in not_allowed_user_ids → DENY; allow_all_users=true → ALLOW; user in allowed_user_ids → ALLOW; else DENY. Default state (omitted or {}) is deny-by-default — only the creator can use.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolRouterSessionBySessionIdLinkRequestExperimental(
            global::Composio.PostToolRouterSessionBySessionIdLinkRequestExperimentalAccountType? accountType,
            global::Composio.PostToolRouterSessionBySessionIdLinkRequestExperimentalAclConfigForShared? aclConfigForShared)
        {
            this.AccountType = accountType;
            this.AclConfigForShared = aclConfigForShared;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdLinkRequestExperimental" /> class.
        /// </summary>
        public PostToolRouterSessionBySessionIdLinkRequestExperimental()
        {
        }

    }
}