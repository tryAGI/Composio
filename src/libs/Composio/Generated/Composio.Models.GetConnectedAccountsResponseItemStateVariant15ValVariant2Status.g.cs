
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum GetConnectedAccountsResponseItemStateVariant15ValVariant2Status
    {
        /// <summary>
        ///
        /// </summary>
        Initiated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConnectedAccountsResponseItemStateVariant15ValVariant2StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsResponseItemStateVariant15ValVariant2Status value)
        {
            return value switch
            {
                GetConnectedAccountsResponseItemStateVariant15ValVariant2Status.Initiated => "INITIATED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsResponseItemStateVariant15ValVariant2Status? ToEnum(string value)
        {
            return value switch
            {
                "INITIATED" => GetConnectedAccountsResponseItemStateVariant15ValVariant2Status.Initiated,
                _ => null,
            };
        }
    }
}