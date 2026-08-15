
#nullable enable

namespace Composio
{
    /// <summary>
    /// [EXPERIMENTAL] Opt-in auth-config features.
    /// </summary>
    public sealed partial class PostAuthConfigsRequestAuthConfigVariant2Experimental
    {
        /// <summary>
        /// Client-sealed secret fields to redeem through the organization keyring instance (GET /api/v3.1/keyring/transfer_keys). The plaintext must not also appear in credentials.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sealed_credentials")]
        public global::System.Collections.Generic.Dictionary<string, string>? SealedCredentials { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostAuthConfigsRequestAuthConfigVariant2Experimental" /> class.
        /// </summary>
        /// <param name="sealedCredentials">
        /// Client-sealed secret fields to redeem through the organization keyring instance (GET /api/v3.1/keyring/transfer_keys). The plaintext must not also appear in credentials.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostAuthConfigsRequestAuthConfigVariant2Experimental(
            global::System.Collections.Generic.Dictionary<string, string>? sealedCredentials)
        {
            this.SealedCredentials = sealedCredentials;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostAuthConfigsRequestAuthConfigVariant2Experimental" /> class.
        /// </summary>
        public PostAuthConfigsRequestAuthConfigVariant2Experimental()
        {
        }

    }
}