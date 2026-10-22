
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchToolRouterSessionBySessionIdResponseConfigHookVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        AfterExecute,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchToolRouterSessionBySessionIdResponseConfigHookVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchToolRouterSessionBySessionIdResponseConfigHookVariant2Type value)
        {
            return value switch
            {
                PatchToolRouterSessionBySessionIdResponseConfigHookVariant2Type.AfterExecute => "after_execute",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchToolRouterSessionBySessionIdResponseConfigHookVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "after_execute" => PatchToolRouterSessionBySessionIdResponseConfigHookVariant2Type.AfterExecute,
                _ => null,
            };
        }
    }
}