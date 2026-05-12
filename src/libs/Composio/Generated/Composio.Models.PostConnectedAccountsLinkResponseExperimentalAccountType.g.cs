
#nullable enable

namespace Composio
{
    /// <summary>
    /// Sharing model for this connected account. PRIVATE is usable only by the owning user_id. SHARED is reachable from a tool-router session only when explicitly pinned in the session config.
    /// </summary>
    public enum PostConnectedAccountsLinkResponseExperimentalAccountType
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
    public static class PostConnectedAccountsLinkResponseExperimentalAccountTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostConnectedAccountsLinkResponseExperimentalAccountType value)
        {
            return value switch
            {
                PostConnectedAccountsLinkResponseExperimentalAccountType.Private => "PRIVATE",
                PostConnectedAccountsLinkResponseExperimentalAccountType.Shared => "SHARED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostConnectedAccountsLinkResponseExperimentalAccountType? ToEnum(string value)
        {
            return value switch
            {
                "PRIVATE" => PostConnectedAccountsLinkResponseExperimentalAccountType.Private,
                "SHARED" => PostConnectedAccountsLinkResponseExperimentalAccountType.Shared,
                _ => null,
            };
        }
    }
}