
#nullable enable

namespace Composio
{
    /// <summary>
    /// What happens to the call when your endpoint times out, can't be reached, or sends an answer that can't be read.
    /// </summary>
    public enum PatchToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant3FallbackAction
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
    public static class PatchToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant3FallbackActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant3FallbackAction value)
        {
            return value switch
            {
                PatchToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant3FallbackAction.Block => "block",
                PatchToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant3FallbackAction.Continue => "continue",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant3FallbackAction? ToEnum(string value)
        {
            return value switch
            {
                "block" => PatchToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant3FallbackAction.Block,
                "continue" => PatchToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant3FallbackAction.Continue,
                _ => null,
            };
        }
    }
}