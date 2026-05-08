
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolRouterSessionBySessionIdLinkRequest
    {
        /// <summary>
        /// The unique slug identifier of the toolkit to connect<br/>
        /// Example: github
        /// </summary>
        /// <example>github</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolkit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Toolkit { get; set; }

        /// <summary>
        /// A human-readable alias for this connected account. Must be unique per entity and toolkit within the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        public string? Alias { get; set; }

        /// <summary>
        /// URL where users will be redirected after completing auth<br/>
        /// Example: https://myapp.com/callback
        /// </summary>
        /// <example>https://myapp.com/callback</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Sharing model for this connected account. PRIVATE (default) is usable only by the owning user_id. SHARED is reachable from a tool-router session ONLY when explicitly pinned in the session config — at most one SHARED connection per toolkit per session. Sessions never use a SHARED connection implicitly. Set at creation time only — cannot be changed later.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PostToolRouterSessionBySessionIdLinkRequestAccountTypeJsonConverter))]
        public global::Composio.PostToolRouterSessionBySessionIdLinkRequestAccountType? AccountType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdLinkRequest" /> class.
        /// </summary>
        /// <param name="toolkit">
        /// The unique slug identifier of the toolkit to connect<br/>
        /// Example: github
        /// </param>
        /// <param name="alias">
        /// A human-readable alias for this connected account. Must be unique per entity and toolkit within the project.
        /// </param>
        /// <param name="callbackUrl">
        /// URL where users will be redirected after completing auth<br/>
        /// Example: https://myapp.com/callback
        /// </param>
        /// <param name="accountType">
        /// Sharing model for this connected account. PRIVATE (default) is usable only by the owning user_id. SHARED is reachable from a tool-router session ONLY when explicitly pinned in the session config — at most one SHARED connection per toolkit per session. Sessions never use a SHARED connection implicitly. Set at creation time only — cannot be changed later.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolRouterSessionBySessionIdLinkRequest(
            string toolkit,
            string? alias,
            string? callbackUrl,
            global::Composio.PostToolRouterSessionBySessionIdLinkRequestAccountType? accountType)
        {
            this.Toolkit = toolkit ?? throw new global::System.ArgumentNullException(nameof(toolkit));
            this.Alias = alias;
            this.CallbackUrl = callbackUrl;
            this.AccountType = accountType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdLinkRequest" /> class.
        /// </summary>
        public PostToolRouterSessionBySessionIdLinkRequest()
        {
        }
    }
}