
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum GetToolRouterSessionBySessionIdResponseConfigHookVariant1HandlerType
    {
        /// <summary>
        ///
        /// </summary>
        ConditionCheck,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetToolRouterSessionBySessionIdResponseConfigHookVariant1HandlerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetToolRouterSessionBySessionIdResponseConfigHookVariant1HandlerType value)
        {
            return value switch
            {
                GetToolRouterSessionBySessionIdResponseConfigHookVariant1HandlerType.ConditionCheck => "condition_check",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetToolRouterSessionBySessionIdResponseConfigHookVariant1HandlerType? ToEnum(string value)
        {
            return value switch
            {
                "condition_check" => GetToolRouterSessionBySessionIdResponseConfigHookVariant1HandlerType.ConditionCheck,
                _ => null,
            };
        }
    }
}