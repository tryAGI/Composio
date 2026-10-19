
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum HookResultVariant1Status
    {
        /// <summary>
        ///
        /// </summary>
        Evaluated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HookResultVariant1StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HookResultVariant1Status value)
        {
            return value switch
            {
                HookResultVariant1Status.Evaluated => "evaluated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HookResultVariant1Status? ToEnum(string value)
        {
            return value switch
            {
                "evaluated" => HookResultVariant1Status.Evaluated,
                _ => null,
            };
        }
    }
}