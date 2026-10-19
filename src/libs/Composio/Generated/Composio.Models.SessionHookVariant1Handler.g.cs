
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SessionHookVariant1Handler
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.SessionHookVariant1HandlerTypeJsonConverter))]
        public global::Composio.SessionHookVariant1HandlerType Type { get; set; }

        /// <summary>
        /// What to block, written as a plain sentence. For example: "Sending email to anyone outside example.org".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_match")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.SessionHookVariant1HandlerOnMatchJsonConverter))]
        public global::Composio.SessionHookVariant1HandlerOnMatch OnMatch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionHookVariant1Handler" /> class.
        /// </summary>
        /// <param name="prompt">
        /// What to block, written as a plain sentence. For example: "Sending email to anyone outside example.org".
        /// </param>
        /// <param name="type"></param>
        /// <param name="onMatch"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionHookVariant1Handler(
            string prompt,
            global::Composio.SessionHookVariant1HandlerType type,
            global::Composio.SessionHookVariant1HandlerOnMatch onMatch)
        {
            this.Type = type;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.OnMatch = onMatch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionHookVariant1Handler" /> class.
        /// </summary>
        public SessionHookVariant1Handler()
        {
        }

    }
}