
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PostConnectedAccountsRequestConnectionStateVariant3ValVariant3Status
    {
        /// <summary>
        ///
        /// </summary>
        Active,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostConnectedAccountsRequestConnectionStateVariant3ValVariant3StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostConnectedAccountsRequestConnectionStateVariant3ValVariant3Status value)
        {
            return value switch
            {
                PostConnectedAccountsRequestConnectionStateVariant3ValVariant3Status.Active => "ACTIVE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostConnectedAccountsRequestConnectionStateVariant3ValVariant3Status? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => PostConnectedAccountsRequestConnectionStateVariant3ValVariant3Status.Active,
                _ => null,
            };
        }
    }
}