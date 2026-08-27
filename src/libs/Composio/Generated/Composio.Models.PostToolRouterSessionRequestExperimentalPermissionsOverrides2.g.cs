
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PostToolRouterSessionRequestExperimentalPermissionsOverrides2
    {
        /// <summary>
        ///
        /// </summary>
        AlwaysAllow,
        /// <summary>
        ///
        /// </summary>
        AlwaysDeny,
        /// <summary>
        ///
        /// </summary>
        AskAlways,
        /// <summary>
        ///
        /// </summary>
        AskOnce,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolRouterSessionRequestExperimentalPermissionsOverrides2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionRequestExperimentalPermissionsOverrides2 value)
        {
            return value switch
            {
                PostToolRouterSessionRequestExperimentalPermissionsOverrides2.AlwaysAllow => "always_allow",
                PostToolRouterSessionRequestExperimentalPermissionsOverrides2.AlwaysDeny => "always_deny",
                PostToolRouterSessionRequestExperimentalPermissionsOverrides2.AskAlways => "ask_always",
                PostToolRouterSessionRequestExperimentalPermissionsOverrides2.AskOnce => "ask_once",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionRequestExperimentalPermissionsOverrides2? ToEnum(string value)
        {
            return value switch
            {
                "always_allow" => PostToolRouterSessionRequestExperimentalPermissionsOverrides2.AlwaysAllow,
                "always_deny" => PostToolRouterSessionRequestExperimentalPermissionsOverrides2.AlwaysDeny,
                "ask_always" => PostToolRouterSessionRequestExperimentalPermissionsOverrides2.AskAlways,
                "ask_once" => PostToolRouterSessionRequestExperimentalPermissionsOverrides2.AskOnce,
                _ => null,
            };
        }
    }
}