
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public enum DefaultAuthConfigUpdateType
    {
        /// <summary>
        /// 
        /// </summary>
        Default,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DefaultAuthConfigUpdateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DefaultAuthConfigUpdateType value)
        {
            return value switch
            {
                DefaultAuthConfigUpdateType.Default => "default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DefaultAuthConfigUpdateType? ToEnum(string value)
        {
            return value switch
            {
                "default" => DefaultAuthConfigUpdateType.Default,
                _ => null,
            };
        }
    }
}