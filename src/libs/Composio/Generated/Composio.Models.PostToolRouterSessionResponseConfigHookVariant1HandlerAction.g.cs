
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PostToolRouterSessionResponseConfigHookVariant1HandlerAction
    {
        /// <summary>
        ///
        /// </summary>
        Block,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolRouterSessionResponseConfigHookVariant1HandlerActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionResponseConfigHookVariant1HandlerAction value)
        {
            return value switch
            {
                PostToolRouterSessionResponseConfigHookVariant1HandlerAction.Block => "block",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionResponseConfigHookVariant1HandlerAction? ToEnum(string value)
        {
            return value switch
            {
                "block" => PostToolRouterSessionResponseConfigHookVariant1HandlerAction.Block,
                _ => null,
            };
        }
    }
}