
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PostConnectedAccountsResponseConnectionDataVariant15ValVariant6Status
    {
        /// <summary>
        ///
        /// </summary>
        Expired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostConnectedAccountsResponseConnectionDataVariant15ValVariant6StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostConnectedAccountsResponseConnectionDataVariant15ValVariant6Status value)
        {
            return value switch
            {
                PostConnectedAccountsResponseConnectionDataVariant15ValVariant6Status.Expired => "EXPIRED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostConnectedAccountsResponseConnectionDataVariant15ValVariant6Status? ToEnum(string value)
        {
            return value switch
            {
                "EXPIRED" => PostConnectedAccountsResponseConnectionDataVariant15ValVariant6Status.Expired,
                _ => null,
            };
        }
    }
}