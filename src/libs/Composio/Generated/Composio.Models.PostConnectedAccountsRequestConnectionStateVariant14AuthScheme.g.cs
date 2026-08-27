
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PostConnectedAccountsRequestConnectionStateVariant14AuthScheme
    {
        /// <summary>
        ///
        /// </summary>
        CimdOauth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostConnectedAccountsRequestConnectionStateVariant14AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostConnectedAccountsRequestConnectionStateVariant14AuthScheme value)
        {
            return value switch
            {
                PostConnectedAccountsRequestConnectionStateVariant14AuthScheme.CimdOauth => "CIMD_OAUTH",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostConnectedAccountsRequestConnectionStateVariant14AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "CIMD_OAUTH" => PostConnectedAccountsRequestConnectionStateVariant14AuthScheme.CimdOauth,
                _ => null,
            };
        }
    }
}