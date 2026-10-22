
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum GetToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant2Action
    {
        /// <summary>
        ///
        /// </summary>
        Block,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant2ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant2Action value)
        {
            return value switch
            {
                GetToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant2Action.Block => "block",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant2Action? ToEnum(string value)
        {
            return value switch
            {
                "block" => GetToolRouterSessionBySessionIdResponseConfigHookVariant2HandlerVariant2Action.Block,
                _ => null,
            };
        }
    }
}