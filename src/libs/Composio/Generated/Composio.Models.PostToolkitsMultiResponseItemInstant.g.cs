
#nullable enable

namespace Composio
{
    /// <summary>
    /// Present when the latest version of this toolkit supports Instant accounts. See the tools endpoint for support on individual tools.
    /// </summary>
    public sealed partial class PostToolkitsMultiResponseItemInstant
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Supported { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolkitsMultiResponseItemInstant" /> class.
        /// </summary>
        /// <param name="supported"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolkitsMultiResponseItemInstant(
            bool supported)
        {
            this.Supported = supported;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolkitsMultiResponseItemInstant" /> class.
        /// </summary>
        public PostToolkitsMultiResponseItemInstant()
        {
        }

    }
}