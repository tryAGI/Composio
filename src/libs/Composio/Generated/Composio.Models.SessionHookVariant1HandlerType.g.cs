
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum SessionHookVariant1HandlerType
    {
        /// <summary>
        ///
        /// </summary>
        Prompt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionHookVariant1HandlerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionHookVariant1HandlerType value)
        {
            return value switch
            {
                SessionHookVariant1HandlerType.Prompt => "prompt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionHookVariant1HandlerType? ToEnum(string value)
        {
            return value switch
            {
                "prompt" => SessionHookVariant1HandlerType.Prompt,
                _ => null,
            };
        }
    }
}