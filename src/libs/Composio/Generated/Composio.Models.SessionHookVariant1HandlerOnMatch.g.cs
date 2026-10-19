
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum SessionHookVariant1HandlerOnMatch
    {
        /// <summary>
        ///
        /// </summary>
        Block,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionHookVariant1HandlerOnMatchExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionHookVariant1HandlerOnMatch value)
        {
            return value switch
            {
                SessionHookVariant1HandlerOnMatch.Block => "block",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionHookVariant1HandlerOnMatch? ToEnum(string value)
        {
            return value switch
            {
                "block" => SessionHookVariant1HandlerOnMatch.Block,
                _ => null,
            };
        }
    }
}