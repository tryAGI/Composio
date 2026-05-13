
#nullable enable

namespace Composio
{
    /// <summary>
    /// Sharing model for the connected account when has_active_connection is true. PRIVATE is owner-only; SHARED is reachable only when explicitly pinned to the session.
    /// </summary>
    public enum PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccountType
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
    public static class PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccountTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccountType value)
        {
            return value switch
            {
                PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccountType.Private => "PRIVATE",
                PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccountType.Shared => "SHARED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccountType? ToEnum(string value)
        {
            return value switch
            {
                "PRIVATE" => PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccountType.Private,
                "SHARED" => PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccountType.Shared,
                _ => null,
            };
        }
    }
}