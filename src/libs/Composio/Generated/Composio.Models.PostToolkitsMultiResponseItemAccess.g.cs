
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PostToolkitsMultiResponseItemAccess
    {
        /// <summary>
        ///
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolkitsMultiResponseItemAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolkitsMultiResponseItemAccess value)
        {
            return value switch
            {
                PostToolkitsMultiResponseItemAccess.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolkitsMultiResponseItemAccess? ToEnum(string value)
        {
            return value switch
            {
                "all" => PostToolkitsMultiResponseItemAccess.All,
                _ => null,
            };
        }
    }
}