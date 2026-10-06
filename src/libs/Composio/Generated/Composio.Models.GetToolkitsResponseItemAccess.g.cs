
#nullable enable

namespace Composio
{
    /// <summary>
    /// [EXPERIMENTAL] Custom toolkits only. "all": every user in the project can use it. "user": only the user it was created for can.<br/>
    /// Example: all
    /// </summary>
    public enum GetToolkitsResponseItemAccess
    {
        /// <summary>
        /// every user in the project can use it. "user": only the user it was created for can.
        /// </summary>
        All,
        /// <summary>
        /// every user in the project can use it. "user": only the user it was created for can.
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetToolkitsResponseItemAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetToolkitsResponseItemAccess value)
        {
            return value switch
            {
                GetToolkitsResponseItemAccess.All => "all",
                GetToolkitsResponseItemAccess.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetToolkitsResponseItemAccess? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetToolkitsResponseItemAccess.All,
                "user" => GetToolkitsResponseItemAccess.User,
                _ => null,
            };
        }
    }
}