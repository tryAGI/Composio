
#nullable enable

namespace Composio
{
    /// <summary>
    /// Currency of the instant charge. Always USD.
    /// </summary>
    public enum ExecuteCompletedInstantChargeCurrency
    {
        /// <summary>
        ///
        /// </summary>
        Usd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExecuteCompletedInstantChargeCurrencyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExecuteCompletedInstantChargeCurrency value)
        {
            return value switch
            {
                ExecuteCompletedInstantChargeCurrency.Usd => "USD",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExecuteCompletedInstantChargeCurrency? ToEnum(string value)
        {
            return value switch
            {
                "USD" => ExecuteCompletedInstantChargeCurrency.Usd,
                _ => null,
            };
        }
    }
}