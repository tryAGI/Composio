
#nullable enable

namespace Composio
{
    /// <summary>
    /// What happens to the call when your endpoint times out, can't be reached, or sends an answer that can't be read.
    /// </summary>
    public enum GetToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant3FallbackAction
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
    public static class GetToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant3FallbackActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant3FallbackAction value)
        {
            return value switch
            {
                GetToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant3FallbackAction.Block => "block",
                GetToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant3FallbackAction.Continue => "continue",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant3FallbackAction? ToEnum(string value)
        {
            return value switch
            {
                "block" => GetToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant3FallbackAction.Block,
                "continue" => GetToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant3FallbackAction.Continue,
                _ => null,
            };
        }
    }
}