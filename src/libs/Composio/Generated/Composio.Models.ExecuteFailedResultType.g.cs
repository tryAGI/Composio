
#nullable enable

namespace Composio
{
    /// <summary>
    /// The tool ran and failed, or the user did not approve it
    /// </summary>
    public enum ExecuteFailedResultType
    {
        /// <summary>
        ///
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExecuteFailedResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExecuteFailedResultType value)
        {
            return value switch
            {
                ExecuteFailedResultType.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExecuteFailedResultType? ToEnum(string value)
        {
            return value switch
            {
                "failed" => ExecuteFailedResultType.Failed,
                _ => null,
            };
        }
    }
}