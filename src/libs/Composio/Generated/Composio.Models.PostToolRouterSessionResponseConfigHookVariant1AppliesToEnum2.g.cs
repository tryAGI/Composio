
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PostToolRouterSessionResponseConfigHookVariant1AppliesToEnum2
    {
        /// <summary>
        /// Toolkit slugs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolkits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Toolkits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionResponseConfigHookVariant1AppliesToEnum2" /> class.
        /// </summary>
        /// <param name="toolkits">
        /// Toolkit slugs
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolRouterSessionResponseConfigHookVariant1AppliesToEnum2(
            global::System.Collections.Generic.IList<string> toolkits)
        {
            this.Toolkits = toolkits ?? throw new global::System.ArgumentNullException(nameof(toolkits));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionResponseConfigHookVariant1AppliesToEnum2" /> class.
        /// </summary>
        public PostToolRouterSessionResponseConfigHookVariant1AppliesToEnum2()
        {
        }

    }
}