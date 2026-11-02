
#nullable enable

namespace Composio
{
    /// <summary>
    /// How this trigger instance gets events: webhook (the provider notifies) or poll (a scheduled check).<br/>
    /// Example: webhook
    /// </summary>
    public enum GetTriggerInstancesActiveResponseItemType
    {
        /// <summary>
        /// webhook (the provider notifies) or poll (a scheduled check).
        /// </summary>
        Poll,
        /// <summary>
        /// webhook (the provider notifies) or poll (a scheduled check).
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTriggerInstancesActiveResponseItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTriggerInstancesActiveResponseItemType value)
        {
            return value switch
            {
                GetTriggerInstancesActiveResponseItemType.Poll => "poll",
                GetTriggerInstancesActiveResponseItemType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTriggerInstancesActiveResponseItemType? ToEnum(string value)
        {
            return value switch
            {
                "poll" => GetTriggerInstancesActiveResponseItemType.Poll,
                "webhook" => GetTriggerInstancesActiveResponseItemType.Webhook,
                _ => null,
            };
        }
    }
}