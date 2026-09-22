
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum GetInternalActionExecutionLogByIdResponseCredentialSource
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
    public static class GetInternalActionExecutionLogByIdResponseCredentialSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetInternalActionExecutionLogByIdResponseCredentialSource value)
        {
            return value switch
            {
                GetInternalActionExecutionLogByIdResponseCredentialSource.ConnectedAccount => "connected_account",
                GetInternalActionExecutionLogByIdResponseCredentialSource.CustomAuth => "custom_auth",
                GetInternalActionExecutionLogByIdResponseCredentialSource.HostedAccount => "hosted_account",
                GetInternalActionExecutionLogByIdResponseCredentialSource.NoAuth => "no_auth",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetInternalActionExecutionLogByIdResponseCredentialSource? ToEnum(string value)
        {
            return value switch
            {
                "connected_account" => GetInternalActionExecutionLogByIdResponseCredentialSource.ConnectedAccount,
                "custom_auth" => GetInternalActionExecutionLogByIdResponseCredentialSource.CustomAuth,
                "hosted_account" => GetInternalActionExecutionLogByIdResponseCredentialSource.HostedAccount,
                "no_auth" => GetInternalActionExecutionLogByIdResponseCredentialSource.NoAuth,
                _ => null,
            };
        }
    }
}