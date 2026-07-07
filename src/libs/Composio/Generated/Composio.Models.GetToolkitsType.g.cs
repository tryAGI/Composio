
#nullable enable

namespace Composio
{
    /// <summary>
    /// Filter by toolkit provenance: "native" (Composio-managed), "custom" (project-registered custom toolkits), or "all". Takes precedence over managed_by when both are supplied.<br/>
    /// Example: custom
    /// </summary>
    public enum GetToolkitsType
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Custom,
        /// <summary>
        /// 
        /// </summary>
        Native,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetToolkitsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetToolkitsType value)
        {
            return value switch
            {
                GetToolkitsType.All => "all",
                GetToolkitsType.Custom => "custom",
                GetToolkitsType.Native => "native",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetToolkitsType? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetToolkitsType.All,
                "custom" => GetToolkitsType.Custom,
                "native" => GetToolkitsType.Native,
                _ => null,
            };
        }
    }
}