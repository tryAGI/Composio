
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum SessionHookVariant2AppliesToEnum
    {
        /// <summary>
        ///
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionHookVariant2AppliesToEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionHookVariant2AppliesToEnum value)
        {
            return value switch
            {
                SessionHookVariant2AppliesToEnum.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionHookVariant2AppliesToEnum? ToEnum(string value)
        {
            return value switch
            {
                "all" => SessionHookVariant2AppliesToEnum.All,
                _ => null,
            };
        }
    }
}