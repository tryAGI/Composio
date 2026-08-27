
#nullable enable

namespace Composio
{
    /// <summary>
    /// Payload format version for Pusher real-time events only. For webhook configuration, use GET /api/v3/webhook_subscriptions.<br/>
    /// Example: V2
    /// </summary>
    public enum GetOrgProjectListResponseDataItemWebhookVersion
    {
        /// <summary>
        ///
        /// </summary>
        V1,
        /// <summary>
        ///
        /// </summary>
        V2,
        /// <summary>
        ///
        /// </summary>
        V3,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetOrgProjectListResponseDataItemWebhookVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetOrgProjectListResponseDataItemWebhookVersion value)
        {
            return value switch
            {
                GetOrgProjectListResponseDataItemWebhookVersion.V1 => "V1",
                GetOrgProjectListResponseDataItemWebhookVersion.V2 => "V2",
                GetOrgProjectListResponseDataItemWebhookVersion.V3 => "V3",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetOrgProjectListResponseDataItemWebhookVersion? ToEnum(string value)
        {
            return value switch
            {
                "V1" => GetOrgProjectListResponseDataItemWebhookVersion.V1,
                "V2" => GetOrgProjectListResponseDataItemWebhookVersion.V2,
                "V3" => GetOrgProjectListResponseDataItemWebhookVersion.V3,
                _ => null,
            };
        }
    }
}