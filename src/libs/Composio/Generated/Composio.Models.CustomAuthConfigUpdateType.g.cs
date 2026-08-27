
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum CustomAuthConfigUpdateType
    {
        /// <summary>
        ///
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomAuthConfigUpdateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomAuthConfigUpdateType value)
        {
            return value switch
            {
                CustomAuthConfigUpdateType.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomAuthConfigUpdateType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => CustomAuthConfigUpdateType.Custom,
                _ => null,
            };
        }
    }
}