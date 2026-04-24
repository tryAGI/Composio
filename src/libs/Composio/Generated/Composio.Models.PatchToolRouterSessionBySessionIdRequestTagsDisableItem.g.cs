
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchToolRouterSessionBySessionIdRequestTagsDisableItem
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
    public static class PatchToolRouterSessionBySessionIdRequestTagsDisableItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchToolRouterSessionBySessionIdRequestTagsDisableItem value)
        {
            return value switch
            {
                PatchToolRouterSessionBySessionIdRequestTagsDisableItem.DestructiveHint => "destructiveHint",
                PatchToolRouterSessionBySessionIdRequestTagsDisableItem.IdempotentHint => "idempotentHint",
                PatchToolRouterSessionBySessionIdRequestTagsDisableItem.OpenWorldHint => "openWorldHint",
                PatchToolRouterSessionBySessionIdRequestTagsDisableItem.ReadOnlyHint => "readOnlyHint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchToolRouterSessionBySessionIdRequestTagsDisableItem? ToEnum(string value)
        {
            return value switch
            {
                "destructiveHint" => PatchToolRouterSessionBySessionIdRequestTagsDisableItem.DestructiveHint,
                "idempotentHint" => PatchToolRouterSessionBySessionIdRequestTagsDisableItem.IdempotentHint,
                "openWorldHint" => PatchToolRouterSessionBySessionIdRequestTagsDisableItem.OpenWorldHint,
                "readOnlyHint" => PatchToolRouterSessionBySessionIdRequestTagsDisableItem.ReadOnlyHint,
                _ => null,
            };
        }
    }
}