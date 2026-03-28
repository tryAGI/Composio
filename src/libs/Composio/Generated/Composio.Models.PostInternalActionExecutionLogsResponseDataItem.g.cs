
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostInternalActionExecutionLogsResponseDataItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actionKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ActionKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AppKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.PostInternalActionExecutionLogsResponseDataItemApp App { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connectedAccountId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConnectedAccountId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entityId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EntityId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PostInternalActionExecutionLogsResponseDataItemStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.PostInternalActionExecutionLogsResponseDataItemStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("executionTime")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ExecutionTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minimalResponse")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MinimalResponse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Composio.PostInternalActionExecutionLogsResponseDataItemMetadata? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostInternalActionExecutionLogsResponseDataItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="actionKey"></param>
        /// <param name="appKey"></param>
        /// <param name="app"></param>
        /// <param name="connectedAccountId"></param>
        /// <param name="entityId"></param>
        /// <param name="status"></param>
        /// <param name="executionTime"></param>
        /// <param name="minimalResponse"></param>
        /// <param name="metadata"></param>
        /// <param name="createdAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostInternalActionExecutionLogsResponseDataItem(
            string id,
            string actionKey,
            string appKey,
            global::Composio.PostInternalActionExecutionLogsResponseDataItemApp app,
            string connectedAccountId,
            string entityId,
            global::Composio.PostInternalActionExecutionLogsResponseDataItemStatus status,
            double executionTime,
            string minimalResponse,
            double createdAt,
            global::Composio.PostInternalActionExecutionLogsResponseDataItemMetadata? metadata)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ActionKey = actionKey ?? throw new global::System.ArgumentNullException(nameof(actionKey));
            this.AppKey = appKey ?? throw new global::System.ArgumentNullException(nameof(appKey));
            this.App = app ?? throw new global::System.ArgumentNullException(nameof(app));
            this.ConnectedAccountId = connectedAccountId ?? throw new global::System.ArgumentNullException(nameof(connectedAccountId));
            this.EntityId = entityId ?? throw new global::System.ArgumentNullException(nameof(entityId));
            this.Status = status;
            this.ExecutionTime = executionTime;
            this.MinimalResponse = minimalResponse ?? throw new global::System.ArgumentNullException(nameof(minimalResponse));
            this.CreatedAt = createdAt;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostInternalActionExecutionLogsResponseDataItem" /> class.
        /// </summary>
        public PostInternalActionExecutionLogsResponseDataItem()
        {
        }
    }
}