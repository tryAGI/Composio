
#nullable enable

namespace Composio
{
    /// <summary>
    /// Experimental features - not stable, may be modified or removed in future versions.
    /// </summary>
    public sealed partial class GetConnectedAccountsResponseItemExperimental
    {
        /// <summary>
        /// Sharing model for this connected account. PRIVATE is usable only by the owning user_id. SHARED is reachable from a tool-router session only when explicitly pinned in the session config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemExperimentalAccountTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.GetConnectedAccountsResponseItemExperimentalAccountType AccountType { get; set; }

        /// <summary>
        /// Access control for SHARED connections. Visible only to the connection creator and project/org API key callers; non-creator cookie callers receive the response without this block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acl_config_for_shared")]
        public global::Composio.GetConnectedAccountsResponseItemExperimentalAclConfigForShared? AclConfigForShared { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsResponseItemExperimental" /> class.
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
        public GetConnectedAccountsResponseItemExperimental(
            global::Composio.GetConnectedAccountsResponseItemExperimentalAccountType accountType,
            global::Composio.GetConnectedAccountsResponseItemExperimentalAclConfigForShared? aclConfigForShared)
        {
            this.AccountType = accountType;
            this.AclConfigForShared = aclConfigForShared;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsResponseItemExperimental" /> class.
        /// </summary>
        public GetConnectedAccountsResponseItemExperimental()
        {
        }

    }
}