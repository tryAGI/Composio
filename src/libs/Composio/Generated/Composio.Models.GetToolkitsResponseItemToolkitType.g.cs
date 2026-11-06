
#nullable enable

namespace Composio
{
    /// <summary>
    /// How the toolkit is implemented: "api" for an API integration, "mcp" for an MCP server<br/>
    /// Example: api
    /// </summary>
    public enum GetToolkitsResponseItemToolkitType
    {
        /// <summary>
        /// "api" for an API integration, "mcp" for an MCP server
        /// </summary>
        Api,
        /// <summary>
        /// "api" for an API integration, "mcp" for an MCP server
        /// </summary>
        Mcp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetToolkitsResponseItemToolkitTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetToolkitsResponseItemToolkitType value)
        {
            return value switch
            {
                GetToolkitsResponseItemToolkitType.Api => "api",
                GetToolkitsResponseItemToolkitType.Mcp => "mcp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetToolkitsResponseItemToolkitType? ToEnum(string value)
        {
            return value switch
            {
                "api" => GetToolkitsResponseItemToolkitType.Api,
                "mcp" => GetToolkitsResponseItemToolkitType.Mcp,
                _ => null,
            };
        }
    }
}