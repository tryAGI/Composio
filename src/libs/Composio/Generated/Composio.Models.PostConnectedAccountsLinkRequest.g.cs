
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostConnectedAccountsLinkRequest
    {
        /// <summary>
        /// The auth config id to create a link for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_config_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AuthConfigId { get; set; }

        /// <summary>
        /// The user id to create a link for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// A human-readable alias for this connected account. Must be unique per entity and toolkit within the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        public string? Alias { get; set; }

        /// <summary>
        /// The callback url to create a link for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Connection data for the linked account (provider-specific key-value pairs)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connection_data")]
        public object? ConnectionData { get; set; }

        /// <summary>
        /// Sharing model for this connected account. PRIVATE (default) is usable only by the owning user_id. SHARED is reachable from a tool-router session ONLY when explicitly pinned in the session config — at most one SHARED connection per toolkit per session. Sessions never use a SHARED connection implicitly. Set at creation time only — cannot be changed later.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PostConnectedAccountsLinkRequestAccountTypeJsonConverter))]
        public global::Composio.PostConnectedAccountsLinkRequestAccountType? AccountType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsLinkRequest" /> class.
        /// </summary>
        /// <param name="authConfigId">
        /// The auth config id to create a link for
        /// </param>
        /// <param name="userId">
        /// The user id to create a link for
        /// </param>
        /// <param name="alias">
        /// A human-readable alias for this connected account. Must be unique per entity and toolkit within the project.
        /// </param>
        /// <param name="callbackUrl">
        /// The callback url to create a link for
        /// </param>
        /// <param name="connectionData">
        /// Connection data for the linked account (provider-specific key-value pairs)
        /// </param>
        /// <param name="accountType">
        /// Sharing model for this connected account. PRIVATE (default) is usable only by the owning user_id. SHARED is reachable from a tool-router session ONLY when explicitly pinned in the session config — at most one SHARED connection per toolkit per session. Sessions never use a SHARED connection implicitly. Set at creation time only — cannot be changed later.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostConnectedAccountsLinkRequest(
            string authConfigId,
            string userId,
            string? alias,
            string? callbackUrl,
            object? connectionData,
            global::Composio.PostConnectedAccountsLinkRequestAccountType? accountType)
        {
            this.AuthConfigId = authConfigId ?? throw new global::System.ArgumentNullException(nameof(authConfigId));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Alias = alias;
            this.CallbackUrl = callbackUrl;
            this.ConnectionData = connectionData;
            this.AccountType = accountType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsLinkRequest" /> class.
        /// </summary>
        public PostConnectedAccountsLinkRequest()
        {
        }
    }
}