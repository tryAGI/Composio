
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetV31ToolsImportant
    {
        /// <summary>
        /// 
        /// </summary>
        False,
        /// <summary>
        /// 
        /// </summary>
        True,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetV31ToolsImportantExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetV31ToolsImportant value)
        {
            return value switch
            {
                GetV31ToolsImportant.False => "false",
                GetV31ToolsImportant.True => "true",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetV31ToolsImportant? ToEnum(string value)
        {
            return value switch
            {
                "false" => GetV31ToolsImportant.False,
                "true" => GetV31ToolsImportant.True,
                _ => null,
            };
        }
    }
}