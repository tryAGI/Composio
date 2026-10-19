
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum SessionHookVariant2HandlerVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        PromptInjection,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionHookVariant2HandlerVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionHookVariant2HandlerVariant2Type value)
        {
            return value switch
            {
                SessionHookVariant2HandlerVariant2Type.PromptInjection => "prompt_injection",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionHookVariant2HandlerVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "prompt_injection" => SessionHookVariant2HandlerVariant2Type.PromptInjection,
                _ => null,
            };
        }
    }
}