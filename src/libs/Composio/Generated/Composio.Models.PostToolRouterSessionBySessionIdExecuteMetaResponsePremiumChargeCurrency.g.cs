
#nullable enable

namespace Composio
{
    /// <summary>
    /// Currency of the premium charge. Always USD.
    /// </summary>
    public enum PostToolRouterSessionBySessionIdExecuteMetaResponsePremiumChargeCurrency
    {
        /// <summary>
        ///
        /// </summary>
        Usd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolRouterSessionBySessionIdExecuteMetaResponsePremiumChargeCurrencyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionBySessionIdExecuteMetaResponsePremiumChargeCurrency value)
        {
            return value switch
            {
                PostToolRouterSessionBySessionIdExecuteMetaResponsePremiumChargeCurrency.Usd => "USD",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionBySessionIdExecuteMetaResponsePremiumChargeCurrency? ToEnum(string value)
        {
            return value switch
            {
                "USD" => PostToolRouterSessionBySessionIdExecuteMetaResponsePremiumChargeCurrency.Usd,
                _ => null,
            };
        }
    }
}