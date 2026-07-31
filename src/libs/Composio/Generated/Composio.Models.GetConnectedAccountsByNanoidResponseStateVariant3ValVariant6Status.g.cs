
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConnectedAccountsByNanoidResponseStateVariant3ValVariant6Status
    {
        /// <summary>
        /// 
        /// </summary>
        Expired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConnectedAccountsByNanoidResponseStateVariant3ValVariant6StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsByNanoidResponseStateVariant3ValVariant6Status value)
        {
            return value switch
            {
                GetConnectedAccountsByNanoidResponseStateVariant3ValVariant6Status.Expired => "EXPIRED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsByNanoidResponseStateVariant3ValVariant6Status? ToEnum(string value)
        {
            return value switch
            {
                "EXPIRED" => GetConnectedAccountsByNanoidResponseStateVariant3ValVariant6Status.Expired,
                _ => null,
            };
        }
    }
}