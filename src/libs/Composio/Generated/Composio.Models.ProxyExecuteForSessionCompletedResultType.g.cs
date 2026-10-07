
#nullable enable

namespace Composio
{
    /// <summary>
    /// The request was sent and the proxied API responded
    /// </summary>
    public enum ProxyExecuteForSessionCompletedResultType
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProxyExecuteForSessionCompletedResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProxyExecuteForSessionCompletedResultType value)
        {
            return value switch
            {
                ProxyExecuteForSessionCompletedResultType.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProxyExecuteForSessionCompletedResultType? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ProxyExecuteForSessionCompletedResultType.Completed,
                _ => null,
            };
        }
    }
}