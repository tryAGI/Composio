
#nullable enable

namespace Composio
{
    /// <summary>
    /// Deprecated: use types. poll for any trigger that polls, even one a webhook wakes; otherwise webhook.<br/>
    /// Example: webhook
    /// </summary>
    public enum GetTriggersTypesResponseItemType
    {
        /// <summary>
        /// use types. poll for any trigger that polls, even one a webhook wakes; otherwise webhook.
        /// </summary>
        Poll,
        /// <summary>
        /// use types. poll for any trigger that polls, even one a webhook wakes; otherwise webhook.
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTriggersTypesResponseItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTriggersTypesResponseItemType value)
        {
            return value switch
            {
                GetTriggersTypesResponseItemType.Poll => "poll",
                GetTriggersTypesResponseItemType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTriggersTypesResponseItemType? ToEnum(string value)
        {
            return value switch
            {
                "poll" => GetTriggersTypesResponseItemType.Poll,
                "webhook" => GetTriggersTypesResponseItemType.Webhook,
                _ => null,
            };
        }
    }
}