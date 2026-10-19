
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BlockReasonVariant1
    {
        /// <summary>
        /// A before_execute hook stopped the call. The tool did not run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.BlockReasonVariant1TypeJsonConverter))]
        public global::Composio.BlockReasonVariant1Type Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hook_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HookId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BlockReasonVariant1" /> class.
        /// </summary>
        /// <param name="hookId"></param>
        /// <param name="type">
        /// A before_execute hook stopped the call. The tool did not run.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BlockReasonVariant1(
            string hookId,
            global::Composio.BlockReasonVariant1Type type)
        {
            this.Type = type;
            this.HookId = hookId ?? throw new global::System.ArgumentNullException(nameof(hookId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlockReasonVariant1" /> class.
        /// </summary>
        public BlockReasonVariant1()
        {
        }

    }
}