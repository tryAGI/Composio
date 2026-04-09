
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchConnectedAccountBodyConnection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.PatchConnectedAccountBodyConnectionState State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchConnectedAccountBodyConnection" /> class.
        /// </summary>
        /// <param name="state"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchConnectedAccountBodyConnection(
            global::Composio.PatchConnectedAccountBodyConnectionState state)
        {
            this.State = state ?? throw new global::System.ArgumentNullException(nameof(state));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchConnectedAccountBodyConnection" /> class.
        /// </summary>
        public PatchConnectedAccountBodyConnection()
        {
        }
    }
}