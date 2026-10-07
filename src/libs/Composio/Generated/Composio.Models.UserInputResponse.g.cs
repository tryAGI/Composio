
#nullable enable

namespace Composio
{
    /// <summary>
    /// The user's answer to one question, in the shape of an MCP elicitation result (https://modelcontextprotocol.io/specification/2026-07-28/client/elicitation).
    /// </summary>
    public sealed partial class UserInputResponse
    {
        /// <summary>
        /// `accept` when the user submitted the form, `decline` when they said no, `cancel` when they dismissed it
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.UserInputResponseActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.UserInputResponseAction Action { get; set; }

        /// <summary>
        /// With `accept`, the user's answer: fields matching the question's `requested_schema`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.Dictionary<string, object?>? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserInputResponse" /> class.
        /// </summary>
        /// <param name="action">
        /// `accept` when the user submitted the form, `decline` when they said no, `cancel` when they dismissed it
        /// </param>
        /// <param name="content">
        /// With `accept`, the user's answer: fields matching the question's `requested_schema`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserInputResponse(
            global::Composio.UserInputResponseAction action,
            global::System.Collections.Generic.Dictionary<string, object?>? content)
        {
            this.Action = action;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserInputResponse" /> class.
        /// </summary>
        public UserInputResponse()
        {
        }

    }
}