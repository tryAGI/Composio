
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum GetConnectedAccountsByNanoidResponseStateVariant15ValVariant3Status
    {
        /// <summary>
        ///
        /// </summary>
        Active,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConnectedAccountsByNanoidResponseStateVariant15ValVariant3StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsByNanoidResponseStateVariant15ValVariant3Status value)
        {
            return value switch
            {
                GetConnectedAccountsByNanoidResponseStateVariant15ValVariant3Status.Active => "ACTIVE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsByNanoidResponseStateVariant15ValVariant3Status? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => GetConnectedAccountsByNanoidResponseStateVariant15ValVariant3Status.Active,
                _ => null,
            };
        }
    }
}