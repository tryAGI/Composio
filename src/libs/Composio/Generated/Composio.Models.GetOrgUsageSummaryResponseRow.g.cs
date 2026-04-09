
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetOrgUsageSummaryResponseRow
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EntityType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Unit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_quantity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TotalQuantity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EventCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrgUsageSummaryResponseRow" /> class.
        /// </summary>
        /// <param name="entityType"></param>
        /// <param name="unit"></param>
        /// <param name="totalQuantity"></param>
        /// <param name="eventCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetOrgUsageSummaryResponseRow(
            string entityType,
            string unit,
            string totalQuantity,
            int eventCount)
        {
            this.EntityType = entityType ?? throw new global::System.ArgumentNullException(nameof(entityType));
            this.Unit = unit ?? throw new global::System.ArgumentNullException(nameof(unit));
            this.TotalQuantity = totalQuantity ?? throw new global::System.ArgumentNullException(nameof(totalQuantity));
            this.EventCount = eventCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetOrgUsageSummaryResponseRow" /> class.
        /// </summary>
        public GetOrgUsageSummaryResponseRow()
        {
        }
    }
}