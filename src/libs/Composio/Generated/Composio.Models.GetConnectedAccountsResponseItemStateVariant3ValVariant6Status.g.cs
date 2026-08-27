
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum GetConnectedAccountsResponseItemStateVariant3ValVariant6Status
    {
        /// <summary>
        ///
        /// </summary>
        Expired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConnectedAccountsResponseItemStateVariant3ValVariant6StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsResponseItemStateVariant3ValVariant6Status value)
        {
            return value switch
            {
                GetConnectedAccountsResponseItemStateVariant3ValVariant6Status.Expired => "EXPIRED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsResponseItemStateVariant3ValVariant6Status? ToEnum(string value)
        {
            return value switch
            {
                "EXPIRED" => GetConnectedAccountsResponseItemStateVariant3ValVariant6Status.Expired,
                _ => null,
            };
        }
    }
}