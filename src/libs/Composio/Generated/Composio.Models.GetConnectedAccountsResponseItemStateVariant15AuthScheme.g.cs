
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum GetConnectedAccountsResponseItemStateVariant15AuthScheme
    {
        /// <summary>
        ///
        /// </summary>
        S2sOauth2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConnectedAccountsResponseItemStateVariant15AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsResponseItemStateVariant15AuthScheme value)
        {
            return value switch
            {
                GetConnectedAccountsResponseItemStateVariant15AuthScheme.S2sOauth2 => "S2S_OAUTH2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsResponseItemStateVariant15AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "S2S_OAUTH2" => GetConnectedAccountsResponseItemStateVariant15AuthScheme.S2sOauth2,
                _ => null,
            };
        }
    }
}