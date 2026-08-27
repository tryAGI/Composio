
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum GetConnectedAccountsResponseItemStateVariant2ValVariant7Status
    {
        /// <summary>
        ///
        /// </summary>
        Revoked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConnectedAccountsResponseItemStateVariant2ValVariant7StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsResponseItemStateVariant2ValVariant7Status value)
        {
            return value switch
            {
                GetConnectedAccountsResponseItemStateVariant2ValVariant7Status.Revoked => "REVOKED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsResponseItemStateVariant2ValVariant7Status? ToEnum(string value)
        {
            return value switch
            {
                "REVOKED" => GetConnectedAccountsResponseItemStateVariant2ValVariant7Status.Revoked,
                _ => null,
            };
        }
    }
}