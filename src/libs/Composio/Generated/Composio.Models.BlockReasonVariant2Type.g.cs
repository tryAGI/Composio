
#nullable enable

namespace Composio
{
    /// <summary>
    /// An after_execute hook stopped the call. The tool ran; its response was withheld.
    /// </summary>
    public enum BlockReasonVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        ResponseBlocked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BlockReasonVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BlockReasonVariant2Type value)
        {
            return value switch
            {
                BlockReasonVariant2Type.ResponseBlocked => "response_blocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BlockReasonVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "response_blocked" => BlockReasonVariant2Type.ResponseBlocked,
                _ => null,
            };
        }
    }
}