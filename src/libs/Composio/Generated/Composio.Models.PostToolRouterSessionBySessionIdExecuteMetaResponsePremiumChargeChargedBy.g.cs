
#nullable enable

namespace Composio
{
    /// <summary>
    /// Entity charging for premium usage. Always composio.
    /// </summary>
    public enum PostToolRouterSessionBySessionIdExecuteMetaResponsePremiumChargeChargedBy
    {
        /// <summary>
        ///
        /// </summary>
        Composio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolRouterSessionBySessionIdExecuteMetaResponsePremiumChargeChargedByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionBySessionIdExecuteMetaResponsePremiumChargeChargedBy value)
        {
            return value switch
            {
                PostToolRouterSessionBySessionIdExecuteMetaResponsePremiumChargeChargedBy.Composio => "composio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionBySessionIdExecuteMetaResponsePremiumChargeChargedBy? ToEnum(string value)
        {
            return value switch
            {
                "composio" => PostToolRouterSessionBySessionIdExecuteMetaResponsePremiumChargeChargedBy.Composio,
                _ => null,
            };
        }
    }
}