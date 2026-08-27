
#nullable enable

namespace Composio
{
    /// <summary>
    /// Duplicates state.authScheme. Kept for backward compatibility with existing readers; use state.authScheme instead.
    /// </summary>
    public enum GetConnectedAccountsByNanoidResponseAuthScheme
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
    public static class GetConnectedAccountsByNanoidResponseAuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsByNanoidResponseAuthScheme value)
        {
            return value switch
            {
                GetConnectedAccountsByNanoidResponseAuthScheme.ApiKey => "API_KEY",
                GetConnectedAccountsByNanoidResponseAuthScheme.Basic => "BASIC",
                GetConnectedAccountsByNanoidResponseAuthScheme.BasicWithJwt => "BASIC_WITH_JWT",
                GetConnectedAccountsByNanoidResponseAuthScheme.BearerToken => "BEARER_TOKEN",
                GetConnectedAccountsByNanoidResponseAuthScheme.BillcomAuth => "BILLCOM_AUTH",
                GetConnectedAccountsByNanoidResponseAuthScheme.CalcomAuth => "CALCOM_AUTH",
                GetConnectedAccountsByNanoidResponseAuthScheme.CimdOauth => "CIMD_OAUTH",
                GetConnectedAccountsByNanoidResponseAuthScheme.DcrOauth => "DCR_OAUTH",
                GetConnectedAccountsByNanoidResponseAuthScheme.GoogleServiceAccount => "GOOGLE_SERVICE_ACCOUNT",
                GetConnectedAccountsByNanoidResponseAuthScheme.NoAuth => "NO_AUTH",
                GetConnectedAccountsByNanoidResponseAuthScheme.Oauth1 => "OAUTH1",
                GetConnectedAccountsByNanoidResponseAuthScheme.Oauth2 => "OAUTH2",
                GetConnectedAccountsByNanoidResponseAuthScheme.S2sOauth2 => "S2S_OAUTH2",
                GetConnectedAccountsByNanoidResponseAuthScheme.Saml => "SAML",
                GetConnectedAccountsByNanoidResponseAuthScheme.ServiceAccount => "SERVICE_ACCOUNT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsByNanoidResponseAuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "API_KEY" => GetConnectedAccountsByNanoidResponseAuthScheme.ApiKey,
                "BASIC" => GetConnectedAccountsByNanoidResponseAuthScheme.Basic,
                "BASIC_WITH_JWT" => GetConnectedAccountsByNanoidResponseAuthScheme.BasicWithJwt,
                "BEARER_TOKEN" => GetConnectedAccountsByNanoidResponseAuthScheme.BearerToken,
                "BILLCOM_AUTH" => GetConnectedAccountsByNanoidResponseAuthScheme.BillcomAuth,
                "CALCOM_AUTH" => GetConnectedAccountsByNanoidResponseAuthScheme.CalcomAuth,
                "CIMD_OAUTH" => GetConnectedAccountsByNanoidResponseAuthScheme.CimdOauth,
                "DCR_OAUTH" => GetConnectedAccountsByNanoidResponseAuthScheme.DcrOauth,
                "GOOGLE_SERVICE_ACCOUNT" => GetConnectedAccountsByNanoidResponseAuthScheme.GoogleServiceAccount,
                "NO_AUTH" => GetConnectedAccountsByNanoidResponseAuthScheme.NoAuth,
                "OAUTH1" => GetConnectedAccountsByNanoidResponseAuthScheme.Oauth1,
                "OAUTH2" => GetConnectedAccountsByNanoidResponseAuthScheme.Oauth2,
                "S2S_OAUTH2" => GetConnectedAccountsByNanoidResponseAuthScheme.S2sOauth2,
                "SAML" => GetConnectedAccountsByNanoidResponseAuthScheme.Saml,
                "SERVICE_ACCOUNT" => GetConnectedAccountsByNanoidResponseAuthScheme.ServiceAccount,
                _ => null,
            };
        }
    }
}