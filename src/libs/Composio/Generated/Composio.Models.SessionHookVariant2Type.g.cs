
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum SessionHookVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        AfterExecute,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionHookVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionHookVariant2Type value)
        {
            return value switch
            {
                SessionHookVariant2Type.AfterExecute => "after_execute",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionHookVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "after_execute" => SessionHookVariant2Type.AfterExecute,
                _ => null,
            };
        }
    }
}