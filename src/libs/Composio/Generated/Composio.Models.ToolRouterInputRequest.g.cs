
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ToolRouterInputRequest
    {
        /// <summary>
        /// Kind of input requested
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.ToolRouterInputRequestTypeJsonConverter))]
        public global::Composio.ToolRouterInputRequestType Type { get; set; }

        /// <summary>
        /// How the client collects the input
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.ToolRouterInputRequestModeJsonConverter))]
        public global::Composio.ToolRouterInputRequestMode Mode { get; set; }

        /// <summary>
        /// Message to show the user<br/>
        /// Example: Your agent wants to run the following tool:<br/>
        /// GITHUB_DELETE_A_REPOSITORY({"owner": "acme", "repo": "old-api"})
        /// </summary>
        /// <example>
        /// Your agent wants to run the following tool:<br/>
        /// GITHUB_DELETE_A_REPOSITORY({"owner": "acme", "repo": "old-api"})
        /// </example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// JSON Schema for the answer: a flat object with string, number, boolean or enum fields
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, object?> RequestedSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolRouterInputRequest" /> class.
        /// </summary>
        /// <param name="message">
        /// Message to show the user<br/>
        /// Example: Your agent wants to run the following tool:<br/>
        /// GITHUB_DELETE_A_REPOSITORY({"owner": "acme", "repo": "old-api"})
        /// </param>
        /// <param name="requestedSchema">
        /// JSON Schema for the answer: a flat object with string, number, boolean or enum fields
        /// </param>
        /// <param name="type">
        /// Kind of input requested
        /// </param>
        /// <param name="mode">
        /// How the client collects the input
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolRouterInputRequest(
            string message,
            global::System.Collections.Generic.Dictionary<string, object?> requestedSchema,
            global::Composio.ToolRouterInputRequestType type,
            global::Composio.ToolRouterInputRequestMode mode)
        {
            this.Type = type;
            this.Mode = mode;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.RequestedSchema = requestedSchema ?? throw new global::System.ArgumentNullException(nameof(requestedSchema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolRouterInputRequest" /> class.
        /// </summary>
        public ToolRouterInputRequest()
        {
        }

    }
}