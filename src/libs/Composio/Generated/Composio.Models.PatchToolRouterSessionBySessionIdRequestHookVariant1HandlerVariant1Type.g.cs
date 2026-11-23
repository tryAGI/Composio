
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchToolRouterSessionBySessionIdRequestHookVariant1HandlerVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        ConditionCheck,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchToolRouterSessionBySessionIdRequestHookVariant1HandlerVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchToolRouterSessionBySessionIdRequestHookVariant1HandlerVariant1Type value)
        {
            return value switch
            {
                PatchToolRouterSessionBySessionIdRequestHookVariant1HandlerVariant1Type.ConditionCheck => "condition_check",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchToolRouterSessionBySessionIdRequestHookVariant1HandlerVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "condition_check" => PatchToolRouterSessionBySessionIdRequestHookVariant1HandlerVariant1Type.ConditionCheck,
                _ => null,
            };
        }
    }
}