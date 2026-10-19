
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BlockReasonVariant2
    {
        /// <summary>
        /// An after_execute hook stopped the call. The tool ran; its response was withheld.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.BlockReasonVariant2TypeJsonConverter))]
        public global::Composio.BlockReasonVariant2Type Type { get; set; }

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
        /// Initializes a new instance of the <see cref="BlockReasonVariant2" /> class.
        /// </summary>
        /// <param name="hookId"></param>
        /// <param name="type">
        /// An after_execute hook stopped the call. The tool ran; its response was withheld.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BlockReasonVariant2(
            string hookId,
            global::Composio.BlockReasonVariant2Type type)
        {
            this.Type = type;
            this.HookId = hookId ?? throw new global::System.ArgumentNullException(nameof(hookId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlockReasonVariant2" /> class.
        /// </summary>
        public BlockReasonVariant2()
        {
        }

    }
}