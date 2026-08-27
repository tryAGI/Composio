
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccount
    {
        /// <summary>
        /// Unique identifier for this account
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// User-assigned alias for this account
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        public string? Alias { get; set; }

        /// <summary>
        /// Information about the connected user (email, name, etc.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_info")]
        public global::System.Collections.Generic.Dictionary<string, object?>? UserInfo { get; set; }

        /// <summary>
        /// Connection status (e.g., "active")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// ISO 8601 timestamp of when the account was connected
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Whether this is the default account for the toolkit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_default")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsDefault { get; set; }

        /// <summary>
        /// Sharing model for this connected account. PRIVATE is owner-only; SHARED is reachable from a tool-router session only when explicitly pinned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccountAccountTypeJsonConverter))]
        public global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccountAccountType? AccountType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccount" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for this account
        /// </param>
        /// <param name="status">
        /// Connection status (e.g., "active")
        /// </param>
        /// <param name="createdAt">
        /// ISO 8601 timestamp of when the account was connected
        /// </param>
        /// <param name="isDefault">
        /// Whether this is the default account for the toolkit
        /// </param>
        /// <param name="alias">
        /// User-assigned alias for this account
        /// </param>
        /// <param name="userInfo">
        /// Information about the connected user (email, name, etc.)
        /// </param>
        /// <param name="accountType">
        /// Sharing model for this connected account. PRIVATE is owner-only; SHARED is reachable from a tool-router session only when explicitly pinned.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccount(
            string id,
            string status,
            string createdAt,
            bool isDefault,
            string? alias,
            global::System.Collections.Generic.Dictionary<string, object?>? userInfo,
            global::Composio.PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccountAccountType? accountType)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Alias = alias;
            this.UserInfo = userInfo;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.IsDefault = isDefault;
            this.AccountType = accountType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccount" /> class.
        /// </summary>
        public PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccount()
        {
        }

    }
}