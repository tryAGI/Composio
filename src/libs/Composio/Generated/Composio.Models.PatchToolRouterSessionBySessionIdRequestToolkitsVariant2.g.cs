
#nullable enable

namespace Composio
{
    /// <summary>
    /// Disable specific toolkits (denylist)
    /// </summary>
    public sealed partial class PatchToolRouterSessionBySessionIdRequestToolkitsVariant2
    {
        /// <summary>
        /// These specific toolkits will be disabled<br/>
        /// Example: [gmail, slack]
        /// </summary>
        /// <example>[gmail, slack]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Disable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchToolRouterSessionBySessionIdRequestToolkitsVariant2" /> class.
        /// </summary>
        /// <param name="disable">
        /// These specific toolkits will be disabled<br/>
        /// Example: [gmail, slack]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchToolRouterSessionBySessionIdRequestToolkitsVariant2(
            global::System.Collections.Generic.IList<string> disable)
        {
            this.Disable = disable ?? throw new global::System.ArgumentNullException(nameof(disable));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchToolRouterSessionBySessionIdRequestToolkitsVariant2" /> class.
        /// </summary>
        public PatchToolRouterSessionBySessionIdRequestToolkitsVariant2()
        {
        }

    }
}