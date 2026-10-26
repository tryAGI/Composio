
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ExecuteBlocked
    {
        /// <summary>
        /// A session hook stopped the call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.ExecuteBlockedResultTypeJsonConverter))]
        public global::Composio.ExecuteBlockedResultType ResultType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.BlockReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.BlockReason Reason { get; set; }

        /// <summary>
        /// A message for the agent. It includes the hook's name, when it has one; the hook id is in `reason`.<br/>
        /// Example: Blocked by session policy: No external email
        /// </summary>
        /// <example>Blocked by session policy: No external email</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// The execution log ID. Only set when the tool ran and its response was blocked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("log_id")]
        public string? LogId { get; set; }

        /// <summary>
        /// Returned only when the session enables instant.return_instant_charge and a charge is available. Only set when the tool ran and its response was blocked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instant_charge")]
        public global::Composio.ExecuteBlockedInstantCharge? InstantCharge { get; set; }

        /// <summary>
        /// Every session hook that applied to this call. Omitted when none applied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hook_results")]
        public global::System.Collections.Generic.IList<global::Composio.HookResult>? HookResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteBlocked" /> class.
        /// </summary>
        /// <param name="reason"></param>
        /// <param name="message">
        /// A message for the agent. It includes the hook's name, when it has one; the hook id is in `reason`.<br/>
        /// Example: Blocked by session policy: No external email
        /// </param>
        /// <param name="resultType">
        /// A session hook stopped the call
        /// </param>
        /// <param name="logId">
        /// The execution log ID. Only set when the tool ran and its response was blocked.
        /// </param>
        /// <param name="instantCharge">
        /// Returned only when the session enables instant.return_instant_charge and a charge is available. Only set when the tool ran and its response was blocked.
        /// </param>
        /// <param name="hookResults">
        /// Every session hook that applied to this call. Omitted when none applied.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecuteBlocked(
            global::Composio.BlockReason reason,
            string message,
            global::Composio.ExecuteBlockedResultType resultType,
            string? logId,
            global::Composio.ExecuteBlockedInstantCharge? instantCharge,
            global::System.Collections.Generic.IList<global::Composio.HookResult>? hookResults)
        {
            this.ResultType = resultType;
            this.Reason = reason;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.LogId = logId;
            this.InstantCharge = instantCharge;
            this.HookResults = hookResults;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteBlocked" /> class.
        /// </summary>
        public ExecuteBlocked()
        {
        }

    }
}