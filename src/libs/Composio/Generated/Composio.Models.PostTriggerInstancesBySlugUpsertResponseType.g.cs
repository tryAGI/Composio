
#nullable enable

namespace Composio
{
    /// <summary>
    /// How this trigger instance gets events: webhook (the provider notifies) or poll (a scheduled check).<br/>
    /// Example: webhook
    /// </summary>
    public enum PostTriggerInstancesBySlugUpsertResponseType
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
    public static class PostTriggerInstancesBySlugUpsertResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostTriggerInstancesBySlugUpsertResponseType value)
        {
            return value switch
            {
                PostTriggerInstancesBySlugUpsertResponseType.Poll => "poll",
                PostTriggerInstancesBySlugUpsertResponseType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostTriggerInstancesBySlugUpsertResponseType? ToEnum(string value)
        {
            return value switch
            {
                "poll" => PostTriggerInstancesBySlugUpsertResponseType.Poll,
                "webhook" => PostTriggerInstancesBySlugUpsertResponseType.Webhook,
                _ => null,
            };
        }
    }
}