
#nullable enable

namespace Composio
{
    /// <summary>
    /// The call needs the user's input before it runs. Returned only when the session is configured to ask for user approval before tool execution. Show each question in `input_requests` to the user, then repeat the same call with their answers in `input_responses`, along with this `request_state` if present.
    /// </summary>
    public sealed partial class ExecuteRequiresUserInput
    {
        /// <summary>
        /// The call needs the user's input before it runs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.ExecuteRequiresUserInputResultTypeJsonConverter))]
        public global::Composio.ExecuteRequiresUserInputResultType ResultType { get; set; }

        /// <summary>
        /// Questions for the user, keyed by an ID the answers must reuse
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Composio.UserInputRequest> InputRequests { get; set; }

        /// <summary>
        /// Send this back unchanged in `request_state` with the answers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_state")]
        public string? RequestState { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteRequiresUserInput" /> class.
        /// </summary>
        /// <param name="inputRequests">
        /// Questions for the user, keyed by an ID the answers must reuse
        /// </param>
        /// <param name="resultType">
        /// The call needs the user's input before it runs
        /// </param>
        /// <param name="requestState">
        /// Send this back unchanged in `request_state` with the answers
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecuteRequiresUserInput(
            global::System.Collections.Generic.Dictionary<string, global::Composio.UserInputRequest> inputRequests,
            global::Composio.ExecuteRequiresUserInputResultType resultType,
            string? requestState)
        {
            this.ResultType = resultType;
            this.InputRequests = inputRequests ?? throw new global::System.ArgumentNullException(nameof(inputRequests));
            this.RequestState = requestState;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteRequiresUserInput" /> class.
        /// </summary>
        public ExecuteRequiresUserInput()
        {
        }

    }
}