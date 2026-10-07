
#nullable enable

namespace Composio
{
    /// <summary>
    /// The tool ran and failed
    /// </summary>
    public enum ToolRouterSessionExecuteFailedResultType
    {
        /// <summary>
        ///
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolRouterSessionExecuteFailedResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolRouterSessionExecuteFailedResultType value)
        {
            return value switch
            {
                ToolRouterSessionExecuteFailedResultType.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolRouterSessionExecuteFailedResultType? ToEnum(string value)
        {
            return value switch
            {
                "failed" => ToolRouterSessionExecuteFailedResultType.Failed,
                _ => null,
            };
        }
    }
}