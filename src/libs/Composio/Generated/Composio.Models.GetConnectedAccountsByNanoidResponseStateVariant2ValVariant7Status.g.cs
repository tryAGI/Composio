
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConnectedAccountsByNanoidResponseStateVariant2ValVariant7Status
    {
        /// <summary>
        /// 
        /// </summary>
        Revoked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConnectedAccountsByNanoidResponseStateVariant2ValVariant7StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsByNanoidResponseStateVariant2ValVariant7Status value)
        {
            return value switch
            {
                GetConnectedAccountsByNanoidResponseStateVariant2ValVariant7Status.Revoked => "REVOKED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsByNanoidResponseStateVariant2ValVariant7Status? ToEnum(string value)
        {
            return value switch
            {
                "REVOKED" => GetConnectedAccountsByNanoidResponseStateVariant2ValVariant7Status.Revoked,
                _ => null,
            };
        }
    }
}