
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum GetToolkitsResponseItemAccess
    {
        /// <summary>
        ///
        /// </summary>
        All,
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
                _ => null,
            };
        }
    }
}