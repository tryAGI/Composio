
#nullable enable

namespace Composio
{
    /// <summary>
    /// Always `elicitation`
    /// </summary>
    public enum UserInputRequestType
    {
        /// <summary>
        ///
        /// </summary>
        Elicitation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserInputRequestTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserInputRequestType value)
        {
            return value switch
            {
                UserInputRequestType.Elicitation => "elicitation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserInputRequestType? ToEnum(string value)
        {
            return value switch
            {
                "elicitation" => UserInputRequestType.Elicitation,
                _ => null,
            };
        }
    }
}