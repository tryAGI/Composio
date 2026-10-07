
#nullable enable

namespace Composio
{
    /// <summary>
    /// What session MCP does with a tool call that needs approval when the MCP client can't ask the user. deny (default) rejects the call; allow runs it without approval.<br/>
    /// Default Value: deny
    /// </summary>
    public enum PostToolRouterSessionRequestExperimentalNoElicitationSupportFallback
    {
        /// <summary>
        ///
        /// </summary>
        Allow,
        /// <summary>
        ///
        /// </summary>
        Deny,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolRouterSessionRequestExperimentalNoElicitationSupportFallbackExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionRequestExperimentalNoElicitationSupportFallback value)
        {
            return value switch
            {
                PostToolRouterSessionRequestExperimentalNoElicitationSupportFallback.Allow => "allow",
                PostToolRouterSessionRequestExperimentalNoElicitationSupportFallback.Deny => "deny",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionRequestExperimentalNoElicitationSupportFallback? ToEnum(string value)
        {
            return value switch
            {
                "allow" => PostToolRouterSessionRequestExperimentalNoElicitationSupportFallback.Allow,
                "deny" => PostToolRouterSessionRequestExperimentalNoElicitationSupportFallback.Deny,
                _ => null,
            };
        }
    }
}