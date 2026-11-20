
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PostCliCreateSessionRequest
    {
        /// <summary>
        /// Key scope. 'project' (default) returns a project-level API key; 'user' returns a user-level API key valid across projects.<br/>
        /// Default Value: project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PostCliCreateSessionRequestScopeJsonConverter))]
        public global::Composio.PostCliCreateSessionRequestScope? Scope { get; set; }

        /// <summary>
        /// Free-form string describing the source, e.g. 'Johns MacBook (darwin, v1.2.3)'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// PKCE-style S256 challenge: the base64url encoding, without padding, of the SHA-256 digest of a random verifier the client keeps. Send together with code_challenge_method.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_challenge")]
        public string? CodeChallenge { get; set; }

        /// <summary>
        /// Method used to derive code_challenge from the verifier. Only S256 is supported. Send together with code_challenge.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_challenge_method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PostCliCreateSessionRequestCodeChallengeMethodJsonConverter))]
        public global::Composio.PostCliCreateSessionRequestCodeChallengeMethod? CodeChallengeMethod { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCliCreateSessionRequest" /> class.
        /// </summary>
        /// <param name="scope">
        /// Key scope. 'project' (default) returns a project-level API key; 'user' returns a user-level API key valid across projects.<br/>
        /// Default Value: project
        /// </param>
        /// <param name="source">
        /// Free-form string describing the source, e.g. 'Johns MacBook (darwin, v1.2.3)'
        /// </param>
        /// <param name="codeChallenge">
        /// PKCE-style S256 challenge: the base64url encoding, without padding, of the SHA-256 digest of a random verifier the client keeps. Send together with code_challenge_method.
        /// </param>
        /// <param name="codeChallengeMethod">
        /// Method used to derive code_challenge from the verifier. Only S256 is supported. Send together with code_challenge.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostCliCreateSessionRequest(
            global::Composio.PostCliCreateSessionRequestScope? scope,
            string? source,
            string? codeChallenge,
            global::Composio.PostCliCreateSessionRequestCodeChallengeMethod? codeChallengeMethod)
        {
            this.Scope = scope;
            this.Source = source;
            this.CodeChallenge = codeChallenge;
            this.CodeChallengeMethod = codeChallengeMethod;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCliCreateSessionRequest" /> class.
        /// </summary>
        public PostCliCreateSessionRequest()
        {
        }

    }
}