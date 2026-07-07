
#nullable enable

namespace Composio
{
    /// <summary>
    /// Toolkit provenance: "native" for Composio-managed toolkits, "custom" for a project-registered custom (MCP) toolkit<br/>
    /// Example: native
    /// </summary>
    public enum GetToolkitsResponseItemType
    {
        /// <summary>
        /// "native" for Composio-managed toolkits, "custom" for a project-registered custom (MCP) toolkit
        /// </summary>
        Custom,
        /// <summary>
        /// "native" for Composio-managed toolkits, "custom" for a project-registered custom (MCP) toolkit
        /// </summary>
        Native,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetToolkitsResponseItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetToolkitsResponseItemType value)
        {
            return value switch
            {
                GetToolkitsResponseItemType.Custom => "custom",
                GetToolkitsResponseItemType.Native => "native",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetToolkitsResponseItemType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => GetToolkitsResponseItemType.Custom,
                "native" => GetToolkitsResponseItemType.Native,
                _ => null,
            };
        }
    }
}