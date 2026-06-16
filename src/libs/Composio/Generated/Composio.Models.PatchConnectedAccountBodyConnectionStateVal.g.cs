
#nullable enable

namespace Composio
{
    /// <summary>
    /// Credential fields to update. Only provided fields are changed — omitted fields are preserved. Set a field to null to remove it.
    /// </summary>
    public sealed partial class PatchConnectedAccountBodyConnectionStateVal
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generic_api_key")]
        public string? GenericApiKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bearer_token")]
        public string? BearerToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("basic_encoded")]
        public string? BasicEncoded { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generic_token")]
        public string? GenericToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_prefix")]
        public string? ApiKeyPrefix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generic_secret")]
        public string? GenericSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generic_id")]
        public string? GenericId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_agent")]
        public string? UserAgent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("password")]
        public string? Password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials_json")]
        public string? CredentialsJson { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("application_id")]
        public string? ApplicationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installation_id")]
        public string? InstallationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private_key")]
        public string? PrivateKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchConnectedAccountBodyConnectionStateVal" /> class.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="genericApiKey"></param>
        /// <param name="apiKey"></param>
        /// <param name="bearerToken"></param>
        /// <param name="basicEncoded"></param>
        /// <param name="genericToken"></param>
        /// <param name="apiKeyPrefix"></param>
        /// <param name="genericSecret"></param>
        /// <param name="genericId"></param>
        /// <param name="userAgent"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="credentialsJson"></param>
        /// <param name="applicationId"></param>
        /// <param name="installationId"></param>
        /// <param name="privateKey"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchConnectedAccountBodyConnectionStateVal(
            string? token,
            string? genericApiKey,
            string? apiKey,
            string? bearerToken,
            string? basicEncoded,
            string? genericToken,
            string? apiKeyPrefix,
            string? genericSecret,
            string? genericId,
            string? userAgent,
            string? username,
            string? password,
            string? credentialsJson,
            string? applicationId,
            string? installationId,
            string? privateKey)
        {
            this.Token = token;
            this.GenericApiKey = genericApiKey;
            this.ApiKey = apiKey;
            this.BearerToken = bearerToken;
            this.BasicEncoded = basicEncoded;
            this.GenericToken = genericToken;
            this.ApiKeyPrefix = apiKeyPrefix;
            this.GenericSecret = genericSecret;
            this.GenericId = genericId;
            this.UserAgent = userAgent;
            this.Username = username;
            this.Password = password;
            this.CredentialsJson = credentialsJson;
            this.ApplicationId = applicationId;
            this.InstallationId = installationId;
            this.PrivateKey = privateKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchConnectedAccountBodyConnectionStateVal" /> class.
        /// </summary>
        public PatchConnectedAccountBodyConnectionStateVal()
        {
        }

    }
}