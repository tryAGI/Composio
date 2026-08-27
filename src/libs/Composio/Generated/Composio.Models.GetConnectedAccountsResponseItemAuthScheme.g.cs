
#nullable enable

namespace Composio
{
    /// <summary>
    /// Duplicates state.authScheme. Kept for backward compatibility with existing readers; use state.authScheme instead.
    /// </summary>
    public enum GetConnectedAccountsResponseItemAuthScheme
    {
        /// <summary>
        ///
        /// </summary>
        ApiKey,
        /// <summary>
        ///
        /// </summary>
        Basic,
        /// <summary>
        ///
        /// </summary>
        BasicWithJwt,
        /// <summary>
        ///
        /// </summary>
        BearerToken,
        /// <summary>
        ///
        /// </summary>
        BillcomAuth,
        /// <summary>
        ///
        /// </summary>
        CalcomAuth,
        /// <summary>
        ///
        /// </summary>
        CimdOauth,
        /// <summary>
        ///
        /// </summary>
        DcrOauth,
        /// <summary>
        ///
        /// </summary>
        GoogleServiceAccount,
        /// <summary>
        ///
        /// </summary>
        NoAuth,
        /// <summary>
        ///
        /// </summary>
        Oauth1,
        /// <summary>
        ///
        /// </summary>
        Oauth2,
        /// <summary>
        ///
        /// </summary>
        S2sOauth2,
        /// <summary>
        ///
        /// </summary>
        Saml,
        /// <summary>
        ///
        /// </summary>
        ServiceAccount,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConnectedAccountsResponseItemAuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsResponseItemAuthScheme value)
        {
            return value switch
            {
                GetConnectedAccountsResponseItemAuthScheme.ApiKey => "API_KEY",
                GetConnectedAccountsResponseItemAuthScheme.Basic => "BASIC",
                GetConnectedAccountsResponseItemAuthScheme.BasicWithJwt => "BASIC_WITH_JWT",
                GetConnectedAccountsResponseItemAuthScheme.BearerToken => "BEARER_TOKEN",
                GetConnectedAccountsResponseItemAuthScheme.BillcomAuth => "BILLCOM_AUTH",
                GetConnectedAccountsResponseItemAuthScheme.CalcomAuth => "CALCOM_AUTH",
                GetConnectedAccountsResponseItemAuthScheme.CimdOauth => "CIMD_OAUTH",
                GetConnectedAccountsResponseItemAuthScheme.DcrOauth => "DCR_OAUTH",
                GetConnectedAccountsResponseItemAuthScheme.GoogleServiceAccount => "GOOGLE_SERVICE_ACCOUNT",
                GetConnectedAccountsResponseItemAuthScheme.NoAuth => "NO_AUTH",
                GetConnectedAccountsResponseItemAuthScheme.Oauth1 => "OAUTH1",
                GetConnectedAccountsResponseItemAuthScheme.Oauth2 => "OAUTH2",
                GetConnectedAccountsResponseItemAuthScheme.S2sOauth2 => "S2S_OAUTH2",
                GetConnectedAccountsResponseItemAuthScheme.Saml => "SAML",
                GetConnectedAccountsResponseItemAuthScheme.ServiceAccount => "SERVICE_ACCOUNT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsResponseItemAuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "API_KEY" => GetConnectedAccountsResponseItemAuthScheme.ApiKey,
                "BASIC" => GetConnectedAccountsResponseItemAuthScheme.Basic,
                "BASIC_WITH_JWT" => GetConnectedAccountsResponseItemAuthScheme.BasicWithJwt,
                "BEARER_TOKEN" => GetConnectedAccountsResponseItemAuthScheme.BearerToken,
                "BILLCOM_AUTH" => GetConnectedAccountsResponseItemAuthScheme.BillcomAuth,
                "CALCOM_AUTH" => GetConnectedAccountsResponseItemAuthScheme.CalcomAuth,
                "CIMD_OAUTH" => GetConnectedAccountsResponseItemAuthScheme.CimdOauth,
                "DCR_OAUTH" => GetConnectedAccountsResponseItemAuthScheme.DcrOauth,
                "GOOGLE_SERVICE_ACCOUNT" => GetConnectedAccountsResponseItemAuthScheme.GoogleServiceAccount,
                "NO_AUTH" => GetConnectedAccountsResponseItemAuthScheme.NoAuth,
                "OAUTH1" => GetConnectedAccountsResponseItemAuthScheme.Oauth1,
                "OAUTH2" => GetConnectedAccountsResponseItemAuthScheme.Oauth2,
                "S2S_OAUTH2" => GetConnectedAccountsResponseItemAuthScheme.S2sOauth2,
                "SAML" => GetConnectedAccountsResponseItemAuthScheme.Saml,
                "SERVICE_ACCOUNT" => GetConnectedAccountsResponseItemAuthScheme.ServiceAccount,
                _ => null,
            };
        }
    }
}