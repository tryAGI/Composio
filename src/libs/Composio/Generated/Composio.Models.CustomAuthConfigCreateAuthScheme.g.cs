
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public enum CustomAuthConfigCreateAuthScheme
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
    public static class CustomAuthConfigCreateAuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomAuthConfigCreateAuthScheme value)
        {
            return value switch
            {
                CustomAuthConfigCreateAuthScheme.ApiKey => "API_KEY",
                CustomAuthConfigCreateAuthScheme.Basic => "BASIC",
                CustomAuthConfigCreateAuthScheme.BasicWithJwt => "BASIC_WITH_JWT",
                CustomAuthConfigCreateAuthScheme.BearerToken => "BEARER_TOKEN",
                CustomAuthConfigCreateAuthScheme.BillcomAuth => "BILLCOM_AUTH",
                CustomAuthConfigCreateAuthScheme.CalcomAuth => "CALCOM_AUTH",
                CustomAuthConfigCreateAuthScheme.DcrOauth => "DCR_OAUTH",
                CustomAuthConfigCreateAuthScheme.GoogleServiceAccount => "GOOGLE_SERVICE_ACCOUNT",
                CustomAuthConfigCreateAuthScheme.NoAuth => "NO_AUTH",
                CustomAuthConfigCreateAuthScheme.Oauth1 => "OAUTH1",
                CustomAuthConfigCreateAuthScheme.Oauth2 => "OAUTH2",
                CustomAuthConfigCreateAuthScheme.S2sOauth2 => "S2S_OAUTH2",
                CustomAuthConfigCreateAuthScheme.Saml => "SAML",
                CustomAuthConfigCreateAuthScheme.ServiceAccount => "SERVICE_ACCOUNT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomAuthConfigCreateAuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "API_KEY" => CustomAuthConfigCreateAuthScheme.ApiKey,
                "BASIC" => CustomAuthConfigCreateAuthScheme.Basic,
                "BASIC_WITH_JWT" => CustomAuthConfigCreateAuthScheme.BasicWithJwt,
                "BEARER_TOKEN" => CustomAuthConfigCreateAuthScheme.BearerToken,
                "BILLCOM_AUTH" => CustomAuthConfigCreateAuthScheme.BillcomAuth,
                "CALCOM_AUTH" => CustomAuthConfigCreateAuthScheme.CalcomAuth,
                "DCR_OAUTH" => CustomAuthConfigCreateAuthScheme.DcrOauth,
                "GOOGLE_SERVICE_ACCOUNT" => CustomAuthConfigCreateAuthScheme.GoogleServiceAccount,
                "NO_AUTH" => CustomAuthConfigCreateAuthScheme.NoAuth,
                "OAUTH1" => CustomAuthConfigCreateAuthScheme.Oauth1,
                "OAUTH2" => CustomAuthConfigCreateAuthScheme.Oauth2,
                "S2S_OAUTH2" => CustomAuthConfigCreateAuthScheme.S2sOauth2,
                "SAML" => CustomAuthConfigCreateAuthScheme.Saml,
                "SERVICE_ACCOUNT" => CustomAuthConfigCreateAuthScheme.ServiceAccount,
                _ => null,
            };
        }
    }
}