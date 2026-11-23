
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PostToolRouterSessionResponseConfigHookVariant2HandlerVariant3Type
    {
        /// <summary>
        ///
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolRouterSessionResponseConfigHookVariant2HandlerVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionResponseConfigHookVariant2HandlerVariant3Type value)
        {
            return value switch
            {
                PostToolRouterSessionResponseConfigHookVariant2HandlerVariant3Type.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionResponseConfigHookVariant2HandlerVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "webhook" => PostToolRouterSessionResponseConfigHookVariant2HandlerVariant3Type.Webhook,
                _ => null,
            };
        }
    }
}