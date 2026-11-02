
#nullable enable

namespace Composio
{
    /// <summary>
    /// Whether this instance receives events by webhook or by polling, for a trigger that supports both. Omit it to let Composio choose the best one.
    /// </summary>
    public enum PostTriggerInstancesBySlugUpsertRequestType
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
    public static class PostTriggerInstancesBySlugUpsertRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostTriggerInstancesBySlugUpsertRequestType value)
        {
            return value switch
            {
                PostTriggerInstancesBySlugUpsertRequestType.Poll => "poll",
                PostTriggerInstancesBySlugUpsertRequestType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostTriggerInstancesBySlugUpsertRequestType? ToEnum(string value)
        {
            return value switch
            {
                "poll" => PostTriggerInstancesBySlugUpsertRequestType.Poll,
                "webhook" => PostTriggerInstancesBySlugUpsertRequestType.Webhook,
                _ => null,
            };
        }
    }
}