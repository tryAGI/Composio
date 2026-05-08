
#nullable enable

namespace Composio
{
    /// <summary>
    /// Sharing model. PRIVATE accounts are usable only by their owning user_id. SHARED accounts are reachable from a tool-router session only when explicitly pinned in the session config (at most one SHARED per toolkit per session); they are never used implicitly.
    /// </summary>
    public enum GetConnectedAccountsResponseItemAccountType
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
    public static class GetConnectedAccountsResponseItemAccountTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsResponseItemAccountType value)
        {
            return value switch
            {
                GetConnectedAccountsResponseItemAccountType.Private => "PRIVATE",
                GetConnectedAccountsResponseItemAccountType.Shared => "SHARED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsResponseItemAccountType? ToEnum(string value)
        {
            return value switch
            {
                "PRIVATE" => GetConnectedAccountsResponseItemAccountType.Private,
                "SHARED" => GetConnectedAccountsResponseItemAccountType.Shared,
                _ => null,
            };
        }
    }
}