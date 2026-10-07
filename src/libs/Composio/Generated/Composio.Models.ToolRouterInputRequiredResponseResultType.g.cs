
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum ToolRouterInputRequiredResponseResultType
    {
        /// <summary>
        ///
        /// </summary>
        InputRequired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolRouterInputRequiredResponseResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolRouterInputRequiredResponseResultType value)
        {
            return value switch
            {
                ToolRouterInputRequiredResponseResultType.InputRequired => "input_required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolRouterInputRequiredResponseResultType? ToEnum(string value)
        {
            return value switch
            {
                "input_required" => ToolRouterInputRequiredResponseResultType.InputRequired,
                _ => null,
            };
        }
    }
}