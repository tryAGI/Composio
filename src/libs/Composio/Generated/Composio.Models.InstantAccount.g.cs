
#nullable enable

namespace Composio
{
    /// <summary>
    /// Present only when the tool supports an Instant account and its selected toolkit version is the latest. Missing for older toolkit versions or ineligible tools.
    /// </summary>
    public sealed partial class InstantAccount
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Supported { get; set; }

        /// <summary>
        /// Published pricing from the selected tool row, unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price")]
        public global::System.Collections.Generic.Dictionary<string, object?>? Price { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InstantAccount" /> class.
        /// </summary>
        /// <param name="supported"></param>
        /// <param name="price">
        /// Published pricing from the selected tool row, unchanged.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InstantAccount(
            bool supported,
            global::System.Collections.Generic.Dictionary<string, object?>? price)
        {
            this.Supported = supported;
            this.Price = price;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstantAccount" /> class.
        /// </summary>
        public InstantAccount()
        {
        }

    }
}