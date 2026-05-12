
#nullable enable

namespace Composio
{
    /// <summary>
    /// Access control for SHARED connections. Visible only to the connection creator and project/org API key callers; non-creator cookie callers receive the response without this block.
    /// </summary>
    public sealed partial class PostToolRouterSessionBySessionIdLinkResponseExperimentalAclConfigForShared
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_all_users")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AllowAllUsers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_user_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AllowedUserIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("not_allowed_user_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> NotAllowedUserIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdLinkResponseExperimentalAclConfigForShared" /> class.
        /// </summary>
        /// <param name="allowAllUsers"></param>
        /// <param name="allowedUserIds"></param>
        /// <param name="notAllowedUserIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolRouterSessionBySessionIdLinkResponseExperimentalAclConfigForShared(
            bool allowAllUsers,
            global::System.Collections.Generic.IList<string> allowedUserIds,
            global::System.Collections.Generic.IList<string> notAllowedUserIds)
        {
            this.AllowAllUsers = allowAllUsers;
            this.AllowedUserIds = allowedUserIds ?? throw new global::System.ArgumentNullException(nameof(allowedUserIds));
            this.NotAllowedUserIds = notAllowedUserIds ?? throw new global::System.ArgumentNullException(nameof(notAllowedUserIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdLinkResponseExperimentalAclConfigForShared" /> class.
        /// </summary>
        public PostToolRouterSessionBySessionIdLinkResponseExperimentalAclConfigForShared()
        {
        }

    }
}