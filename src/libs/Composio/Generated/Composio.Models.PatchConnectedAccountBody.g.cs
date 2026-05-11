
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchConnectedAccountBody
    {
        /// <summary>
        /// A human-readable alias for this connected account. Pass an empty string to clear the alias. Must be unique per entity and toolkit within the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        public string? Alias { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connection")]
        public global::Composio.PatchConnectedAccountBodyConnection? Connection { get; set; }

        /// <summary>
        /// Access control for SHARED connections. Resolution rule (only fires when caller != creator): user in not_allowed_user_ids → DENY; allow_all_users=true → ALLOW; user in allowed_user_ids → ALLOW; else DENY. Default state (omitted or {}) is deny-by-default — only the creator can use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("acl_config_for_shared")]
        public global::Composio.PatchConnectedAccountBodyAclConfigForShared? AclConfigForShared { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchConnectedAccountBody" /> class.
        /// </summary>
        /// <param name="alias">
        /// A human-readable alias for this connected account. Pass an empty string to clear the alias. Must be unique per entity and toolkit within the project.
        /// </param>
        /// <param name="connection"></param>
        /// <param name="aclConfigForShared">
        /// Access control for SHARED connections. Resolution rule (only fires when caller != creator): user in not_allowed_user_ids → DENY; allow_all_users=true → ALLOW; user in allowed_user_ids → ALLOW; else DENY. Default state (omitted or {}) is deny-by-default — only the creator can use.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchConnectedAccountBody(
            string? alias,
            global::Composio.PatchConnectedAccountBodyConnection? connection,
            global::Composio.PatchConnectedAccountBodyAclConfigForShared? aclConfigForShared)
        {
            this.Alias = alias;
            this.Connection = connection;
            this.AclConfigForShared = aclConfigForShared;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchConnectedAccountBody" /> class.
        /// </summary>
        public PatchConnectedAccountBody()
        {
        }

    }
}