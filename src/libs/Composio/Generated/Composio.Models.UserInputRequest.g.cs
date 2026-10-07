
#nullable enable

namespace Composio
{
    /// <summary>
    /// A question for the user, in the shape of an MCP `elicitation/create` request in form mode (https://modelcontextprotocol.io/specification/2026-07-28/client/elicitation). Show `message` to the user and collect an answer that matches `requested_schema`.
    /// </summary>
    public sealed partial class UserInputRequest
    {
        /// <summary>
        /// Always `elicitation`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.UserInputRequestTypeJsonConverter))]
        public global::Composio.UserInputRequestType Type { get; set; }

        /// <summary>
        /// Always `form`: collect the answer with a form built from `requested_schema`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.UserInputRequestModeJsonConverter))]
        public global::Composio.UserInputRequestMode Mode { get; set; }

        /// <summary>
        /// Text to show the user<br/>
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
        /// JSON Schema for the answer. As in MCP form mode, it is a flat object whose fields are strings, numbers, booleans, or single- or multi-select enums.
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
        /// Initializes a new instance of the <see cref="UserInputRequest" /> class.
        /// </summary>
        /// <param name="message">
        /// Text to show the user<br/>
        /// Example: Your agent wants to run the following tool:<br/>
        /// GITHUB_DELETE_A_REPOSITORY({"owner": "acme", "repo": "old-api"})
        /// </param>
        /// <param name="requestedSchema">
        /// JSON Schema for the answer. As in MCP form mode, it is a flat object whose fields are strings, numbers, booleans, or single- or multi-select enums.
        /// </param>
        /// <param name="type">
        /// Always `elicitation`
        /// </param>
        /// <param name="mode">
        /// Always `form`: collect the answer with a form built from `requested_schema`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserInputRequest(
            string message,
            global::System.Collections.Generic.Dictionary<string, object?> requestedSchema,
            global::Composio.UserInputRequestType type,
            global::Composio.UserInputRequestMode mode)
        {
            this.Type = type;
            this.Mode = mode;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.RequestedSchema = requestedSchema ?? throw new global::System.ArgumentNullException(nameof(requestedSchema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserInputRequest" /> class.
        /// </summary>
        public UserInputRequest()
        {
        }

    }
}