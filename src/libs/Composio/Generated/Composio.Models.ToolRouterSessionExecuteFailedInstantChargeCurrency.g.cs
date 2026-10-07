
#nullable enable

namespace Composio
{
    /// <summary>
    /// Currency of the instant charge. Always USD.
    /// </summary>
    public enum ToolRouterSessionExecuteFailedInstantChargeCurrency
    {
        /// <summary>
        ///
        /// </summary>
        Usd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolRouterSessionExecuteFailedInstantChargeCurrencyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolRouterSessionExecuteFailedInstantChargeCurrency value)
        {
            return value switch
            {
                ToolRouterSessionExecuteFailedInstantChargeCurrency.Usd => "USD",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolRouterSessionExecuteFailedInstantChargeCurrency? ToEnum(string value)
        {
            return value switch
            {
                "USD" => ToolRouterSessionExecuteFailedInstantChargeCurrency.Usd,
                _ => null,
            };
        }
    }
}