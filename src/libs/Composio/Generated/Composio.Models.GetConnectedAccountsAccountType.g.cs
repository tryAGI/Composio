
#nullable enable

namespace Composio
{
    /// <summary>
    /// [Experimental] Filter by sharing model. Default (omitted) returns PRIVATE only — shared accounts must be requested explicitly. Pass SHARED for only shared accounts, or ALL for PRIVATE + SHARED.
    /// </summary>
    public enum GetConnectedAccountsAccountType
    {
        /// <summary>
        ///
        /// </summary>
        All,
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
    public static class GetConnectedAccountsAccountTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsAccountType value)
        {
            return value switch
            {
                GetConnectedAccountsAccountType.All => "ALL",
                GetConnectedAccountsAccountType.Private => "PRIVATE",
                GetConnectedAccountsAccountType.Shared => "SHARED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsAccountType? ToEnum(string value)
        {
            return value switch
            {
                "ALL" => GetConnectedAccountsAccountType.All,
                "PRIVATE" => GetConnectedAccountsAccountType.Private,
                "SHARED" => GetConnectedAccountsAccountType.Shared,
                _ => null,
            };
        }
    }
}