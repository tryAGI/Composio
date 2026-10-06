
#nullable enable

namespace Composio
{
    /// <summary>
    /// [EXPERIMENTAL] Custom toolkits only. "all": every user in the project can use it. "user": only the user it was created for can.<br/>
    /// Example: all
    /// </summary>
    public enum GetToolkitsBySlugResponseAccess
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
    public static class GetToolkitsBySlugResponseAccessExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetToolkitsBySlugResponseAccess value)
        {
            return value switch
            {
                GetToolkitsBySlugResponseAccess.All => "all",
                GetToolkitsBySlugResponseAccess.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetToolkitsBySlugResponseAccess? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetToolkitsBySlugResponseAccess.All,
                "user" => GetToolkitsBySlugResponseAccess.User,
                _ => null,
            };
        }
    }
}