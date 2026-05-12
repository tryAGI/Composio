
#nullable enable

namespace Composio
{
    /// <summary>
    /// Sharing model for this connected account. PRIVATE is usable only by the owning user_id. SHARED is reachable from a tool-router session only when explicitly pinned in the session config.
    /// </summary>
    public enum PostConnectedAccountsResponseExperimentalAccountType
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
    public static class PostConnectedAccountsResponseExperimentalAccountTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostConnectedAccountsResponseExperimentalAccountType value)
        {
            return value switch
            {
                PostConnectedAccountsResponseExperimentalAccountType.Private => "PRIVATE",
                PostConnectedAccountsResponseExperimentalAccountType.Shared => "SHARED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostConnectedAccountsResponseExperimentalAccountType? ToEnum(string value)
        {
            return value switch
            {
                "PRIVATE" => PostConnectedAccountsResponseExperimentalAccountType.Private,
                "SHARED" => PostConnectedAccountsResponseExperimentalAccountType.Shared,
                _ => null,
            };
        }
    }
}