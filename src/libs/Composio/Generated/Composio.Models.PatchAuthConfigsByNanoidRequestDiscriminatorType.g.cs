
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchAuthConfigsByNanoidRequestDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Custom,
        /// <summary>
        ///
        /// </summary>
        Default,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchAuthConfigsByNanoidRequestDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchAuthConfigsByNanoidRequestDiscriminatorType value)
        {
            return value switch
            {
                PatchAuthConfigsByNanoidRequestDiscriminatorType.Custom => "custom",
                PatchAuthConfigsByNanoidRequestDiscriminatorType.Default => "default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchAuthConfigsByNanoidRequestDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "custom" => PatchAuthConfigsByNanoidRequestDiscriminatorType.Custom,
                "default" => PatchAuthConfigsByNanoidRequestDiscriminatorType.Default,
                _ => null,
            };
        }
    }
}