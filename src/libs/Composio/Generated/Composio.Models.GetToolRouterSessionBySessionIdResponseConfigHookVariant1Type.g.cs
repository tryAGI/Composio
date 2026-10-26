
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum GetToolRouterSessionBySessionIdResponseConfigHookVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        BeforeExecute,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetToolRouterSessionBySessionIdResponseConfigHookVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetToolRouterSessionBySessionIdResponseConfigHookVariant1Type value)
        {
            return value switch
            {
                GetToolRouterSessionBySessionIdResponseConfigHookVariant1Type.BeforeExecute => "before_execute",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetToolRouterSessionBySessionIdResponseConfigHookVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "before_execute" => GetToolRouterSessionBySessionIdResponseConfigHookVariant1Type.BeforeExecute,
                _ => null,
            };
        }
    }
}