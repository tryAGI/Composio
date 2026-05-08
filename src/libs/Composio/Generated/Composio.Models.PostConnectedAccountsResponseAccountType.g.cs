
#nullable enable

namespace Composio
{
    /// <summary>
    /// The persisted sharing model for this connected account (PRIVATE | SHARED). Echoes back the value supplied at creation time so callers can confirm what landed without a follow-up GET.
    /// </summary>
    public enum PostConnectedAccountsResponseAccountType
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
    public static class PostConnectedAccountsResponseAccountTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostConnectedAccountsResponseAccountType value)
        {
            return value switch
            {
                PostConnectedAccountsResponseAccountType.Private => "PRIVATE",
                PostConnectedAccountsResponseAccountType.Shared => "SHARED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostConnectedAccountsResponseAccountType? ToEnum(string value)
        {
            return value switch
            {
                "PRIVATE" => PostConnectedAccountsResponseAccountType.Private,
                "SHARED" => PostConnectedAccountsResponseAccountType.Shared,
                _ => null,
            };
        }
    }
}