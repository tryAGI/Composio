
#nullable enable

namespace Composio
{
    /// <summary>
    /// Returned only when the session enables instant.return_instant_charge and a charge is available. Failed individual tool calls omit it. Multi-execute returns one aggregate of reported charges from eligible successful calls, even if another call fails.
    /// </summary>
    public sealed partial class ExecuteCompletedInstantCharge
    {
        /// <summary>
        /// Instant charge in USD as an exact non-negative decimal string, with up to 12 fractional digits.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Amount { get; set; }

        /// <summary>
        /// Currency of the instant charge. Always USD.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.ExecuteCompletedInstantChargeCurrencyJsonConverter))]
        public global::Composio.ExecuteCompletedInstantChargeCurrency Currency { get; set; }

        /// <summary>
        /// Entity charging for instant usage. Always composio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("charged_by")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.ExecuteCompletedInstantChargeChargedByJsonConverter))]
        public global::Composio.ExecuteCompletedInstantChargeChargedBy ChargedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteCompletedInstantCharge" /> class.
        /// </summary>
        /// <param name="amount">
        /// Instant charge in USD as an exact non-negative decimal string, with up to 12 fractional digits.
        /// </param>
        /// <param name="currency">
        /// Currency of the instant charge. Always USD.
        /// </param>
        /// <param name="chargedBy">
        /// Entity charging for instant usage. Always composio.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExecuteCompletedInstantCharge(
            string amount,
            global::Composio.ExecuteCompletedInstantChargeCurrency currency,
            global::Composio.ExecuteCompletedInstantChargeChargedBy chargedBy)
        {
            this.Amount = amount ?? throw new global::System.ArgumentNullException(nameof(amount));
            this.Currency = currency;
            this.ChargedBy = chargedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteCompletedInstantCharge" /> class.
        /// </summary>
        public ExecuteCompletedInstantCharge()
        {
        }

    }
}