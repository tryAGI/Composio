
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ToolRouterInputRequiredResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.ToolRouterInputRequiredResponseResultTypeJsonConverter))]
        public global::Composio.ToolRouterInputRequiredResponseResultType ResultType { get; set; }

        /// <summary>
        /// Questions for the user, keyed by an ID the answers must reuse
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_requests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Composio.ToolRouterInputRequest> InputRequests { get; set; }

        /// <summary>
        /// Opaque state. If present, send it back unchanged with the answers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_state")]
        public string? RequestState { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolRouterInputRequiredResponse" /> class.
        /// </summary>
        /// <param name="inputRequests">
        /// Questions for the user, keyed by an ID the answers must reuse
        /// </param>
        /// <param name="resultType"></param>
        /// <param name="requestState">
        /// Opaque state. If present, send it back unchanged with the answers
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolRouterInputRequiredResponse(
            global::System.Collections.Generic.Dictionary<string, global::Composio.ToolRouterInputRequest> inputRequests,
            global::Composio.ToolRouterInputRequiredResponseResultType resultType,
            string? requestState)
        {
            this.ResultType = resultType;
            this.InputRequests = inputRequests ?? throw new global::System.ArgumentNullException(nameof(inputRequests));
            this.RequestState = requestState;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolRouterInputRequiredResponse" /> class.
        /// </summary>
        public ToolRouterInputRequiredResponse()
        {
        }

    }
}