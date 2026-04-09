
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchConnectedAccountBodyConnectionState
    {
        /// <summary>
        /// The auth scheme of the connected account. Must match the connection's actual auth scheme.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authScheme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PatchConnectedAccountBodyConnectionStateAuthSchemeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.PatchConnectedAccountBodyConnectionStateAuthScheme AuthScheme { get; set; }

        /// <summary>
        /// Credential fields to update. Only provided fields are changed — omitted fields are preserved. Set a field to null to remove it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("val")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.PatchConnectedAccountBodyConnectionStateVal Val { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchConnectedAccountBodyConnectionState" /> class.
        /// </summary>
        /// <param name="authScheme">
        /// The auth scheme of the connected account. Must match the connection's actual auth scheme.
        /// </param>
        /// <param name="val">
        /// Credential fields to update. Only provided fields are changed — omitted fields are preserved. Set a field to null to remove it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchConnectedAccountBodyConnectionState(
            global::Composio.PatchConnectedAccountBodyConnectionStateAuthScheme authScheme,
            global::Composio.PatchConnectedAccountBodyConnectionStateVal val)
        {
            this.AuthScheme = authScheme;
            this.Val = val ?? throw new global::System.ArgumentNullException(nameof(val));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchConnectedAccountBodyConnectionState" /> class.
        /// </summary>
        public PatchConnectedAccountBodyConnectionState()
        {
        }
    }
}