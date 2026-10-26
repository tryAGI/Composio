
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum GetToolRouterSessionBySessionIdResponseConfigHookVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        AfterExecute,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetToolRouterSessionBySessionIdResponseConfigHookVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetToolRouterSessionBySessionIdResponseConfigHookVariant2Type value)
        {
            return value switch
            {
                GetToolRouterSessionBySessionIdResponseConfigHookVariant2Type.AfterExecute => "after_execute",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetToolRouterSessionBySessionIdResponseConfigHookVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "after_execute" => GetToolRouterSessionBySessionIdResponseConfigHookVariant2Type.AfterExecute,
                _ => null,
            };
        }
    }
}