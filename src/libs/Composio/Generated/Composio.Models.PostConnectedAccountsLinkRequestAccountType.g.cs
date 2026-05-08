
#nullable enable

namespace Composio
{
    /// <summary>
    /// Sharing model for this connected account. PRIVATE (default) is usable only by the owning user_id. SHARED is reachable from a tool-router session ONLY when explicitly pinned in the session config — at most one SHARED connection per toolkit per session. Sessions never use a SHARED connection implicitly. Set at creation time only — cannot be changed later.
    /// </summary>
    public enum PostConnectedAccountsLinkRequestAccountType
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
    public static class PostConnectedAccountsLinkRequestAccountTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostConnectedAccountsLinkRequestAccountType value)
        {
            return value switch
            {
                PostConnectedAccountsLinkRequestAccountType.Private => "PRIVATE",
                PostConnectedAccountsLinkRequestAccountType.Shared => "SHARED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostConnectedAccountsLinkRequestAccountType? ToEnum(string value)
        {
            return value switch
            {
                "PRIVATE" => PostConnectedAccountsLinkRequestAccountType.Private,
                "SHARED" => PostConnectedAccountsLinkRequestAccountType.Shared,
                _ => null,
            };
        }
    }
}