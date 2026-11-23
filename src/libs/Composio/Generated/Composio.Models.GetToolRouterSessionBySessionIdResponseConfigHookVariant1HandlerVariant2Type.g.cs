
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum GetToolRouterSessionBySessionIdResponseConfigHookVariant1HandlerVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetToolRouterSessionBySessionIdResponseConfigHookVariant1HandlerVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetToolRouterSessionBySessionIdResponseConfigHookVariant1HandlerVariant2Type value)
        {
            return value switch
            {
                GetToolRouterSessionBySessionIdResponseConfigHookVariant1HandlerVariant2Type.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetToolRouterSessionBySessionIdResponseConfigHookVariant1HandlerVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "webhook" => GetToolRouterSessionBySessionIdResponseConfigHookVariant1HandlerVariant2Type.Webhook,
                _ => null,
            };
        }
    }
}