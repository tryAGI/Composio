
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum GetTriggersTypesBySlugResponseType2
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
    public static class GetTriggersTypesBySlugResponseType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTriggersTypesBySlugResponseType2 value)
        {
            return value switch
            {
                GetTriggersTypesBySlugResponseType2.Poll => "poll",
                GetTriggersTypesBySlugResponseType2.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTriggersTypesBySlugResponseType2? ToEnum(string value)
        {
            return value switch
            {
                "poll" => GetTriggersTypesBySlugResponseType2.Poll,
                "webhook" => GetTriggersTypesBySlugResponseType2.Webhook,
                _ => null,
            };
        }
    }
}