
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchToolRouterSessionBySessionIdResponseConfigHookVariant1HandlerAction
    {
        /// <summary>
        ///
        /// </summary>
        Block,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchToolRouterSessionBySessionIdResponseConfigHookVariant1HandlerActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchToolRouterSessionBySessionIdResponseConfigHookVariant1HandlerAction value)
        {
            return value switch
            {
                PatchToolRouterSessionBySessionIdResponseConfigHookVariant1HandlerAction.Block => "block",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchToolRouterSessionBySessionIdResponseConfigHookVariant1HandlerAction? ToEnum(string value)
        {
            return value switch
            {
                "block" => PatchToolRouterSessionBySessionIdResponseConfigHookVariant1HandlerAction.Block,
                _ => null,
            };
        }
    }
}