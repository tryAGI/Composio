
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PostInternalActionExecutionLogsResponseDataItemCredentialSource
    {
        /// <summary>
        ///
        /// </summary>
        ConnectedAccount,
        /// <summary>
        ///
        /// </summary>
        CustomAuth,
        /// <summary>
        ///
        /// </summary>
        HostedAccount,
        /// <summary>
        ///
        /// </summary>
        NoAuth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostInternalActionExecutionLogsResponseDataItemCredentialSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostInternalActionExecutionLogsResponseDataItemCredentialSource value)
        {
            return value switch
            {
                PostInternalActionExecutionLogsResponseDataItemCredentialSource.ConnectedAccount => "connected_account",
                PostInternalActionExecutionLogsResponseDataItemCredentialSource.CustomAuth => "custom_auth",
                PostInternalActionExecutionLogsResponseDataItemCredentialSource.HostedAccount => "hosted_account",
                PostInternalActionExecutionLogsResponseDataItemCredentialSource.NoAuth => "no_auth",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostInternalActionExecutionLogsResponseDataItemCredentialSource? ToEnum(string value)
        {
            return value switch
            {
                "connected_account" => PostInternalActionExecutionLogsResponseDataItemCredentialSource.ConnectedAccount,
                "custom_auth" => PostInternalActionExecutionLogsResponseDataItemCredentialSource.CustomAuth,
                "hosted_account" => PostInternalActionExecutionLogsResponseDataItemCredentialSource.HostedAccount,
                "no_auth" => PostInternalActionExecutionLogsResponseDataItemCredentialSource.NoAuth,
                _ => null,
            };
        }
    }
}