
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum SessionHookVariant1HandlerAction
    {
        /// <summary>
        ///
        /// </summary>
        Block,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionHookVariant1HandlerActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionHookVariant1HandlerAction value)
        {
            return value switch
            {
                SessionHookVariant1HandlerAction.Block => "block",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionHookVariant1HandlerAction? ToEnum(string value)
        {
            return value switch
            {
                "block" => SessionHookVariant1HandlerAction.Block,
                _ => null,
            };
        }
    }
}