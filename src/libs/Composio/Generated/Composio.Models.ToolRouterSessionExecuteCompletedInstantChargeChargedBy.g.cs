
#nullable enable

namespace Composio
{
    /// <summary>
    /// Entity charging for instant usage. Always composio.
    /// </summary>
    public enum ToolRouterSessionExecuteCompletedInstantChargeChargedBy
    {
        /// <summary>
        ///
        /// </summary>
        Composio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolRouterSessionExecuteCompletedInstantChargeChargedByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolRouterSessionExecuteCompletedInstantChargeChargedBy value)
        {
            return value switch
            {
                ToolRouterSessionExecuteCompletedInstantChargeChargedBy.Composio => "composio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolRouterSessionExecuteCompletedInstantChargeChargedBy? ToEnum(string value)
        {
            return value switch
            {
                "composio" => ToolRouterSessionExecuteCompletedInstantChargeChargedBy.Composio,
                _ => null,
            };
        }
    }
}