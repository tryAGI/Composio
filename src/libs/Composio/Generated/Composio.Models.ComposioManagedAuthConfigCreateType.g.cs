
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public enum ComposioManagedAuthConfigCreateType
    {
        /// <summary>
        /// 
        /// </summary>
        UseComposioManagedAuth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComposioManagedAuthConfigCreateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComposioManagedAuthConfigCreateType value)
        {
            return value switch
            {
                ComposioManagedAuthConfigCreateType.UseComposioManagedAuth => "use_composio_managed_auth",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComposioManagedAuthConfigCreateType? ToEnum(string value)
        {
            return value switch
            {
                "use_composio_managed_auth" => ComposioManagedAuthConfigCreateType.UseComposioManagedAuth,
                _ => null,
            };
        }
    }
}