
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PostToolRouterSessionBySessionIdExecuteMetaResponse
    {
        /// <summary>
        /// Returned only when the session enables premium_usage.return_premium_charge and a charge is available. Failed individual tool calls omit it. Multi-execute returns one aggregate of reported charges from eligible successful calls, even if another call fails.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("premium_charge")]
        public global::Composio.PostToolRouterSessionBySessionIdExecuteMetaResponsePremiumCharge? PremiumCharge { get; set; }

        /// <summary>
        /// The data returned by the tool execution<br/>
        /// Example: {"message":"Hello, World!","status":"success"}
        /// </summary>
        /// <example>{"message":"Hello, World!","status":"success"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, object?> Data { get; set; }

        /// <summary>
        /// Error message if the execution failed, null otherwise
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Unique identifier for the execution log<br/>
        /// Example: log_abc123xyz
        /// </summary>
        /// <example>log_abc123xyz</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("log_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LogId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdExecuteMetaResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The data returned by the tool execution<br/>
        /// Example: {"message":"Hello, World!","status":"success"}
        /// </param>
        /// <param name="logId">
        /// Unique identifier for the execution log<br/>
        /// Example: log_abc123xyz
        /// </param>
        /// <param name="premiumCharge">
        /// Returned only when the session enables premium_usage.return_premium_charge and a charge is available. Failed individual tool calls omit it. Multi-execute returns one aggregate of reported charges from eligible successful calls, even if another call fails.
        /// </param>
        /// <param name="error">
        /// Error message if the execution failed, null otherwise
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolRouterSessionBySessionIdExecuteMetaResponse(
            global::System.Collections.Generic.Dictionary<string, object?> data,
            string logId,
            global::Composio.PostToolRouterSessionBySessionIdExecuteMetaResponsePremiumCharge? premiumCharge,
            string? error)
        {
            this.PremiumCharge = premiumCharge;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Error = error;
            this.LogId = logId ?? throw new global::System.ArgumentNullException(nameof(logId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdExecuteMetaResponse" /> class.
        /// </summary>
        public PostToolRouterSessionBySessionIdExecuteMetaResponse()
        {
        }

    }
}