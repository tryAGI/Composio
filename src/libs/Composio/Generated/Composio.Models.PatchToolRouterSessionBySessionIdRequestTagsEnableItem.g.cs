
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchToolRouterSessionBySessionIdRequestTagsEnableItem
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
    public static class PatchToolRouterSessionBySessionIdRequestTagsEnableItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchToolRouterSessionBySessionIdRequestTagsEnableItem value)
        {
            return value switch
            {
                PatchToolRouterSessionBySessionIdRequestTagsEnableItem.DestructiveHint => "destructiveHint",
                PatchToolRouterSessionBySessionIdRequestTagsEnableItem.IdempotentHint => "idempotentHint",
                PatchToolRouterSessionBySessionIdRequestTagsEnableItem.OpenWorldHint => "openWorldHint",
                PatchToolRouterSessionBySessionIdRequestTagsEnableItem.ReadOnlyHint => "readOnlyHint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchToolRouterSessionBySessionIdRequestTagsEnableItem? ToEnum(string value)
        {
            return value switch
            {
                "destructiveHint" => PatchToolRouterSessionBySessionIdRequestTagsEnableItem.DestructiveHint,
                "idempotentHint" => PatchToolRouterSessionBySessionIdRequestTagsEnableItem.IdempotentHint,
                "openWorldHint" => PatchToolRouterSessionBySessionIdRequestTagsEnableItem.OpenWorldHint,
                "readOnlyHint" => PatchToolRouterSessionBySessionIdRequestTagsEnableItem.ReadOnlyHint,
                _ => null,
            };
        }
    }
}