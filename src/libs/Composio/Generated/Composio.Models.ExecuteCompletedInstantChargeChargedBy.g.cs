
#nullable enable

namespace Composio
{
    /// <summary>
    /// Entity charging for instant usage. Always composio.
    /// </summary>
    public enum ExecuteCompletedInstantChargeChargedBy
    {
        /// <summary>
        ///
        /// </summary>
        Composio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExecuteCompletedInstantChargeChargedByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExecuteCompletedInstantChargeChargedBy value)
        {
            return value switch
            {
                ExecuteCompletedInstantChargeChargedBy.Composio => "composio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExecuteCompletedInstantChargeChargedBy? ToEnum(string value)
        {
            return value switch
            {
                "composio" => ExecuteCompletedInstantChargeChargedBy.Composio,
                _ => null,
            };
        }
    }
}