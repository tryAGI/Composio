
#nullable enable

namespace Composio
{
    /// <summary>
    /// The persisted sharing model for this connected account (PRIVATE | SHARED). Echoes back the value supplied at creation time so callers can confirm what landed without a follow-up GET.
    /// </summary>
    public enum PostConnectedAccountsLinkResponseAccountType
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
    public static class PostConnectedAccountsLinkResponseAccountTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostConnectedAccountsLinkResponseAccountType value)
        {
            return value switch
            {
                PostConnectedAccountsLinkResponseAccountType.Private => "PRIVATE",
                PostConnectedAccountsLinkResponseAccountType.Shared => "SHARED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostConnectedAccountsLinkResponseAccountType? ToEnum(string value)
        {
            return value switch
            {
                "PRIVATE" => PostConnectedAccountsLinkResponseAccountType.Private,
                "SHARED" => PostConnectedAccountsLinkResponseAccountType.Shared,
                _ => null,
            };
        }
    }
}