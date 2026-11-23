
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PostToolRouterSessionResponseConfigHookVariant1HandlerVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolRouterSessionResponseConfigHookVariant1HandlerVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionResponseConfigHookVariant1HandlerVariant2Type value)
        {
            return value switch
            {
                PostToolRouterSessionResponseConfigHookVariant1HandlerVariant2Type.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionResponseConfigHookVariant1HandlerVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "webhook" => PostToolRouterSessionResponseConfigHookVariant1HandlerVariant2Type.Webhook,
                _ => null,
            };
        }
    }
}