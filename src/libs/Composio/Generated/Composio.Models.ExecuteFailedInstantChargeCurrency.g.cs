
#nullable enable

namespace Composio
{
    /// <summary>
    /// Currency of the instant charge. Always USD.
    /// </summary>
    public enum ExecuteFailedInstantChargeCurrency
    {
        /// <summary>
        ///
        /// </summary>
        Usd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExecuteFailedInstantChargeCurrencyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExecuteFailedInstantChargeCurrency value)
        {
            return value switch
            {
                ExecuteFailedInstantChargeCurrency.Usd => "USD",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExecuteFailedInstantChargeCurrency? ToEnum(string value)
        {
            return value switch
            {
                "USD" => ExecuteFailedInstantChargeCurrency.Usd,
                _ => null,
            };
        }
    }
}