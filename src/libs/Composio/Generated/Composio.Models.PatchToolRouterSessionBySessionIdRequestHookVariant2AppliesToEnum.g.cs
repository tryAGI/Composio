
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchToolRouterSessionBySessionIdRequestHookVariant2AppliesToEnum
    {
        /// <summary>
        ///
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchToolRouterSessionBySessionIdRequestHookVariant2AppliesToEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchToolRouterSessionBySessionIdRequestHookVariant2AppliesToEnum value)
        {
            return value switch
            {
                PatchToolRouterSessionBySessionIdRequestHookVariant2AppliesToEnum.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchToolRouterSessionBySessionIdRequestHookVariant2AppliesToEnum? ToEnum(string value)
        {
            return value switch
            {
                "all" => PatchToolRouterSessionBySessionIdRequestHookVariant2AppliesToEnum.All,
                _ => null,
            };
        }
    }
}