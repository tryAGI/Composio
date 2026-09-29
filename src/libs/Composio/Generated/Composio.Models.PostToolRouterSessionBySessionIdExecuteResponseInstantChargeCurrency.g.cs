
#nullable enable

namespace Composio
{
    /// <summary>
    /// Currency of the instant charge. Always USD.
    /// </summary>
    public enum PostToolRouterSessionBySessionIdExecuteResponseInstantChargeCurrency
    {
        /// <summary>
        ///
        /// </summary>
        Usd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolRouterSessionBySessionIdExecuteResponseInstantChargeCurrencyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionBySessionIdExecuteResponseInstantChargeCurrency value)
        {
            return value switch
            {
                PostToolRouterSessionBySessionIdExecuteResponseInstantChargeCurrency.Usd => "USD",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionBySessionIdExecuteResponseInstantChargeCurrency? ToEnum(string value)
        {
            return value switch
            {
                "USD" => PostToolRouterSessionBySessionIdExecuteResponseInstantChargeCurrency.Usd,
                _ => null,
            };
        }
    }
}