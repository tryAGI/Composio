
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public enum PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsDisableItem
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
    public static class PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsDisableItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsDisableItem value)
        {
            return value switch
            {
                PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsDisableItem.DestructiveHint => "destructiveHint",
                PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsDisableItem.IdempotentHint => "idempotentHint",
                PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsDisableItem.OpenWorldHint => "openWorldHint",
                PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsDisableItem.ReadOnlyHint => "readOnlyHint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsDisableItem? ToEnum(string value)
        {
            return value switch
            {
                "destructiveHint" => PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsDisableItem.DestructiveHint,
                "idempotentHint" => PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsDisableItem.IdempotentHint,
                "openWorldHint" => PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsDisableItem.OpenWorldHint,
                "readOnlyHint" => PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsDisableItem.ReadOnlyHint,
                _ => null,
            };
        }
    }
}