
#nullable enable

namespace Composio
{
    /// <summary>
    /// The type of authentication mode (e.g., OAUTH2, BASIC, API_KEY)<br/>
    /// Example: OAUTH2
    /// </summary>
    public enum GetToolkitsBySlugResponseAuthConfigDetailMode
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
    public static class GetToolkitsBySlugResponseAuthConfigDetailModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetToolkitsBySlugResponseAuthConfigDetailMode value)
        {
            return value switch
            {
                GetToolkitsBySlugResponseAuthConfigDetailMode.ApiKey => "API_KEY",
                GetToolkitsBySlugResponseAuthConfigDetailMode.Basic => "BASIC",
                GetToolkitsBySlugResponseAuthConfigDetailMode.BasicWithJwt => "BASIC_WITH_JWT",
                GetToolkitsBySlugResponseAuthConfigDetailMode.BearerToken => "BEARER_TOKEN",
                GetToolkitsBySlugResponseAuthConfigDetailMode.BillcomAuth => "BILLCOM_AUTH",
                GetToolkitsBySlugResponseAuthConfigDetailMode.CalcomAuth => "CALCOM_AUTH",
                GetToolkitsBySlugResponseAuthConfigDetailMode.CimdOauth => "CIMD_OAUTH",
                GetToolkitsBySlugResponseAuthConfigDetailMode.DcrOauth => "DCR_OAUTH",
                GetToolkitsBySlugResponseAuthConfigDetailMode.GoogleServiceAccount => "GOOGLE_SERVICE_ACCOUNT",
                GetToolkitsBySlugResponseAuthConfigDetailMode.NoAuth => "NO_AUTH",
                GetToolkitsBySlugResponseAuthConfigDetailMode.Oauth1 => "OAUTH1",
                GetToolkitsBySlugResponseAuthConfigDetailMode.Oauth2 => "OAUTH2",
                GetToolkitsBySlugResponseAuthConfigDetailMode.S2sOauth2 => "S2S_OAUTH2",
                GetToolkitsBySlugResponseAuthConfigDetailMode.Saml => "SAML",
                GetToolkitsBySlugResponseAuthConfigDetailMode.ServiceAccount => "SERVICE_ACCOUNT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetToolkitsBySlugResponseAuthConfigDetailMode? ToEnum(string value)
        {
            return value switch
            {
                "API_KEY" => GetToolkitsBySlugResponseAuthConfigDetailMode.ApiKey,
                "BASIC" => GetToolkitsBySlugResponseAuthConfigDetailMode.Basic,
                "BASIC_WITH_JWT" => GetToolkitsBySlugResponseAuthConfigDetailMode.BasicWithJwt,
                "BEARER_TOKEN" => GetToolkitsBySlugResponseAuthConfigDetailMode.BearerToken,
                "BILLCOM_AUTH" => GetToolkitsBySlugResponseAuthConfigDetailMode.BillcomAuth,
                "CALCOM_AUTH" => GetToolkitsBySlugResponseAuthConfigDetailMode.CalcomAuth,
                "CIMD_OAUTH" => GetToolkitsBySlugResponseAuthConfigDetailMode.CimdOauth,
                "DCR_OAUTH" => GetToolkitsBySlugResponseAuthConfigDetailMode.DcrOauth,
                "GOOGLE_SERVICE_ACCOUNT" => GetToolkitsBySlugResponseAuthConfigDetailMode.GoogleServiceAccount,
                "NO_AUTH" => GetToolkitsBySlugResponseAuthConfigDetailMode.NoAuth,
                "OAUTH1" => GetToolkitsBySlugResponseAuthConfigDetailMode.Oauth1,
                "OAUTH2" => GetToolkitsBySlugResponseAuthConfigDetailMode.Oauth2,
                "S2S_OAUTH2" => GetToolkitsBySlugResponseAuthConfigDetailMode.S2sOauth2,
                "SAML" => GetToolkitsBySlugResponseAuthConfigDetailMode.Saml,
                "SERVICE_ACCOUNT" => GetToolkitsBySlugResponseAuthConfigDetailMode.ServiceAccount,
                _ => null,
            };
        }
    }
}