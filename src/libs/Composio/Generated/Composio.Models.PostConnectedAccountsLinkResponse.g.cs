
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostConnectedAccountsLinkResponse
    {
        /// <summary>
        /// The generated link token for the auth session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("link_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LinkToken { get; set; }

        /// <summary>
        /// The redirect URI to send users to for authentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RedirectUrl { get; set; }

        /// <summary>
        /// ISO timestamp when the link expires
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExpiresAt { get; set; }

        /// <summary>
        /// The connected account ID that was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connected_account_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConnectedAccountId { get; set; }

        /// <summary>
        /// The persisted sharing model for this connected account (PRIVATE | SHARED). Echoes back the value supplied at creation time so callers can confirm what landed without a follow-up GET.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PostConnectedAccountsLinkResponseAccountTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.PostConnectedAccountsLinkResponseAccountType AccountType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsLinkResponse" /> class.
        /// </summary>
        /// <param name="linkToken">
        /// The generated link token for the auth session
        /// </param>
        /// <param name="redirectUrl">
        /// The redirect URI to send users to for authentication
        /// </param>
        /// <param name="expiresAt">
        /// ISO timestamp when the link expires
        /// </param>
        /// <param name="connectedAccountId">
        /// The connected account ID that was created
        /// </param>
        /// <param name="accountType">
        /// The persisted sharing model for this connected account (PRIVATE | SHARED). Echoes back the value supplied at creation time so callers can confirm what landed without a follow-up GET.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostConnectedAccountsLinkResponse(
            string linkToken,
            string redirectUrl,
            string expiresAt,
            string connectedAccountId,
            global::Composio.PostConnectedAccountsLinkResponseAccountType accountType)
        {
            this.LinkToken = linkToken ?? throw new global::System.ArgumentNullException(nameof(linkToken));
            this.RedirectUrl = redirectUrl ?? throw new global::System.ArgumentNullException(nameof(redirectUrl));
            this.ExpiresAt = expiresAt ?? throw new global::System.ArgumentNullException(nameof(expiresAt));
            this.ConnectedAccountId = connectedAccountId ?? throw new global::System.ArgumentNullException(nameof(connectedAccountId));
            this.AccountType = accountType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsLinkResponse" /> class.
        /// </summary>
        public PostConnectedAccountsLinkResponse()
        {
        }
    }
}