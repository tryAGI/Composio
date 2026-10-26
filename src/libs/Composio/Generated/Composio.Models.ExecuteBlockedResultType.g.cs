
#nullable enable

namespace Composio
{
    /// <summary>
    /// A session hook stopped the call
    /// </summary>
    public enum ExecuteBlockedResultType
    {
        /// <summary>
        ///
        /// </summary>
        Blocked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExecuteBlockedResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExecuteBlockedResultType value)
        {
            return value switch
            {
                ExecuteBlockedResultType.Blocked => "blocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExecuteBlockedResultType? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => ExecuteBlockedResultType.Blocked,
                _ => null,
            };
        }
    }
}