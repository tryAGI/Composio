
#nullable enable

namespace Composio
{
    /// <summary>
    /// Default elicitation behavior when no override matches. `allow_all` runs every tool without prompting; `ask_every_call` prompts on each invocation; `ask_once_per_session` prompts once and remembers the answer for the rest of the session.
    /// </summary>
    public enum PostToolRouterSessionRequestExperimentalPermissionsDefault
    {
        /// <summary>
        /// 
        /// </summary>
        AllowAll,
        /// <summary>
        /// 
        /// </summary>
        AskEveryCall,
        /// <summary>
        /// 
        /// </summary>
        AskOncePerSession,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolRouterSessionRequestExperimentalPermissionsDefaultExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionRequestExperimentalPermissionsDefault value)
        {
            return value switch
            {
                PostToolRouterSessionRequestExperimentalPermissionsDefault.AllowAll => "allow_all",
                PostToolRouterSessionRequestExperimentalPermissionsDefault.AskEveryCall => "ask_every_call",
                PostToolRouterSessionRequestExperimentalPermissionsDefault.AskOncePerSession => "ask_once_per_session",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionRequestExperimentalPermissionsDefault? ToEnum(string value)
        {
            return value switch
            {
                "allow_all" => PostToolRouterSessionRequestExperimentalPermissionsDefault.AllowAll,
                "ask_every_call" => PostToolRouterSessionRequestExperimentalPermissionsDefault.AskEveryCall,
                "ask_once_per_session" => PostToolRouterSessionRequestExperimentalPermissionsDefault.AskOncePerSession,
                _ => null,
            };
        }
    }
}