
#nullable enable

namespace Composio
{
    /// <summary>
    /// Response returned after successfully deleting a connected account<br/>
    /// Example: {"success":true}
    /// </summary>
    public sealed partial class DeleteConnectedAccountsByNanoidResponse
    {
        /// <summary>
        /// Indicates whether the connected account was successfully deleted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// Identifier of the background revoke job started for this delete. Present only when `revoke_on_delete=true`. Track the job and its per-connection results from the Composio dashboard — a programmatic endpoint to poll this job is not yet generally available.<br/>
        /// Example: pj_1a2b3c4d5e6f
        /// </summary>
        /// <example>pj_1a2b3c4d5e6f</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("revoke_job_id")]
        public string? RevokeJobId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteConnectedAccountsByNanoidResponse" /> class.
        /// </summary>
        /// <param name="success">
        /// Indicates whether the connected account was successfully deleted
        /// </param>
        /// <param name="revokeJobId">
        /// Identifier of the background revoke job started for this delete. Present only when `revoke_on_delete=true`. Track the job and its per-connection results from the Composio dashboard — a programmatic endpoint to poll this job is not yet generally available.<br/>
        /// Example: pj_1a2b3c4d5e6f
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteConnectedAccountsByNanoidResponse(
            bool success,
            string? revokeJobId)
        {
            this.Success = success;
            this.RevokeJobId = revokeJobId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteConnectedAccountsByNanoidResponse" /> class.
        /// </summary>
        public DeleteConnectedAccountsByNanoidResponse()
        {
        }

    }
}