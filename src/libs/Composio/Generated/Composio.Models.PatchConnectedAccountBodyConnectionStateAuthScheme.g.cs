
#nullable enable

namespace Composio
{
    /// <summary>
    /// The auth scheme of the connected account. Must match the connection's actual auth scheme.
    /// </summary>
    public enum PatchConnectedAccountBodyConnectionStateAuthScheme
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
        GoogleServiceAccount,
        /// <summary>
        /// 
        /// </summary>
        ServiceAccount,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchConnectedAccountBodyConnectionStateAuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchConnectedAccountBodyConnectionStateAuthScheme value)
        {
            return value switch
            {
                PatchConnectedAccountBodyConnectionStateAuthScheme.ApiKey => "API_KEY",
                PatchConnectedAccountBodyConnectionStateAuthScheme.Basic => "BASIC",
                PatchConnectedAccountBodyConnectionStateAuthScheme.BasicWithJwt => "BASIC_WITH_JWT",
                PatchConnectedAccountBodyConnectionStateAuthScheme.BearerToken => "BEARER_TOKEN",
                PatchConnectedAccountBodyConnectionStateAuthScheme.GoogleServiceAccount => "GOOGLE_SERVICE_ACCOUNT",
                PatchConnectedAccountBodyConnectionStateAuthScheme.ServiceAccount => "SERVICE_ACCOUNT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchConnectedAccountBodyConnectionStateAuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "API_KEY" => PatchConnectedAccountBodyConnectionStateAuthScheme.ApiKey,
                "BASIC" => PatchConnectedAccountBodyConnectionStateAuthScheme.Basic,
                "BASIC_WITH_JWT" => PatchConnectedAccountBodyConnectionStateAuthScheme.BasicWithJwt,
                "BEARER_TOKEN" => PatchConnectedAccountBodyConnectionStateAuthScheme.BearerToken,
                "GOOGLE_SERVICE_ACCOUNT" => PatchConnectedAccountBodyConnectionStateAuthScheme.GoogleServiceAccount,
                "SERVICE_ACCOUNT" => PatchConnectedAccountBodyConnectionStateAuthScheme.ServiceAccount,
                _ => null,
            };
        }
    }
}