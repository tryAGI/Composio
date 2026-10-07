
#nullable enable

namespace Composio
{
    /// <summary>
    /// `accept` when the user submitted the form, `decline` when they said no, `cancel` when they dismissed it
    /// </summary>
    public enum UserInputResponseAction
    {
        /// <summary>
        ///
        /// </summary>
        Accept,
        /// <summary>
        ///
        /// </summary>
        Cancel,
        /// <summary>
        ///
        /// </summary>
        Decline,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserInputResponseActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserInputResponseAction value)
        {
            return value switch
            {
                UserInputResponseAction.Accept => "accept",
                UserInputResponseAction.Cancel => "cancel",
                UserInputResponseAction.Decline => "decline",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserInputResponseAction? ToEnum(string value)
        {
            return value switch
            {
                "accept" => UserInputResponseAction.Accept,
                "cancel" => UserInputResponseAction.Cancel,
                "decline" => UserInputResponseAction.Decline,
                _ => null,
            };
        }
    }
}