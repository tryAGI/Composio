
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PostToolRouterSessionRequestHookVariant2AppliesToEnum
    {
        /// <summary>
        ///
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolRouterSessionRequestHookVariant2AppliesToEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionRequestHookVariant2AppliesToEnum value)
        {
            return value switch
            {
                PostToolRouterSessionRequestHookVariant2AppliesToEnum.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionRequestHookVariant2AppliesToEnum? ToEnum(string value)
        {
            return value switch
            {
                "all" => PostToolRouterSessionRequestHookVariant2AppliesToEnum.All,
                _ => null,
            };
        }
    }
}