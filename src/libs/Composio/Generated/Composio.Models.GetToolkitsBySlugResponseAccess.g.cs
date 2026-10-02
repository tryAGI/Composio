
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum GetToolkitsBySlugResponseAccess
    {
        /// <summary>
        ///
        /// </summary>
        All,
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
                _ => null,
            };
        }
    }
}