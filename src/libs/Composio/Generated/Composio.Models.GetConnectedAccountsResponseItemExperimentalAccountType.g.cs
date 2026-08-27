
#nullable enable

namespace Composio
{
    /// <summary>
    /// Sharing model for this connected account. PRIVATE is usable only by the owning user_id. SHARED is reachable from a tool-router session only when explicitly pinned in the session config.
    /// </summary>
    public enum GetConnectedAccountsResponseItemExperimentalAccountType
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
    public static class GetConnectedAccountsResponseItemExperimentalAccountTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsResponseItemExperimentalAccountType value)
        {
            return value switch
            {
                GetConnectedAccountsResponseItemExperimentalAccountType.Private => "PRIVATE",
                GetConnectedAccountsResponseItemExperimentalAccountType.Shared => "SHARED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsResponseItemExperimentalAccountType? ToEnum(string value)
        {
            return value switch
            {
                "PRIVATE" => GetConnectedAccountsResponseItemExperimentalAccountType.Private,
                "SHARED" => GetConnectedAccountsResponseItemExperimentalAccountType.Shared,
                _ => null,
            };
        }
    }
}