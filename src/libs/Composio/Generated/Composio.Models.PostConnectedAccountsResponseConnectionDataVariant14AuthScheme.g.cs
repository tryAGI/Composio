
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostConnectedAccountsResponseConnectionDataVariant14AuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        CimdOauth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostConnectedAccountsResponseConnectionDataVariant14AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostConnectedAccountsResponseConnectionDataVariant14AuthScheme value)
        {
            return value switch
            {
                PostConnectedAccountsResponseConnectionDataVariant14AuthScheme.CimdOauth => "CIMD_OAUTH",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostConnectedAccountsResponseConnectionDataVariant14AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "CIMD_OAUTH" => PostConnectedAccountsResponseConnectionDataVariant14AuthScheme.CimdOauth,
                _ => null,
            };
        }
    }
}