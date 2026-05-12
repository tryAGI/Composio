
#nullable enable

namespace Composio
{
    /// <summary>
    /// Sharing model for this connected account. PRIVATE is usable only by the owning user_id. SHARED is reachable from a tool-router session only when explicitly pinned in the session config.
    /// </summary>
    public enum PostToolRouterSessionBySessionIdLinkResponseExperimentalAccountType
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
    public static class PostToolRouterSessionBySessionIdLinkResponseExperimentalAccountTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionBySessionIdLinkResponseExperimentalAccountType value)
        {
            return value switch
            {
                PostToolRouterSessionBySessionIdLinkResponseExperimentalAccountType.Private => "PRIVATE",
                PostToolRouterSessionBySessionIdLinkResponseExperimentalAccountType.Shared => "SHARED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionBySessionIdLinkResponseExperimentalAccountType? ToEnum(string value)
        {
            return value switch
            {
                "PRIVATE" => PostToolRouterSessionBySessionIdLinkResponseExperimentalAccountType.Private,
                "SHARED" => PostToolRouterSessionBySessionIdLinkResponseExperimentalAccountType.Shared,
                _ => null,
            };
        }
    }
}