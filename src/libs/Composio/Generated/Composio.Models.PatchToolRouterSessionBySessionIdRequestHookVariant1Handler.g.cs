
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PatchToolRouterSessionBySessionIdRequestHookVariant1Handler
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PatchToolRouterSessionBySessionIdRequestHookVariant1HandlerTypeJsonConverter))]
        public global::Composio.PatchToolRouterSessionBySessionIdRequestHookVariant1HandlerType Type { get; set; }

        /// <summary>
        /// What to block, written as a plain sentence. For example: "Sending email to anyone outside example.org".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Condition { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PatchToolRouterSessionBySessionIdRequestHookVariant1HandlerActionJsonConverter))]
        public global::Composio.PatchToolRouterSessionBySessionIdRequestHookVariant1HandlerAction Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchToolRouterSessionBySessionIdRequestHookVariant1Handler" /> class.
        /// </summary>
        /// <param name="condition">
        /// What to block, written as a plain sentence. For example: "Sending email to anyone outside example.org".
        /// </param>
        /// <param name="type"></param>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchToolRouterSessionBySessionIdRequestHookVariant1Handler(
            string condition,
            global::Composio.PatchToolRouterSessionBySessionIdRequestHookVariant1HandlerType type,
            global::Composio.PatchToolRouterSessionBySessionIdRequestHookVariant1HandlerAction action)
        {
            this.Type = type;
            this.Condition = condition ?? throw new global::System.ArgumentNullException(nameof(condition));
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchToolRouterSessionBySessionIdRequestHookVariant1Handler" /> class.
        /// </summary>
        public PatchToolRouterSessionBySessionIdRequestHookVariant1Handler()
        {
        }

    }
}