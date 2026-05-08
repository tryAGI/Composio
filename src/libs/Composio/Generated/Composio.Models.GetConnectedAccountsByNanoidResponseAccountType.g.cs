
#nullable enable

namespace Composio
{
    /// <summary>
    /// Sharing model. PRIVATE accounts are usable only by their owning user_id. SHARED accounts are reachable from a tool-router session only when explicitly pinned in the session config (at most one SHARED per toolkit per session); they are never used implicitly.
    /// </summary>
    public enum GetConnectedAccountsByNanoidResponseAccountType
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
    public static class GetConnectedAccountsByNanoidResponseAccountTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsByNanoidResponseAccountType value)
        {
            return value switch
            {
                GetConnectedAccountsByNanoidResponseAccountType.Private => "PRIVATE",
                GetConnectedAccountsByNanoidResponseAccountType.Shared => "SHARED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsByNanoidResponseAccountType? ToEnum(string value)
        {
            return value switch
            {
                "PRIVATE" => GetConnectedAccountsByNanoidResponseAccountType.Private,
                "SHARED" => GetConnectedAccountsByNanoidResponseAccountType.Shared,
                _ => null,
            };
        }
    }
}