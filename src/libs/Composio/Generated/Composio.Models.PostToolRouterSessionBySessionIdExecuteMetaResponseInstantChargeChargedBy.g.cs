
#nullable enable

namespace Composio
{
    /// <summary>
    /// Entity charging for instant usage. Always composio.
    /// </summary>
    public enum PostToolRouterSessionBySessionIdExecuteMetaResponseInstantChargeChargedBy
    {
        /// <summary>
        ///
        /// </summary>
        Composio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolRouterSessionBySessionIdExecuteMetaResponseInstantChargeChargedByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionBySessionIdExecuteMetaResponseInstantChargeChargedBy value)
        {
            return value switch
            {
                PostToolRouterSessionBySessionIdExecuteMetaResponseInstantChargeChargedBy.Composio => "composio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionBySessionIdExecuteMetaResponseInstantChargeChargedBy? ToEnum(string value)
        {
            return value switch
            {
                "composio" => PostToolRouterSessionBySessionIdExecuteMetaResponseInstantChargeChargedBy.Composio,
                _ => null,
            };
        }
    }
}