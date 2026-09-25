
#nullable enable

namespace Composio
{
    /// <summary>
    /// Entity charging for premium usage. Always composio.
    /// </summary>
    public enum PostToolRouterSessionBySessionIdExecuteResponsePremiumChargeChargedBy
    {
        /// <summary>
        ///
        /// </summary>
        Composio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolRouterSessionBySessionIdExecuteResponsePremiumChargeChargedByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionBySessionIdExecuteResponsePremiumChargeChargedBy value)
        {
            return value switch
            {
                PostToolRouterSessionBySessionIdExecuteResponsePremiumChargeChargedBy.Composio => "composio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionBySessionIdExecuteResponsePremiumChargeChargedBy? ToEnum(string value)
        {
            return value switch
            {
                "composio" => PostToolRouterSessionBySessionIdExecuteResponsePremiumChargeChargedBy.Composio,
                _ => null,
            };
        }
    }
}