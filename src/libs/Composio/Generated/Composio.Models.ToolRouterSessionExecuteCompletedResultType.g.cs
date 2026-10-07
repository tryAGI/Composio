
#nullable enable

namespace Composio
{
    /// <summary>
    /// The tool ran and succeeded
    /// </summary>
    public enum ToolRouterSessionExecuteCompletedResultType
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolRouterSessionExecuteCompletedResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolRouterSessionExecuteCompletedResultType value)
        {
            return value switch
            {
                ToolRouterSessionExecuteCompletedResultType.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolRouterSessionExecuteCompletedResultType? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ToolRouterSessionExecuteCompletedResultType.Completed,
                _ => null,
            };
        }
    }
}