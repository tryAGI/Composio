
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum SessionHookVariant1AppliesToEnum
    {
        /// <summary>
        ///
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionHookVariant1AppliesToEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionHookVariant1AppliesToEnum value)
        {
            return value switch
            {
                SessionHookVariant1AppliesToEnum.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionHookVariant1AppliesToEnum? ToEnum(string value)
        {
            return value switch
            {
                "all" => SessionHookVariant1AppliesToEnum.All,
                _ => null,
            };
        }
    }
}