
#nullable enable

namespace Composio
{
    /// <summary>
    /// The hook could not be evaluated
    /// </summary>
    public enum HookResultVariant2Status
    {
        /// <summary>
        ///
        /// </summary>
        Unavailable,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HookResultVariant2StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HookResultVariant2Status value)
        {
            return value switch
            {
                HookResultVariant2Status.Unavailable => "unavailable",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HookResultVariant2Status? ToEnum(string value)
        {
            return value switch
            {
                "unavailable" => HookResultVariant2Status.Unavailable,
                _ => null,
            };
        }
    }
}