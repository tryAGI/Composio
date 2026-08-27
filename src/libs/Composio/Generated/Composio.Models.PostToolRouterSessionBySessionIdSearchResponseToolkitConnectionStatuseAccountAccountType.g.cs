
#nullable enable

namespace Composio
{
    /// <summary>
    /// Sharing model for this connected account. PRIVATE is owner-only; SHARED is reachable from a tool-router session only when explicitly pinned.
    /// </summary>
    public enum PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccountAccountType
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
    public static class PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccountAccountTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccountAccountType value)
        {
            return value switch
            {
                PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccountAccountType.Private => "PRIVATE",
                PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccountAccountType.Shared => "SHARED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccountAccountType? ToEnum(string value)
        {
            return value switch
            {
                "PRIVATE" => PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccountAccountType.Private,
                "SHARED" => PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseAccountAccountType.Shared,
                _ => null,
            };
        }
    }
}