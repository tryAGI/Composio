
#nullable enable

namespace Composio
{
    /// <summary>
    /// Blocks a tool response that tries to manipulate the agent: override its instructions, change its role, or make it take actions the user didn't ask for.
    /// </summary>
    public sealed partial class PatchToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PatchToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant2TypeJsonConverter))]
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant2Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PatchToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant2ActionJsonConverter))]
        public global::Composio.PatchToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant2Action Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant2" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant2(
            global::Composio.PatchToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant2Type type,
            global::Composio.PatchToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant2Action action)
        {
            this.Type = type;
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant2" /> class.
        /// </summary>
        public PatchToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant2()
        {
        }

    }
}