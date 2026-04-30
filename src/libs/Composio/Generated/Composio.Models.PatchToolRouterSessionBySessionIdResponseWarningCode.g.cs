
#nullable enable

namespace Composio
{
    /// <summary>
    /// Stable machine code identifying the advisory. Safe to switch on in client code.<br/>
    /// Example: PRELOAD_TOOLS_HIGH_CONTEXT_USAGE
    /// </summary>
    public enum PatchToolRouterSessionBySessionIdResponseWarningCode
    {
        /// <summary>
        /// 
        /// </summary>
        PreloadToolsHighContextUsage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchToolRouterSessionBySessionIdResponseWarningCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchToolRouterSessionBySessionIdResponseWarningCode value)
        {
            return value switch
            {
                PatchToolRouterSessionBySessionIdResponseWarningCode.PreloadToolsHighContextUsage => "PRELOAD_TOOLS_HIGH_CONTEXT_USAGE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchToolRouterSessionBySessionIdResponseWarningCode? ToEnum(string value)
        {
            return value switch
            {
                "PRELOAD_TOOLS_HIGH_CONTEXT_USAGE" => PatchToolRouterSessionBySessionIdResponseWarningCode.PreloadToolsHighContextUsage,
                _ => null,
            };
        }
    }
}