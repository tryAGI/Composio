
#nullable enable

namespace Composio
{
    /// <summary>
    /// Experimental features - not stable, may be modified or removed in future versions.
    /// </summary>
    public sealed partial class PostConnectedAccountsLinkResponseExperimental
    {
        /// <summary>
        /// Sharing model for this connected account. PRIVATE is usable only by the owning user_id. SHARED is reachable from a tool-router session only when explicitly pinned in the session config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PostConnectedAccountsLinkResponseExperimentalAccountTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.PostConnectedAccountsLinkResponseExperimentalAccountType AccountType { get; set; }

        /// <summary>
        /// Access control for SHARED connections. Visible only to the connection creator and project/org API key callers; non-creator cookie callers receive the response without this block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acl_config_for_shared")]
        public global::Composio.PostConnectedAccountsLinkResponseExperimentalAclConfigForShared? AclConfigForShared { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsLinkResponseExperimental" /> class.
        /// </summary>
        /// <param name="accountType">
        /// Sharing model for this connected account. PRIVATE is usable only by the owning user_id. SHARED is reachable from a tool-router session only when explicitly pinned in the session config.
        /// </param>
        /// <param name="aclConfigForShared">
        /// Access control for SHARED connections. Visible only to the connection creator and project/org API key callers; non-creator cookie callers receive the response without this block.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostConnectedAccountsLinkResponseExperimental(
            global::Composio.PostConnectedAccountsLinkResponseExperimentalAccountType accountType,
            global::Composio.PostConnectedAccountsLinkResponseExperimentalAclConfigForShared? aclConfigForShared)
        {
            this.AccountType = accountType;
            this.AclConfigForShared = aclConfigForShared;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsLinkResponseExperimental" /> class.
        /// </summary>
        public PostConnectedAccountsLinkResponseExperimental()
        {
        }

    }
}