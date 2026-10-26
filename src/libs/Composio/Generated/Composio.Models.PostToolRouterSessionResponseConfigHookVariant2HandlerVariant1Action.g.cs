
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PostToolRouterSessionResponseConfigHookVariant2HandlerVariant1Action
    {
        /// <summary>
        ///
        /// </summary>
        Block,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolRouterSessionResponseConfigHookVariant2HandlerVariant1ActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionResponseConfigHookVariant2HandlerVariant1Action value)
        {
            return value switch
            {
                PostToolRouterSessionResponseConfigHookVariant2HandlerVariant1Action.Block => "block",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionResponseConfigHookVariant2HandlerVariant1Action? ToEnum(string value)
        {
            return value switch
            {
                "block" => PostToolRouterSessionResponseConfigHookVariant2HandlerVariant1Action.Block,
                _ => null,
            };
        }
    }
}