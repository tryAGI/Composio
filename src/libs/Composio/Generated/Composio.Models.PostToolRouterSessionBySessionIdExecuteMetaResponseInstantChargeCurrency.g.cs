
#nullable enable

namespace Composio
{
    /// <summary>
    /// Currency of the instant charge. Always USD.
    /// </summary>
    public enum PostToolRouterSessionBySessionIdExecuteMetaResponseInstantChargeCurrency
    {
        /// <summary>
        ///
        /// </summary>
        Usd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolRouterSessionBySessionIdExecuteMetaResponseInstantChargeCurrencyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionBySessionIdExecuteMetaResponseInstantChargeCurrency value)
        {
            return value switch
            {
                PostToolRouterSessionBySessionIdExecuteMetaResponseInstantChargeCurrency.Usd => "USD",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionBySessionIdExecuteMetaResponseInstantChargeCurrency? ToEnum(string value)
        {
            return value switch
            {
                "USD" => PostToolRouterSessionBySessionIdExecuteMetaResponseInstantChargeCurrency.Usd,
                _ => null,
            };
        }
    }
}