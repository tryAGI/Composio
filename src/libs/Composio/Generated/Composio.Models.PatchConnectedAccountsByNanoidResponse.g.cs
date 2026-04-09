
#nullable enable

namespace Composio
{
    /// <summary>
    /// Example: {"success":true,"id":"ca_1a2b3c4d5e6f","status":"ACTIVE"}
    /// </summary>
    public sealed partial class PatchConnectedAccountsByNanoidResponse
    {
        /// <summary>
        /// Whether the update was successful
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// The unique identifier of the updated connected account
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The current status of the connected account after the update (ACTIVE, EXPIRED, INACTIVE, etc.)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchConnectedAccountsByNanoidResponse" /> class.
        /// </summary>
        /// <param name="success">
        /// Whether the update was successful
        /// </param>
        /// <param name="id">
        /// The unique identifier of the updated connected account
        /// </param>
        /// <param name="status">
        /// The current status of the connected account after the update (ACTIVE, EXPIRED, INACTIVE, etc.)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchConnectedAccountsByNanoidResponse(
            bool success,
            string id,
            string status)
        {
            this.Success = success;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchConnectedAccountsByNanoidResponse" /> class.
        /// </summary>
        public PatchConnectedAccountsByNanoidResponse()
        {
        }
    }
}