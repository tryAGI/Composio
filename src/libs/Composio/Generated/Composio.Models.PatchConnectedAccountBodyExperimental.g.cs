
#nullable enable

namespace Composio
{
    /// <summary>
    /// Experimental features - not stable, may be modified or removed in future versions.
    /// </summary>
    public sealed partial class PatchConnectedAccountBodyExperimental
    {
        /// <summary>
        /// Mutate the sharing model. PRIVATE → SHARED promotes the existing connection without re-auth; SHARED → PRIVATE revokes all non-creator access and clears the stored ACL atomically. Omit to leave unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PatchConnectedAccountBodyExperimentalAccountTypeJsonConverter))]
        public global::Composio.PatchConnectedAccountBodyExperimentalAccountType? AccountType { get; set; }

        /// <summary>
        /// Access control for SHARED connections. Resolution rule (only fires when caller != creator): user in not_allowed_user_ids → DENY; allow_all_users=true → ALLOW; user in allowed_user_ids → ALLOW; else DENY. Default state (omitted or {}) is deny-by-default — only the creator can use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acl_config_for_shared")]
        public global::Composio.PatchConnectedAccountBodyExperimentalAclConfigForShared? AclConfigForShared { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchConnectedAccountBodyExperimental" /> class.
        /// </summary>
        /// <param name="accountType">
        /// Mutate the sharing model. PRIVATE → SHARED promotes the existing connection without re-auth; SHARED → PRIVATE revokes all non-creator access and clears the stored ACL atomically. Omit to leave unchanged.
        /// </param>
        /// <param name="aclConfigForShared">
        /// Access control for SHARED connections. Resolution rule (only fires when caller != creator): user in not_allowed_user_ids → DENY; allow_all_users=true → ALLOW; user in allowed_user_ids → ALLOW; else DENY. Default state (omitted or {}) is deny-by-default — only the creator can use.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchConnectedAccountBodyExperimental(
            global::Composio.PatchConnectedAccountBodyExperimentalAccountType? accountType,
            global::Composio.PatchConnectedAccountBodyExperimentalAclConfigForShared? aclConfigForShared)
        {
            this.AccountType = accountType;
            this.AclConfigForShared = aclConfigForShared;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchConnectedAccountBodyExperimental" /> class.
        /// </summary>
        public PatchConnectedAccountBodyExperimental()
        {
        }

    }
}