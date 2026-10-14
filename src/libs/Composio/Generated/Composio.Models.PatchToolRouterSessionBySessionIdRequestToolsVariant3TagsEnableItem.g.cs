
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsEnableItem
    {
        /// <summary>
        ///
        /// </summary>
        CreateHint,
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
        /// <summary>
        ///
        /// </summary>
        UpdateHint,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsEnableItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsEnableItem value)
        {
            return value switch
            {
                PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsEnableItem.CreateHint => "createHint",
                PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsEnableItem.DestructiveHint => "destructiveHint",
                PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsEnableItem.IdempotentHint => "idempotentHint",
                PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsEnableItem.OpenWorldHint => "openWorldHint",
                PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsEnableItem.ReadOnlyHint => "readOnlyHint",
                PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsEnableItem.UpdateHint => "updateHint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsEnableItem? ToEnum(string value)
        {
            return value switch
            {
                "createHint" => PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsEnableItem.CreateHint,
                "destructiveHint" => PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsEnableItem.DestructiveHint,
                "idempotentHint" => PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsEnableItem.IdempotentHint,
                "openWorldHint" => PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsEnableItem.OpenWorldHint,
                "readOnlyHint" => PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsEnableItem.ReadOnlyHint,
                "updateHint" => PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsEnableItem.UpdateHint,
                _ => null,
            };
        }
    }
}