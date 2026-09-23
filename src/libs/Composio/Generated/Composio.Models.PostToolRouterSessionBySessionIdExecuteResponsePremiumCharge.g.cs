
#nullable enable

namespace Composio
{
    /// <summary>
    /// Returned only when the session enables premium_usage.return_premium_charge and a charge is available. Failed individual tool calls omit it. Multi-execute returns one aggregate of reported charges from eligible successful calls, even if another call fails.
    /// </summary>
    public sealed partial class PostToolRouterSessionBySessionIdExecuteResponsePremiumCharge
    {
        /// <summary>
        /// Premium charge in USD as an exact non-negative decimal string, with up to 12 fractional digits.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Amount { get; set; }

        /// <summary>
        /// Currency of the premium charge. Always USD.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PostToolRouterSessionBySessionIdExecuteResponsePremiumChargeCurrencyJsonConverter))]
        public global::Composio.PostToolRouterSessionBySessionIdExecuteResponsePremiumChargeCurrency Currency { get; set; }

        /// <summary>
        /// Entity charging for premium usage. Always composio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("charged_by")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PostToolRouterSessionBySessionIdExecuteResponsePremiumChargeChargedByJsonConverter))]
        public global::Composio.PostToolRouterSessionBySessionIdExecuteResponsePremiumChargeChargedBy ChargedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdExecuteResponsePremiumCharge" /> class.
        /// </summary>
        /// <param name="amount">
        /// Premium charge in USD as an exact non-negative decimal string, with up to 12 fractional digits.
        /// </param>
        /// <param name="currency">
        /// Currency of the premium charge. Always USD.
        /// </param>
        /// <param name="chargedBy">
        /// Entity charging for premium usage. Always composio.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolRouterSessionBySessionIdExecuteResponsePremiumCharge(
            string amount,
            global::Composio.PostToolRouterSessionBySessionIdExecuteResponsePremiumChargeCurrency currency,
            global::Composio.PostToolRouterSessionBySessionIdExecuteResponsePremiumChargeChargedBy chargedBy)
        {
            this.Amount = amount ?? throw new global::System.ArgumentNullException(nameof(amount));
            this.Currency = currency;
            this.ChargedBy = chargedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdExecuteResponsePremiumCharge" /> class.
        /// </summary>
        public PostToolRouterSessionBySessionIdExecuteResponsePremiumCharge()
        {
        }

    }
}