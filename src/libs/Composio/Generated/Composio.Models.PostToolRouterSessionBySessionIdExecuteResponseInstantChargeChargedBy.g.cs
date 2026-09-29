
#nullable enable

namespace Composio
{
    /// <summary>
    /// Entity charging for instant usage. Always composio.
    /// </summary>
    public enum PostToolRouterSessionBySessionIdExecuteResponseInstantChargeChargedBy
    {
        /// <summary>
        ///
        /// </summary>
        Composio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolRouterSessionBySessionIdExecuteResponseInstantChargeChargedByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionBySessionIdExecuteResponseInstantChargeChargedBy value)
        {
            return value switch
            {
                PostToolRouterSessionBySessionIdExecuteResponseInstantChargeChargedBy.Composio => "composio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionBySessionIdExecuteResponseInstantChargeChargedBy? ToEnum(string value)
        {
            return value switch
            {
                "composio" => PostToolRouterSessionBySessionIdExecuteResponseInstantChargeChargedBy.Composio,
                _ => null,
            };
        }
    }
}