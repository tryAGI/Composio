
#nullable enable

namespace Composio
{
    /// <summary>
    /// Kind of input requested
    /// </summary>
    public enum ToolRouterInputRequestType
    {
        /// <summary>
        ///
        /// </summary>
        Elicitation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolRouterInputRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolRouterInputRequestType value)
        {
            return value switch
            {
                ToolRouterInputRequestType.Elicitation => "elicitation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolRouterInputRequestType? ToEnum(string value)
        {
            return value switch
            {
                "elicitation" => ToolRouterInputRequestType.Elicitation,
                _ => null,
            };
        }
    }
}