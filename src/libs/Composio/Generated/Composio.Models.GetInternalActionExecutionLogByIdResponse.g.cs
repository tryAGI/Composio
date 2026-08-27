
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetInternalActionExecutionLogByIdResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actionLogId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ActionLogId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ActionId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.GetInternalActionExecutionLogByIdResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.GetInternalActionExecutionLogByIdResponseStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.GetInternalActionExecutionLogByIdResponseApp App { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connection")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.GetInternalActionExecutionLogByIdResponseConnection Connection { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, object?> Session { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("executionMetadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, object?> ExecutionMetadata { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Composio.GetInternalActionExecutionLogByIdResponseStep> Steps { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payloadReceived")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, object?> PayloadReceived { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startTime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StartTime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endTime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double EndTime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalDuration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TotalDuration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        public global::System.Collections.Generic.Dictionary<string, object?>? Response { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, object?> Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInternalActionExecutionLogByIdResponse" /> class.
        /// </summary>
        /// <param name="actionLogId"></param>
        /// <param name="actionId"></param>
        /// <param name="status"></param>
        /// <param name="app"></param>
        /// <param name="version"></param>
        /// <param name="connection"></param>
        /// <param name="session"></param>
        /// <param name="executionMetadata"></param>
        /// <param name="steps"></param>
        /// <param name="payloadReceived"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="totalDuration"></param>
        /// <param name="error"></param>
        /// <param name="response"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetInternalActionExecutionLogByIdResponse(
            string actionLogId,
            string actionId,
            global::Composio.GetInternalActionExecutionLogByIdResponseStatus status,
            global::Composio.GetInternalActionExecutionLogByIdResponseApp app,
            string version,
            global::Composio.GetInternalActionExecutionLogByIdResponseConnection connection,
            global::System.Collections.Generic.Dictionary<string, object?> session,
            global::System.Collections.Generic.Dictionary<string, object?> executionMetadata,
            global::System.Collections.Generic.IList<global::Composio.GetInternalActionExecutionLogByIdResponseStep> steps,
            global::System.Collections.Generic.Dictionary<string, object?> payloadReceived,
            double startTime,
            double endTime,
            string totalDuration,
            global::System.Collections.Generic.Dictionary<string, object?> error,
            global::System.Collections.Generic.Dictionary<string, object?>? response)
        {
            this.ActionLogId = actionLogId ?? throw new global::System.ArgumentNullException(nameof(actionLogId));
            this.ActionId = actionId ?? throw new global::System.ArgumentNullException(nameof(actionId));
            this.Status = status;
            this.App = app ?? throw new global::System.ArgumentNullException(nameof(app));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Connection = connection ?? throw new global::System.ArgumentNullException(nameof(connection));
            this.Session = session ?? throw new global::System.ArgumentNullException(nameof(session));
            this.ExecutionMetadata = executionMetadata ?? throw new global::System.ArgumentNullException(nameof(executionMetadata));
            this.Steps = steps ?? throw new global::System.ArgumentNullException(nameof(steps));
            this.PayloadReceived = payloadReceived ?? throw new global::System.ArgumentNullException(nameof(payloadReceived));
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.TotalDuration = totalDuration ?? throw new global::System.ArgumentNullException(nameof(totalDuration));
            this.Response = response;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetInternalActionExecutionLogByIdResponse" /> class.
        /// </summary>
        public GetInternalActionExecutionLogByIdResponse()
        {
        }

    }
}