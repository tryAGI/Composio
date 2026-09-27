
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PostToolsExecuteByToolSlugRequestConnectedAccountId
    {
        /// <summary>
        ///
        /// </summary>
        HostedAccount,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolsExecuteByToolSlugRequestConnectedAccountIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolsExecuteByToolSlugRequestConnectedAccountId value)
        {
            return value switch
            {
                PostToolsExecuteByToolSlugRequestConnectedAccountId.HostedAccount => "hosted_account",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolsExecuteByToolSlugRequestConnectedAccountId? ToEnum(string value)
        {
            return value switch
            {
                "hosted_account" => PostToolsExecuteByToolSlugRequestConnectedAccountId.HostedAccount,
                _ => null,
            };
        }
    }
}