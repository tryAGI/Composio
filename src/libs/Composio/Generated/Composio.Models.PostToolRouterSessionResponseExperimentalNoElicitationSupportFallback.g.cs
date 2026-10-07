
#nullable enable

namespace Composio
{
    /// <summary>
    /// What session MCP does with a tool call that needs approval when the MCP client can't ask the user. Omitted when not set, which means deny.
    /// </summary>
    public enum PostToolRouterSessionResponseExperimentalNoElicitationSupportFallback
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
    public static class PostToolRouterSessionResponseExperimentalNoElicitationSupportFallbackExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionResponseExperimentalNoElicitationSupportFallback value)
        {
            return value switch
            {
                PostToolRouterSessionResponseExperimentalNoElicitationSupportFallback.Allow => "allow",
                PostToolRouterSessionResponseExperimentalNoElicitationSupportFallback.Deny => "deny",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionResponseExperimentalNoElicitationSupportFallback? ToEnum(string value)
        {
            return value switch
            {
                "allow" => PostToolRouterSessionResponseExperimentalNoElicitationSupportFallback.Allow,
                "deny" => PostToolRouterSessionResponseExperimentalNoElicitationSupportFallback.Deny,
                _ => null,
            };
        }
    }
}