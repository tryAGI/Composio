
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PostConnectedAccountsRequestConnectionStateVariant15ValVariant4Status
    {
        /// <summary>
        ///
        /// </summary>
        Inactive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostConnectedAccountsRequestConnectionStateVariant15ValVariant4StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostConnectedAccountsRequestConnectionStateVariant15ValVariant4Status value)
        {
            return value switch
            {
                PostConnectedAccountsRequestConnectionStateVariant15ValVariant4Status.Inactive => "INACTIVE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostConnectedAccountsRequestConnectionStateVariant15ValVariant4Status? ToEnum(string value)
        {
            return value switch
            {
                "INACTIVE" => PostConnectedAccountsRequestConnectionStateVariant15ValVariant4Status.Inactive,
                _ => null,
            };
        }
    }
}