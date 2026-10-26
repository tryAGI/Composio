
#nullable enable

namespace Composio
{
    /// <summary>
    /// Returned only when the session enables instant.return_instant_charge and a charge is available. Only set when the tool ran and its response was blocked.
    /// </summary>
    public sealed partial class ExecuteBlockedInstantCharge
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.ExecuteBlockedInstantChargeCurrencyJsonConverter))]
        public global::Composio.ExecuteBlockedInstantChargeCurrency Currency { get; set; }

        /// <summary>
        /// Entity charging for instant usage. Always composio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("charged_by")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.ExecuteBlockedInstantChargeChargedByJsonConverter))]
        public global::Composio.ExecuteBlockedInstantChargeChargedBy ChargedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteBlockedInstantCharge" /> class.
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
        public ExecuteBlockedInstantCharge(
            string amount,
            global::Composio.ExecuteBlockedInstantChargeCurrency currency,
            global::Composio.ExecuteBlockedInstantChargeChargedBy chargedBy)
        {
            this.Amount = amount ?? throw new global::System.ArgumentNullException(nameof(amount));
            this.Currency = currency;
            this.ChargedBy = chargedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExecuteBlockedInstantCharge" /> class.
        /// </summary>
        public ExecuteBlockedInstantCharge()
        {
        }

    }
}