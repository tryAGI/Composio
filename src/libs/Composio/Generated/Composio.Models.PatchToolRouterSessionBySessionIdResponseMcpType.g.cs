
#nullable enable

namespace Composio
{
    /// <summary>
    /// The type of the MCP server. Can be http
    /// </summary>
    public enum PatchToolRouterSessionBySessionIdResponseMcpType
    {
        /// <summary>
        ///
        /// </summary>
        Http,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchToolRouterSessionBySessionIdResponseMcpTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchToolRouterSessionBySessionIdResponseMcpType value)
        {
            return value switch
            {
                PatchToolRouterSessionBySessionIdResponseMcpType.Http => "http",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchToolRouterSessionBySessionIdResponseMcpType? ToEnum(string value)
        {
            return value switch
            {
                "http" => PatchToolRouterSessionBySessionIdResponseMcpType.Http,
                _ => null,
            };
        }
    }
}