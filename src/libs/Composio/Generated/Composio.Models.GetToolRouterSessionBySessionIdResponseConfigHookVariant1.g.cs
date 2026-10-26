
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetToolRouterSessionBySessionIdResponseConfigHookVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.GetToolRouterSessionBySessionIdResponseConfigHookVariant1TypeJsonConverter))]
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigHookVariant1Type Type { get; set; }

        /// <summary>
        /// Unique within the session. Shows up in results and logs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// A readable name. The agent sees it when this hook blocks a call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Which tools the hook covers: "all" for all of them, or only the listed toolkits.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("applies_to")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.AnyOfJsonConverter<global::Composio.GetToolRouterSessionBySessionIdResponseConfigHookVariant1AppliesToEnum?, global::Composio.GetToolRouterSessionBySessionIdResponseConfigHookVariant1AppliesToEnum2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.AnyOf<global::Composio.GetToolRouterSessionBySessionIdResponseConfigHookVariant1AppliesToEnum?, global::Composio.GetToolRouterSessionBySessionIdResponseConfigHookVariant1AppliesToEnum2> AppliesTo { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("handler")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.GetToolRouterSessionBySessionIdResponseConfigHookVariant1Handler Handler { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolRouterSessionBySessionIdResponseConfigHookVariant1" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique within the session. Shows up in results and logs.
        /// </param>
        /// <param name="appliesTo">
        /// Which tools the hook covers: "all" for all of them, or only the listed toolkits.
        /// </param>
        /// <param name="handler"></param>
        /// <param name="type"></param>
        /// <param name="name">
        /// A readable name. The agent sees it when this hook blocks a call.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetToolRouterSessionBySessionIdResponseConfigHookVariant1(
            string id,
            global::Composio.AnyOf<global::Composio.GetToolRouterSessionBySessionIdResponseConfigHookVariant1AppliesToEnum?, global::Composio.GetToolRouterSessionBySessionIdResponseConfigHookVariant1AppliesToEnum2> appliesTo,
            global::Composio.GetToolRouterSessionBySessionIdResponseConfigHookVariant1Handler handler,
            global::Composio.GetToolRouterSessionBySessionIdResponseConfigHookVariant1Type type,
            string? name)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name;
            this.AppliesTo = appliesTo;
            this.Handler = handler ?? throw new global::System.ArgumentNullException(nameof(handler));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolRouterSessionBySessionIdResponseConfigHookVariant1" /> class.
        /// </summary>
        public GetToolRouterSessionBySessionIdResponseConfigHookVariant1()
        {
        }

    }
}