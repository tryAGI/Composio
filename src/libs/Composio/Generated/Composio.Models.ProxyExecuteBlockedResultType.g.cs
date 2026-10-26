
#nullable enable

namespace Composio
{
    /// <summary>
    /// A session hook stopped the call
    /// </summary>
    public enum ProxyExecuteBlockedResultType
    {
        /// <summary>
        ///
        /// </summary>
        Blocked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProxyExecuteBlockedResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProxyExecuteBlockedResultType value)
        {
            return value switch
            {
                ProxyExecuteBlockedResultType.Blocked => "blocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProxyExecuteBlockedResultType? ToEnum(string value)
        {
            return value switch
            {
                "blocked" => ProxyExecuteBlockedResultType.Blocked,
                _ => null,
            };
        }
    }
}