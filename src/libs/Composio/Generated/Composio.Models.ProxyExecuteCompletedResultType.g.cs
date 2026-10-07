
#nullable enable

namespace Composio
{
    /// <summary>
    /// The request was sent and the proxied API responded
    /// </summary>
    public enum ProxyExecuteCompletedResultType
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProxyExecuteCompletedResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProxyExecuteCompletedResultType value)
        {
            return value switch
            {
                ProxyExecuteCompletedResultType.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProxyExecuteCompletedResultType? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ProxyExecuteCompletedResultType.Completed,
                _ => null,
            };
        }
    }
}