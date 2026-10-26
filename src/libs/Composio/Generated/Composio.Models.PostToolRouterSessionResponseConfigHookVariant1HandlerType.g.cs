
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PostToolRouterSessionResponseConfigHookVariant1HandlerType
    {
        /// <summary>
        ///
        /// </summary>
        ConditionCheck,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolRouterSessionResponseConfigHookVariant1HandlerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionResponseConfigHookVariant1HandlerType value)
        {
            return value switch
            {
                PostToolRouterSessionResponseConfigHookVariant1HandlerType.ConditionCheck => "condition_check",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionResponseConfigHookVariant1HandlerType? ToEnum(string value)
        {
            return value switch
            {
                "condition_check" => PostToolRouterSessionResponseConfigHookVariant1HandlerType.ConditionCheck,
                _ => null,
            };
        }
    }
}