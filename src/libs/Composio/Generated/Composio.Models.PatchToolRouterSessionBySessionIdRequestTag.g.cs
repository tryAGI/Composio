
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchToolRouterSessionBySessionIdRequestTag
    {
        /// <summary>
        ///
        /// </summary>
        DestructiveHint,
        /// <summary>
        ///
        /// </summary>
        IdempotentHint,
        /// <summary>
        ///
        /// </summary>
        OpenWorldHint,
        /// <summary>
        ///
        /// </summary>
        ReadOnlyHint,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchToolRouterSessionBySessionIdRequestTagExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchToolRouterSessionBySessionIdRequestTag value)
        {
            return value switch
            {
                PatchToolRouterSessionBySessionIdRequestTag.DestructiveHint => "destructiveHint",
                PatchToolRouterSessionBySessionIdRequestTag.IdempotentHint => "idempotentHint",
                PatchToolRouterSessionBySessionIdRequestTag.OpenWorldHint => "openWorldHint",
                PatchToolRouterSessionBySessionIdRequestTag.ReadOnlyHint => "readOnlyHint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchToolRouterSessionBySessionIdRequestTag? ToEnum(string value)
        {
            return value switch
            {
                "destructiveHint" => PatchToolRouterSessionBySessionIdRequestTag.DestructiveHint,
                "idempotentHint" => PatchToolRouterSessionBySessionIdRequestTag.IdempotentHint,
                "openWorldHint" => PatchToolRouterSessionBySessionIdRequestTag.OpenWorldHint,
                "readOnlyHint" => PatchToolRouterSessionBySessionIdRequestTag.ReadOnlyHint,
                _ => null,
            };
        }
    }
}