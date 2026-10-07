
#nullable enable

namespace Composio
{
    /// <summary>
    /// The tool ran and succeeded
    /// </summary>
    public enum ExecuteCompletedResultType
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExecuteCompletedResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExecuteCompletedResultType value)
        {
            return value switch
            {
                ExecuteCompletedResultType.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExecuteCompletedResultType? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ExecuteCompletedResultType.Completed,
                _ => null,
            };
        }
    }
}