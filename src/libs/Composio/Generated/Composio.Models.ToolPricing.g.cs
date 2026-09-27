
#nullable enable

namespace Composio
{
    /// <summary>
    /// Current published pricing, independent of the requested tool version. Omitted when unspecified; absence does not mean free.
    /// </summary>
    public sealed partial class ToolPricing
    {
        /// <summary>
        /// Human-readable pricing description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Display text for the minimum price.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min")]
        public string? Min { get; set; }

        /// <summary>
        /// Display text for the maximum price.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max")]
        public string? Max { get; set; }

        /// <summary>
        /// Human-readable discount text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discount")]
        public string? Discount { get; set; }

        /// <summary>
        /// Pricing unit, such as per call or per second.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item")]
        public string? Item { get; set; }

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
        /// <param name="min">
        /// Display text for the minimum price.
        /// </param>
        /// <param name="max">
        /// Display text for the maximum price.
        /// </param>
        /// <param name="discount">
        /// Human-readable discount text.
        /// </param>
        /// <param name="item">
        /// Pricing unit, such as per call or per second.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolPricing(
            string? description,
            string? min,
            string? max,
            string? discount,
            string? item)
        {
            this.Description = description;
            this.Min = min;
            this.Max = max;
            this.Discount = discount;
            this.Item = item;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolPricing" /> class.
        /// </summary>
        public ToolPricing()
        {
        }

    }
}