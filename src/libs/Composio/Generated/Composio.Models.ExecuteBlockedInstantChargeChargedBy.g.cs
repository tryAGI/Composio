
#nullable enable

namespace Composio
{
    /// <summary>
    /// Entity charging for instant usage. Always composio.
    /// </summary>
    public enum ExecuteBlockedInstantChargeChargedBy
    {
        /// <summary>
        ///
        /// </summary>
        Composio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExecuteBlockedInstantChargeChargedByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExecuteBlockedInstantChargeChargedBy value)
        {
            return value switch
            {
                ExecuteBlockedInstantChargeChargedBy.Composio => "composio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExecuteBlockedInstantChargeChargedBy? ToEnum(string value)
        {
            return value switch
            {
                "composio" => ExecuteBlockedInstantChargeChargedBy.Composio,
                _ => null,
            };
        }
    }
}