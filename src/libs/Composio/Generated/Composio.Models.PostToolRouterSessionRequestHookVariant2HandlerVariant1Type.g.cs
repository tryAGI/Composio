
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PostToolRouterSessionRequestHookVariant2HandlerVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        ConditionCheck,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolRouterSessionRequestHookVariant2HandlerVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionRequestHookVariant2HandlerVariant1Type value)
        {
            return value switch
            {
                PostToolRouterSessionRequestHookVariant2HandlerVariant1Type.ConditionCheck => "condition_check",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionRequestHookVariant2HandlerVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "condition_check" => PostToolRouterSessionRequestHookVariant2HandlerVariant1Type.ConditionCheck,
                _ => null,
            };
        }
    }
}