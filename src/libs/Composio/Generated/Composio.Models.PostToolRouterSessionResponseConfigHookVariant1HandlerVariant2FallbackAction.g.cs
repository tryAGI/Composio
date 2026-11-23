
#nullable enable

namespace Composio
{
    /// <summary>
    /// What happens to the call when your endpoint times out, can't be reached, or sends an answer that can't be read.
    /// </summary>
    public enum PostToolRouterSessionResponseConfigHookVariant1HandlerVariant2FallbackAction
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
    public static class PostToolRouterSessionResponseConfigHookVariant1HandlerVariant2FallbackActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionResponseConfigHookVariant1HandlerVariant2FallbackAction value)
        {
            return value switch
            {
                PostToolRouterSessionResponseConfigHookVariant1HandlerVariant2FallbackAction.Block => "block",
                PostToolRouterSessionResponseConfigHookVariant1HandlerVariant2FallbackAction.Continue => "continue",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionResponseConfigHookVariant1HandlerVariant2FallbackAction? ToEnum(string value)
        {
            return value switch
            {
                "block" => PostToolRouterSessionResponseConfigHookVariant1HandlerVariant2FallbackAction.Block,
                "continue" => PostToolRouterSessionResponseConfigHookVariant1HandlerVariant2FallbackAction.Continue,
                _ => null,
            };
        }
    }
}