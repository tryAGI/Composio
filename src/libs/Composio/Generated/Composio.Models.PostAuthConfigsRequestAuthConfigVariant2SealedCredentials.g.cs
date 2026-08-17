
#nullable enable

namespace Composio
{
    /// <summary>
    /// [EXPERIMENTAL] Client-sealed secret fields to redeem through the organization keyring instance (GET /api/v3.1/keyring/transfer_keys). The plaintext must not also appear in credentials.
    /// </summary>
    public sealed partial class PostAuthConfigsRequestAuthConfigVariant2SealedCredentials
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}