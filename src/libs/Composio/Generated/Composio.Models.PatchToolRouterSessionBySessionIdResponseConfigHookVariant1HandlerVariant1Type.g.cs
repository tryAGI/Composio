
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchToolRouterSessionBySessionIdResponseConfigHookVariant1HandlerVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        ConditionCheck,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchToolRouterSessionBySessionIdResponseConfigHookVariant1HandlerVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchToolRouterSessionBySessionIdResponseConfigHookVariant1HandlerVariant1Type value)
        {
            return value switch
            {
                PatchToolRouterSessionBySessionIdResponseConfigHookVariant1HandlerVariant1Type.ConditionCheck => "condition_check",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchToolRouterSessionBySessionIdResponseConfigHookVariant1HandlerVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "condition_check" => PatchToolRouterSessionBySessionIdResponseConfigHookVariant1HandlerVariant1Type.ConditionCheck,
                _ => null,
            };
        }
    }
}