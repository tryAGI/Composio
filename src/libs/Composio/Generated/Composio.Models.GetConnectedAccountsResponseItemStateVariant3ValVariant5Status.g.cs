
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum GetConnectedAccountsResponseItemStateVariant3ValVariant5Status
    {
        /// <summary>
        ///
        /// </summary>
        Revoked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConnectedAccountsResponseItemStateVariant3ValVariant5StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsResponseItemStateVariant3ValVariant5Status value)
        {
            return value switch
            {
                GetConnectedAccountsResponseItemStateVariant3ValVariant5Status.Revoked => "REVOKED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsResponseItemStateVariant3ValVariant5Status? ToEnum(string value)
        {
            return value switch
            {
                "REVOKED" => GetConnectedAccountsResponseItemStateVariant3ValVariant5Status.Revoked,
                _ => null,
            };
        }
    }
}