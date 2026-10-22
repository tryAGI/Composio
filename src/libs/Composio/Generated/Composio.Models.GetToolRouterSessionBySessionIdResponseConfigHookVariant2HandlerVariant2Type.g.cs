
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum GetToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        PromptInjectionCheck,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant2Type value)
        {
            return value switch
            {
                GetToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant2Type.PromptInjectionCheck => "prompt_injection_check",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "prompt_injection_check" => GetToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant2Type.PromptInjectionCheck,
                _ => null,
            };
        }
    }
}