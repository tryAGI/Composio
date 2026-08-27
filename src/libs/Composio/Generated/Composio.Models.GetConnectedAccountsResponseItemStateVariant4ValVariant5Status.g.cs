
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum GetConnectedAccountsResponseItemStateVariant4ValVariant5Status
    {
        /// <summary>
        ///
        /// </summary>
        Expired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConnectedAccountsResponseItemStateVariant4ValVariant5StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsResponseItemStateVariant4ValVariant5Status value)
        {
            return value switch
            {
                GetConnectedAccountsResponseItemStateVariant4ValVariant5Status.Expired => "EXPIRED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsResponseItemStateVariant4ValVariant5Status? ToEnum(string value)
        {
            return value switch
            {
                "EXPIRED" => GetConnectedAccountsResponseItemStateVariant4ValVariant5Status.Expired,
                _ => null,
            };
        }
    }
}