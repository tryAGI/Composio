
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum GetTriggersTypesResponseItemType2
    {
        /// <summary>
        ///
        /// </summary>
        Poll,
        /// <summary>
        ///
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTriggersTypesResponseItemType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTriggersTypesResponseItemType2 value)
        {
            return value switch
            {
                GetTriggersTypesResponseItemType2.Poll => "poll",
                GetTriggersTypesResponseItemType2.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTriggersTypesResponseItemType2? ToEnum(string value)
        {
            return value switch
            {
                "poll" => GetTriggersTypesResponseItemType2.Poll,
                "webhook" => GetTriggersTypesResponseItemType2.Webhook,
                _ => null,
            };
        }
    }
}