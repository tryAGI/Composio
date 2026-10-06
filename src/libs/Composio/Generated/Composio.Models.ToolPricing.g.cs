
#nullable enable

namespace Composio
{
    /// <summary>
    /// Published pricing for the tool
    /// </summary>
    public sealed partial class ToolPricing
    {
        /// <summary>
        /// Human-readable pricing description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Discount on top of provider charges.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discount")]
        public string? Discount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolPricing" /> class.
        /// </summary>
        /// <param name="description">
        /// Human-readable pricing description.
        /// </param>
        /// <param name="discount">
        /// Discount on top of provider charges.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolPricing(
            string? description,
            string? discount)
        {
            this.Description = description;
            this.Discount = discount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolPricing" /> class.
        /// </summary>
        public ToolPricing()
        {
        }

    }
}