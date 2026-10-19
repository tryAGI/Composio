
#nullable enable

namespace Composio
{
    /// <summary>
    /// Currency of the instant charge. Always USD.
    /// </summary>
    public enum ExecuteBlockedInstantChargeCurrency
    {
        /// <summary>
        ///
        /// </summary>
        Usd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExecuteBlockedInstantChargeCurrencyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExecuteBlockedInstantChargeCurrency value)
        {
            return value switch
            {
                ExecuteBlockedInstantChargeCurrency.Usd => "USD",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExecuteBlockedInstantChargeCurrency? ToEnum(string value)
        {
            return value switch
            {
                "USD" => ExecuteBlockedInstantChargeCurrency.Usd,
                _ => null,
            };
        }
    }
}