
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum SessionHookVariant2HandlerVariant1OnMatch
    {
        /// <summary>
        ///
        /// </summary>
        Block,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionHookVariant2HandlerVariant1OnMatchExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionHookVariant2HandlerVariant1OnMatch value)
        {
            return value switch
            {
                SessionHookVariant2HandlerVariant1OnMatch.Block => "block",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionHookVariant2HandlerVariant1OnMatch? ToEnum(string value)
        {
            return value switch
            {
                "block" => SessionHookVariant2HandlerVariant1OnMatch.Block,
                _ => null,
            };
        }
    }
}