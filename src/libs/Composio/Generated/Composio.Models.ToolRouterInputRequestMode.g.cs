
#nullable enable

namespace Composio
{
    /// <summary>
    /// How the client collects the input
    /// </summary>
    public enum ToolRouterInputRequestMode
    {
        /// <summary>
        ///
        /// </summary>
        Form,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolRouterInputRequestModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolRouterInputRequestMode value)
        {
            return value switch
            {
                ToolRouterInputRequestMode.Form => "form",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolRouterInputRequestMode? ToEnum(string value)
        {
            return value switch
            {
                "form" => ToolRouterInputRequestMode.Form,
                _ => null,
            };
        }
    }
}