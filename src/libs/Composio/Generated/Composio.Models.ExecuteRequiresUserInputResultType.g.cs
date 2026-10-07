
#nullable enable

namespace Composio
{
    /// <summary>
    /// The call needs the user's input before it runs
    /// </summary>
    public enum ExecuteRequiresUserInputResultType
    {
        /// <summary>
        ///
        /// </summary>
        InputRequired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExecuteRequiresUserInputResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExecuteRequiresUserInputResultType value)
        {
            return value switch
            {
                ExecuteRequiresUserInputResultType.InputRequired => "input_required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExecuteRequiresUserInputResultType? ToEnum(string value)
        {
            return value switch
            {
                "input_required" => ExecuteRequiresUserInputResultType.InputRequired,
                _ => null,
            };
        }
    }
}