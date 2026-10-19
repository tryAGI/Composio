
#nullable enable

namespace Composio
{
    /// <summary>
    /// A before_execute hook stopped the call. The tool did not run.
    /// </summary>
    public enum BlockReasonVariant1Type
    {
        /// <summary>
        ///
        /// </summary>
        RequestBlocked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BlockReasonVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BlockReasonVariant1Type value)
        {
            return value switch
            {
                BlockReasonVariant1Type.RequestBlocked => "request_blocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BlockReasonVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "request_blocked" => BlockReasonVariant1Type.RequestBlocked,
                _ => null,
            };
        }
    }
}