
#nullable enable

namespace Composio
{
    /// <summary>
    /// Sharing model for this connected account. PRIVATE is usable only by the owning user_id. SHARED is reachable from a tool-router session only when explicitly pinned in the session config.
    /// </summary>
    public enum GetConnectedAccountsByNanoidResponseExperimentalAccountType
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
    public static class GetConnectedAccountsByNanoidResponseExperimentalAccountTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsByNanoidResponseExperimentalAccountType value)
        {
            return value switch
            {
                GetConnectedAccountsByNanoidResponseExperimentalAccountType.Private => "PRIVATE",
                GetConnectedAccountsByNanoidResponseExperimentalAccountType.Shared => "SHARED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsByNanoidResponseExperimentalAccountType? ToEnum(string value)
        {
            return value switch
            {
                "PRIVATE" => GetConnectedAccountsByNanoidResponseExperimentalAccountType.Private,
                "SHARED" => GetConnectedAccountsByNanoidResponseExperimentalAccountType.Shared,
                _ => null,
            };
        }
    }
}