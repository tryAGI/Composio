
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchToolRouterSessionBySessionIdRequestHookVariant2HandlerVariant3Type
    {
        /// <summary>
        ///
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchToolRouterSessionBySessionIdRequestHookVariant2HandlerVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchToolRouterSessionBySessionIdRequestHookVariant2HandlerVariant3Type value)
        {
            return value switch
            {
                PatchToolRouterSessionBySessionIdRequestHookVariant2HandlerVariant3Type.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchToolRouterSessionBySessionIdRequestHookVariant2HandlerVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "webhook" => PatchToolRouterSessionBySessionIdRequestHookVariant2HandlerVariant3Type.Webhook,
                _ => null,
            };
        }
    }
}