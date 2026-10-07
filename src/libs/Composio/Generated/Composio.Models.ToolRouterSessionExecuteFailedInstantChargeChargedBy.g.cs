
#nullable enable

namespace Composio
{
    /// <summary>
    /// Entity charging for instant usage. Always composio.
    /// </summary>
    public enum ToolRouterSessionExecuteFailedInstantChargeChargedBy
    {
        /// <summary>
        ///
        /// </summary>
        Composio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolRouterSessionExecuteFailedInstantChargeChargedByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolRouterSessionExecuteFailedInstantChargeChargedBy value)
        {
            return value switch
            {
                ToolRouterSessionExecuteFailedInstantChargeChargedBy.Composio => "composio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolRouterSessionExecuteFailedInstantChargeChargedBy? ToEnum(string value)
        {
            return value switch
            {
                "composio" => ToolRouterSessionExecuteFailedInstantChargeChargedBy.Composio,
                _ => null,
            };
        }
    }
}