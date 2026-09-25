
#nullable enable

namespace Composio
{
    /// <summary>
    /// Currency of the premium charge. Always USD.
    /// </summary>
    public enum PostToolRouterSessionBySessionIdExecuteResponsePremiumChargeCurrency
    {
        /// <summary>
        ///
        /// </summary>
        Usd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolRouterSessionBySessionIdExecuteResponsePremiumChargeCurrencyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionBySessionIdExecuteResponsePremiumChargeCurrency value)
        {
            return value switch
            {
                PostToolRouterSessionBySessionIdExecuteResponsePremiumChargeCurrency.Usd => "USD",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionBySessionIdExecuteResponsePremiumChargeCurrency? ToEnum(string value)
        {
            return value switch
            {
                "USD" => PostToolRouterSessionBySessionIdExecuteResponsePremiumChargeCurrency.Usd,
                _ => null,
            };
        }
    }
}