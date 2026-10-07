
#nullable enable

namespace Composio
{
    /// <summary>
    /// Currency of the instant charge. Always USD.
    /// </summary>
    public enum ToolRouterSessionExecuteCompletedInstantChargeCurrency
    {
        /// <summary>
        ///
        /// </summary>
        Usd,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolRouterSessionExecuteCompletedInstantChargeCurrencyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolRouterSessionExecuteCompletedInstantChargeCurrency value)
        {
            return value switch
            {
                ToolRouterSessionExecuteCompletedInstantChargeCurrency.Usd => "USD",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolRouterSessionExecuteCompletedInstantChargeCurrency? ToEnum(string value)
        {
            return value switch
            {
                "USD" => ToolRouterSessionExecuteCompletedInstantChargeCurrency.Usd,
                _ => null,
            };
        }
    }
}