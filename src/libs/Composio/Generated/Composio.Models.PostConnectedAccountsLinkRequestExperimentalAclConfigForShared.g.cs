
#nullable enable

namespace Composio
{
    /// <summary>
    /// Access control for SHARED connections. Resolution rule (only fires when caller != creator): user in not_allowed_user_ids → DENY; allow_all_users=true → ALLOW; user in allowed_user_ids → ALLOW; else DENY. Default state (omitted or {}) is deny-by-default — only the creator can use.
    /// </summary>
    public sealed partial class PostConnectedAccountsLinkRequestExperimentalAclConfigForShared
    {
        /// <summary>
        /// Wildcard "any user_id in the project" allow toggle. Only valid on SHARED connections.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_all_users")]
        public bool? AllowAllUsers { get; set; }

        /// <summary>
        /// Explicit allow list of user_ids who can use this SHARED connection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_user_ids")]
        public global::System.Collections.Generic.IList<string>? AllowedUserIds { get; set; }

        /// <summary>
        /// Explicit deny list. Wins on conflict with allow_all_users and allowed_user_ids.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("not_allowed_user_ids")]
        public global::System.Collections.Generic.IList<string>? NotAllowedUserIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsLinkRequestExperimentalAclConfigForShared" /> class.
        /// </summary>
        /// <param name="allowAllUsers">
        /// Wildcard "any user_id in the project" allow toggle. Only valid on SHARED connections.
        /// </param>
        /// <param name="allowedUserIds">
        /// Explicit allow list of user_ids who can use this SHARED connection.
        /// </param>
        /// <param name="notAllowedUserIds">
        /// Explicit deny list. Wins on conflict with allow_all_users and allowed_user_ids.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostConnectedAccountsLinkRequestExperimentalAclConfigForShared(
            bool? allowAllUsers,
            global::System.Collections.Generic.IList<string>? allowedUserIds,
            global::System.Collections.Generic.IList<string>? notAllowedUserIds)
        {
            this.AllowAllUsers = allowAllUsers;
            this.AllowedUserIds = allowedUserIds;
            this.NotAllowedUserIds = notAllowedUserIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsLinkRequestExperimentalAclConfigForShared" /> class.
        /// </summary>
        public PostConnectedAccountsLinkRequestExperimentalAclConfigForShared()
        {
        }

    }
}