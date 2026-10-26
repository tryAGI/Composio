
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchToolRouterSessionBySessionIdResponseConfigHookVariant1HandlerType
    {
        /// <summary>
        ///
        /// </summary>
        ConditionCheck,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchToolRouterSessionBySessionIdResponseConfigHookVariant1HandlerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchToolRouterSessionBySessionIdResponseConfigHookVariant1HandlerType value)
        {
            return value switch
            {
                PatchToolRouterSessionBySessionIdResponseConfigHookVariant1HandlerType.ConditionCheck => "condition_check",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchToolRouterSessionBySessionIdResponseConfigHookVariant1HandlerType? ToEnum(string value)
        {
            return value switch
            {
                "condition_check" => PatchToolRouterSessionBySessionIdResponseConfigHookVariant1HandlerType.ConditionCheck,
                _ => null,
            };
        }
    }
}