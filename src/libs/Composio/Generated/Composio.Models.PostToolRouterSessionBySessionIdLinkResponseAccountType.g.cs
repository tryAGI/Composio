
#nullable enable

namespace Composio
{
    /// <summary>
    /// PRIVATE (default) is usable only by the owning user_id. SHARED is reachable from a tool-router session ONLY when explicitly pinned, with at most one SHARED per toolkit per session.<br/>
    /// Example: PRIVATE
    /// </summary>
    public enum PostToolRouterSessionBySessionIdLinkResponseAccountType
    {
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Shared,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolRouterSessionBySessionIdLinkResponseAccountTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionBySessionIdLinkResponseAccountType value)
        {
            return value switch
            {
                PostToolRouterSessionBySessionIdLinkResponseAccountType.Private => "PRIVATE",
                PostToolRouterSessionBySessionIdLinkResponseAccountType.Shared => "SHARED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionBySessionIdLinkResponseAccountType? ToEnum(string value)
        {
            return value switch
            {
                "PRIVATE" => PostToolRouterSessionBySessionIdLinkResponseAccountType.Private,
                "SHARED" => PostToolRouterSessionBySessionIdLinkResponseAccountType.Shared,
                _ => null,
            };
        }
    }
}