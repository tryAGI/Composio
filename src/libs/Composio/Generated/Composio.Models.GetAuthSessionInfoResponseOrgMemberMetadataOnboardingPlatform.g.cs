
#nullable enable

namespace Composio
{
    /// <summary>
    /// Platform the user onboarded on.
    /// </summary>
    public enum GetAuthSessionInfoResponseOrgMemberMetadataOnboardingPlatform
    {
        /// <summary>
        ///
        /// </summary>
        Consumer,
        /// <summary>
        ///
        /// </summary>
        Developer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAuthSessionInfoResponseOrgMemberMetadataOnboardingPlatformExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAuthSessionInfoResponseOrgMemberMetadataOnboardingPlatform value)
        {
            return value switch
            {
                GetAuthSessionInfoResponseOrgMemberMetadataOnboardingPlatform.Consumer => "consumer",
                GetAuthSessionInfoResponseOrgMemberMetadataOnboardingPlatform.Developer => "developer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAuthSessionInfoResponseOrgMemberMetadataOnboardingPlatform? ToEnum(string value)
        {
            return value switch
            {
                "consumer" => GetAuthSessionInfoResponseOrgMemberMetadataOnboardingPlatform.Consumer,
                "developer" => GetAuthSessionInfoResponseOrgMemberMetadataOnboardingPlatform.Developer,
                _ => null,
            };
        }
    }
}