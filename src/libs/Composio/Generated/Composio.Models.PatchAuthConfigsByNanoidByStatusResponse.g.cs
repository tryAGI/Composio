
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchAuthConfigsByNanoidByStatusResponse
    {
        /// <summary>
        /// Whether the status update succeeded
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// A human-readable result message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchAuthConfigsByNanoidByStatusResponse" /> class.
        /// </summary>
        /// <param name="success">
        /// Whether the status update succeeded
        /// </param>
        /// <param name="message">
        /// A human-readable result message
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchAuthConfigsByNanoidByStatusResponse(
            bool success,
            string message)
        {
            this.Success = success;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchAuthConfigsByNanoidByStatusResponse" /> class.
        /// </summary>
        public PatchAuthConfigsByNanoidByStatusResponse()
        {
        }

    }
}