
#nullable enable

namespace Composio
{
    /// <summary>
    /// Entity charging for instant usage. Always composio.
    /// </summary>
    public enum ExecuteFailedInstantChargeChargedBy
    {
        /// <summary>
        ///
        /// </summary>
        Composio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExecuteFailedInstantChargeChargedByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExecuteFailedInstantChargeChargedBy value)
        {
            return value switch
            {
                ExecuteFailedInstantChargeChargedBy.Composio => "composio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExecuteFailedInstantChargeChargedBy? ToEnum(string value)
        {
            return value switch
            {
                "composio" => ExecuteFailedInstantChargeChargedBy.Composio,
                _ => null,
            };
        }
    }
}