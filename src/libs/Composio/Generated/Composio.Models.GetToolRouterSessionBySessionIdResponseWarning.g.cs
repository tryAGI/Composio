
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetToolRouterSessionBySessionIdResponseWarning
    {
        /// <summary>
        /// Stable machine code identifying the advisory. Safe to switch on in client code.<br/>
        /// Example: PRELOAD_TOOLS_HIGH_CONTEXT_USAGE
        /// </summary>
        /// <example>PRELOAD_TOOLS_HIGH_CONTEXT_USAGE</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.GetToolRouterSessionBySessionIdResponseWarningCodeJsonConverter))]
        public global::Composio.GetToolRouterSessionBySessionIdResponseWarningCode Code { get; set; }

        /// <summary>
        /// Human-readable description of the advisory. Suitable for logging or surfacing to end users.<br/>
        /// Example: Session preloads 25 tools; each preloaded tool adds to the agent context window. Consider keeping the list at or under ~20 tools.
        /// </summary>
        /// <example>Session preloads 25 tools; each preloaded tool adds to the agent context window. Consider keeping the list at or under ~20 tools.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolRouterSessionBySessionIdResponseWarning" /> class.
        /// </summary>
        /// <param name="message">
        /// Human-readable description of the advisory. Suitable for logging or surfacing to end users.<br/>
        /// Example: Session preloads 25 tools; each preloaded tool adds to the agent context window. Consider keeping the list at or under ~20 tools.
        /// </param>
        /// <param name="code">
        /// Stable machine code identifying the advisory. Safe to switch on in client code.<br/>
        /// Example: PRELOAD_TOOLS_HIGH_CONTEXT_USAGE
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetToolRouterSessionBySessionIdResponseWarning(
            string message,
            global::Composio.GetToolRouterSessionBySessionIdResponseWarningCode code)
        {
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolRouterSessionBySessionIdResponseWarning" /> class.
        /// </summary>
        public GetToolRouterSessionBySessionIdResponseWarning()
        {
        }
    }
}