
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class HookResultVariant1
    {
        /// <summary>
        /// The hook id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.HookResultVariant1StatusJsonConverter))]
        public global::Composio.HookResultVariant1Status Status { get; set; }

        /// <summary>
        /// What the hook decided
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outcome")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.HookResultVariant1OutcomeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.HookResultVariant1Outcome Outcome { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HookResultVariant1" /> class.
        /// </summary>
        /// <param name="id">
        /// The hook id
        /// </param>
        /// <param name="outcome">
        /// What the hook decided
        /// </param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HookResultVariant1(
            string id,
            global::Composio.HookResultVariant1Outcome outcome,
            global::Composio.HookResultVariant1Status status)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.Outcome = outcome;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HookResultVariant1" /> class.
        /// </summary>
        public HookResultVariant1()
        {
        }

    }
}