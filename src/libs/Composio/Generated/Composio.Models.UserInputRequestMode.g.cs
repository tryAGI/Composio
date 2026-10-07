
#nullable enable

namespace Composio
{
    /// <summary>
    /// Always `form`: collect the answer with a form built from `requested_schema`
    /// </summary>
    public enum UserInputRequestMode
    {
        /// <summary>
        /// collect the answer with a form built from `requested_schema`
        /// </summary>
        Form,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserInputRequestModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserInputRequestMode value)
        {
            return value switch
            {
                UserInputRequestMode.Form => "form",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserInputRequestMode? ToEnum(string value)
        {
            return value switch
            {
                "form" => UserInputRequestMode.Form,
                _ => null,
            };
        }
    }
}