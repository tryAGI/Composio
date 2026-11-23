
#nullable enable

namespace Composio
{
    /// <summary>
    /// Experimental. Sends the call to the project's session webhook URL and waits for your endpoint to answer. The answer can let the call run, block it, or change it.
    /// </summary>
    public sealed partial class PatchToolRouterSessionBySessionIdRequestHookVariant2HandlerVariant3
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PatchToolRouterSessionBySessionIdRequestHookVariant2HandlerVariant3TypeJsonConverter))]
        public global::Composio.PatchToolRouterSessionBySessionIdRequestHookVariant2HandlerVariant3Type Type { get; set; }

        /// <summary>
        /// How long to wait for your endpoint to answer, in milliseconds. Defaults to 3000.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_ms")]
        public int? TimeoutMs { get; set; }

        /// <summary>
        /// What happens to the call when your endpoint times out, can't be reached, or sends an answer that can't be read.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallback_action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PatchToolRouterSessionBySessionIdRequestHookVariant2HandlerVariant3FallbackActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.PatchToolRouterSessionBySessionIdRequestHookVariant2HandlerVariant3FallbackAction FallbackAction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchToolRouterSessionBySessionIdRequestHookVariant2HandlerVariant3" /> class.
        /// </summary>
        /// <param name="fallbackAction">
        /// What happens to the call when your endpoint times out, can't be reached, or sends an answer that can't be read.
        /// </param>
        /// <param name="type"></param>
        /// <param name="timeoutMs">
        /// How long to wait for your endpoint to answer, in milliseconds. Defaults to 3000.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchToolRouterSessionBySessionIdRequestHookVariant2HandlerVariant3(
            global::Composio.PatchToolRouterSessionBySessionIdRequestHookVariant2HandlerVariant3FallbackAction fallbackAction,
            global::Composio.PatchToolRouterSessionBySessionIdRequestHookVariant2HandlerVariant3Type type,
            int? timeoutMs)
        {
            this.Type = type;
            this.TimeoutMs = timeoutMs;
            this.FallbackAction = fallbackAction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchToolRouterSessionBySessionIdRequestHookVariant2HandlerVariant3" /> class.
        /// </summary>
        public PatchToolRouterSessionBySessionIdRequestHookVariant2HandlerVariant3()
        {
        }

    }
}