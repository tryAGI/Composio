
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PostToolRouterSessionRequestHookVariant1AppliesToEnum
    {
        /// <summary>
        ///
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolRouterSessionRequestHookVariant1AppliesToEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionRequestHookVariant1AppliesToEnum value)
        {
            return value switch
            {
                PostToolRouterSessionRequestHookVariant1AppliesToEnum.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionRequestHookVariant1AppliesToEnum? ToEnum(string value)
        {
            return value switch
            {
                "all" => PostToolRouterSessionRequestHookVariant1AppliesToEnum.All,
                _ => null,
            };
        }
    }
}