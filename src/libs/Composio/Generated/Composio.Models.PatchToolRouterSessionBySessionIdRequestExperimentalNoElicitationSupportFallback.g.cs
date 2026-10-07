
#nullable enable

namespace Composio
{
    /// <summary>
    /// What session MCP does with a tool call that needs approval when the MCP client can't ask the user. deny (default) rejects the call; allow runs it without approval.
    /// </summary>
    public enum PatchToolRouterSessionBySessionIdRequestExperimentalNoElicitationSupportFallback
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
    public static class PatchToolRouterSessionBySessionIdRequestExperimentalNoElicitationSupportFallbackExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchToolRouterSessionBySessionIdRequestExperimentalNoElicitationSupportFallback value)
        {
            return value switch
            {
                PatchToolRouterSessionBySessionIdRequestExperimentalNoElicitationSupportFallback.Allow => "allow",
                PatchToolRouterSessionBySessionIdRequestExperimentalNoElicitationSupportFallback.Deny => "deny",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchToolRouterSessionBySessionIdRequestExperimentalNoElicitationSupportFallback? ToEnum(string value)
        {
            return value switch
            {
                "allow" => PatchToolRouterSessionBySessionIdRequestExperimentalNoElicitationSupportFallback.Allow,
                "deny" => PatchToolRouterSessionBySessionIdRequestExperimentalNoElicitationSupportFallback.Deny,
                _ => null,
            };
        }
    }
}