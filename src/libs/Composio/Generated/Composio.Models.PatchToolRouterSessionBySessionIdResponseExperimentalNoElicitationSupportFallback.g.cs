
#nullable enable

namespace Composio
{
    /// <summary>
    /// What session MCP does with a tool call that needs approval when the MCP client can't ask the user. Omitted when not set, which means deny.
    /// </summary>
    public enum PatchToolRouterSessionBySessionIdResponseExperimentalNoElicitationSupportFallback
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
    public static class PatchToolRouterSessionBySessionIdResponseExperimentalNoElicitationSupportFallbackExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchToolRouterSessionBySessionIdResponseExperimentalNoElicitationSupportFallback value)
        {
            return value switch
            {
                PatchToolRouterSessionBySessionIdResponseExperimentalNoElicitationSupportFallback.Allow => "allow",
                PatchToolRouterSessionBySessionIdResponseExperimentalNoElicitationSupportFallback.Deny => "deny",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchToolRouterSessionBySessionIdResponseExperimentalNoElicitationSupportFallback? ToEnum(string value)
        {
            return value switch
            {
                "allow" => PatchToolRouterSessionBySessionIdResponseExperimentalNoElicitationSupportFallback.Allow,
                "deny" => PatchToolRouterSessionBySessionIdResponseExperimentalNoElicitationSupportFallback.Deny,
                _ => null,
            };
        }
    }
}