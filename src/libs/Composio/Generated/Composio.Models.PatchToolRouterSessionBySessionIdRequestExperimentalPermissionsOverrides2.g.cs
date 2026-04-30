
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchToolRouterSessionBySessionIdRequestExperimentalPermissionsOverrides2
    {
        /// <summary>
        /// 
        /// </summary>
        AlwaysAllow,
        /// <summary>
        /// 
        /// </summary>
        AlwaysDeny,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchToolRouterSessionBySessionIdRequestExperimentalPermissionsOverrides2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchToolRouterSessionBySessionIdRequestExperimentalPermissionsOverrides2 value)
        {
            return value switch
            {
                PatchToolRouterSessionBySessionIdRequestExperimentalPermissionsOverrides2.AlwaysAllow => "always_allow",
                PatchToolRouterSessionBySessionIdRequestExperimentalPermissionsOverrides2.AlwaysDeny => "always_deny",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchToolRouterSessionBySessionIdRequestExperimentalPermissionsOverrides2? ToEnum(string value)
        {
            return value switch
            {
                "always_allow" => PatchToolRouterSessionBySessionIdRequestExperimentalPermissionsOverrides2.AlwaysAllow,
                "always_deny" => PatchToolRouterSessionBySessionIdRequestExperimentalPermissionsOverrides2.AlwaysDeny,
                _ => null,
            };
        }
    }
}