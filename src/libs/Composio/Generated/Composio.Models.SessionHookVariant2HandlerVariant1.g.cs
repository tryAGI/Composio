
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SessionHookVariant2HandlerVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.SessionHookVariant2HandlerVariant1TypeJsonConverter))]
        public global::Composio.SessionHookVariant2HandlerVariant1Type Type { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.SessionHookVariant2HandlerVariant1OnMatchJsonConverter))]
        public global::Composio.SessionHookVariant2HandlerVariant1OnMatch OnMatch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionHookVariant2HandlerVariant1" /> class.
        /// </summary>
        /// <param name="prompt">
        /// What to block, written as a plain sentence. For example: "Sending email to anyone outside example.org".
        /// </param>
        /// <param name="type"></param>
        /// <param name="onMatch"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionHookVariant2HandlerVariant1(
            string prompt,
            global::Composio.SessionHookVariant2HandlerVariant1Type type,
            global::Composio.SessionHookVariant2HandlerVariant1OnMatch onMatch)
        {
            this.Type = type;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.OnMatch = onMatch;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionHookVariant2HandlerVariant1" /> class.
        /// </summary>
        public SessionHookVariant2HandlerVariant1()
        {
        }

    }
}