
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public enum CustomAuthConfigCreateType
    {
        /// <summary>
        /// 
        /// </summary>
        UseCustomAuth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomAuthConfigCreateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomAuthConfigCreateType value)
        {
            return value switch
            {
                CustomAuthConfigCreateType.UseCustomAuth => "use_custom_auth",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomAuthConfigCreateType? ToEnum(string value)
        {
            return value switch
            {
                "use_custom_auth" => CustomAuthConfigCreateType.UseCustomAuth,
                _ => null,
            };
        }
    }
}