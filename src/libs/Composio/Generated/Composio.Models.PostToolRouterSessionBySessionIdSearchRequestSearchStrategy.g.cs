
#nullable enable

namespace Composio
{
    /// <summary>
    /// Search path to use. Defaults to auto. Use tool_search to bypass cached plans and run direct tool search.<br/>
    /// Example: tool_search
    /// </summary>
    public enum PostToolRouterSessionBySessionIdSearchRequestSearchStrategy
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        ToolSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolRouterSessionBySessionIdSearchRequestSearchStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionBySessionIdSearchRequestSearchStrategy value)
        {
            return value switch
            {
                PostToolRouterSessionBySessionIdSearchRequestSearchStrategy.Auto => "auto",
                PostToolRouterSessionBySessionIdSearchRequestSearchStrategy.ToolSearch => "tool_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionBySessionIdSearchRequestSearchStrategy? ToEnum(string value)
        {
            return value switch
            {
                "auto" => PostToolRouterSessionBySessionIdSearchRequestSearchStrategy.Auto,
                "tool_search" => PostToolRouterSessionBySessionIdSearchRequestSearchStrategy.ToolSearch,
                _ => null,
            };
        }
    }
}