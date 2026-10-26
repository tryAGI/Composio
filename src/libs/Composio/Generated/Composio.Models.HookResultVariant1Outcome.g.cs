
#nullable enable

namespace Composio
{
    /// <summary>
    /// What the hook decided
    /// </summary>
    public enum HookResultVariant1Outcome
    {
        /// <summary>
        ///
        /// </summary>
        Block,
        /// <summary>
        ///
        /// </summary>
        Continue,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HookResultVariant1OutcomeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HookResultVariant1Outcome value)
        {
            return value switch
            {
                HookResultVariant1Outcome.Block => "block",
                HookResultVariant1Outcome.Continue => "continue",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HookResultVariant1Outcome? ToEnum(string value)
        {
            return value switch
            {
                "block" => HookResultVariant1Outcome.Block,
                "continue" => HookResultVariant1Outcome.Continue,
                _ => null,
            };
        }
    }
}