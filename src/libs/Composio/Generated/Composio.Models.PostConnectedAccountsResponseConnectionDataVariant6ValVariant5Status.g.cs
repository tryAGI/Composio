
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostConnectedAccountsResponseConnectionDataVariant6ValVariant5Status
    {
        /// <summary>
        /// 
        /// </summary>
        Expired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostConnectedAccountsResponseConnectionDataVariant6ValVariant5StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostConnectedAccountsResponseConnectionDataVariant6ValVariant5Status value)
        {
            return value switch
            {
                PostConnectedAccountsResponseConnectionDataVariant6ValVariant5Status.Expired => "EXPIRED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostConnectedAccountsResponseConnectionDataVariant6ValVariant5Status? ToEnum(string value)
        {
            return value switch
            {
                "EXPIRED" => PostConnectedAccountsResponseConnectionDataVariant6ValVariant5Status.Expired,
                _ => null,
            };
        }
    }
}