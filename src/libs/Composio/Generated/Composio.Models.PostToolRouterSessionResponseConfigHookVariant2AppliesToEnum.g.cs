
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PostToolRouterSessionResponseConfigHookVariant2AppliesToEnum
    {
        /// <summary>
        ///
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolRouterSessionResponseConfigHookVariant2AppliesToEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionResponseConfigHookVariant2AppliesToEnum value)
        {
            return value switch
            {
                PostToolRouterSessionResponseConfigHookVariant2AppliesToEnum.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionResponseConfigHookVariant2AppliesToEnum? ToEnum(string value)
        {
            return value switch
            {
                "all" => PostToolRouterSessionResponseConfigHookVariant2AppliesToEnum.All,
                _ => null,
            };
        }
    }
}