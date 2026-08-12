
#nullable enable

namespace Composio
{
    /// <summary>
    /// Configuration for the project
    /// </summary>
    public sealed partial class PostOrgOwnerProjectNewRequestConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_2FA_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Is2faEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logo_url")]
        public string? LogoUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask_secret_keys_in_connected_account")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool MaskSecretKeysInConnectedAccount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("log_visibility_setting")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PostOrgOwnerProjectNewRequestConfigLogVisibilitySettingJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.PostOrgOwnerProjectNewRequestConfigLogVisibilitySetting LogVisibilitySetting { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("require_mcp_api_key")]
        public bool? RequireMcpApiKey { get; set; }

        /// <summary>
        /// Whether to enable composio link for managed authentication. This key will be deprecated in the future. Please don't use this key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_composio_link_enabled_for_managed_auth")]
        public bool? IsComposioLinkEnabledForManagedAuth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signed_url_file_expiry_in_seconds")]
        public double? SignedUrlFileExpiryInSeconds { get; set; }

        /// <summary>
        /// Developer-hosted OAuth callback verifier URL. Setting it enables per-user callback identity verification; null disables it. Must be https and pass SSRF checks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth_callback_verifier_url")]
        public string? OauthCallbackVerifierUrl { get; set; }

        /// <summary>
        /// Link-auth theme for the hosted connect page. Opaque to Apollo; the dashboard owns the token vocabulary and all value validation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("theme")]
        public global::System.Collections.Generic.Dictionary<string, object?>? Theme { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostOrgOwnerProjectNewRequestConfig" /> class.
        /// </summary>
        /// <param name="is2faEnabled"></param>
        /// <param name="maskSecretKeysInConnectedAccount"></param>
        /// <param name="logVisibilitySetting"></param>
        /// <param name="logoUrl"></param>
        /// <param name="displayName"></param>
        /// <param name="requireMcpApiKey"></param>
        /// <param name="isComposioLinkEnabledForManagedAuth">
        /// Whether to enable composio link for managed authentication. This key will be deprecated in the future. Please don't use this key.
        /// </param>
        /// <param name="signedUrlFileExpiryInSeconds"></param>
        /// <param name="oauthCallbackVerifierUrl">
        /// Developer-hosted OAuth callback verifier URL. Setting it enables per-user callback identity verification; null disables it. Must be https and pass SSRF checks.
        /// </param>
        /// <param name="theme">
        /// Link-auth theme for the hosted connect page. Opaque to Apollo; the dashboard owns the token vocabulary and all value validation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostOrgOwnerProjectNewRequestConfig(
            bool is2faEnabled,
            bool maskSecretKeysInConnectedAccount,
            global::Composio.PostOrgOwnerProjectNewRequestConfigLogVisibilitySetting logVisibilitySetting,
            string? logoUrl,
            string? displayName,
            bool? requireMcpApiKey,
            bool? isComposioLinkEnabledForManagedAuth,
            double? signedUrlFileExpiryInSeconds,
            string? oauthCallbackVerifierUrl,
            global::System.Collections.Generic.Dictionary<string, object?>? theme)
        {
            this.Is2faEnabled = is2faEnabled;
            this.LogoUrl = logoUrl;
            this.DisplayName = displayName;
            this.MaskSecretKeysInConnectedAccount = maskSecretKeysInConnectedAccount;
            this.LogVisibilitySetting = logVisibilitySetting;
            this.RequireMcpApiKey = requireMcpApiKey;
            this.IsComposioLinkEnabledForManagedAuth = isComposioLinkEnabledForManagedAuth;
            this.SignedUrlFileExpiryInSeconds = signedUrlFileExpiryInSeconds;
            this.OauthCallbackVerifierUrl = oauthCallbackVerifierUrl;
            this.Theme = theme;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostOrgOwnerProjectNewRequestConfig" /> class.
        /// </summary>
        public PostOrgOwnerProjectNewRequestConfig()
        {
        }

    }
}