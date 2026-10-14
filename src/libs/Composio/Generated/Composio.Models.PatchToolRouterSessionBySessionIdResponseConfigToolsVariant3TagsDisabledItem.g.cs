
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem
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
    public static class PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem value)
        {
            return value switch
            {
                PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem.CreateHint => "createHint",
                PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem.DestructiveHint => "destructiveHint",
                PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem.IdempotentHint => "idempotentHint",
                PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem.OpenWorldHint => "openWorldHint",
                PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem.ReadOnlyHint => "readOnlyHint",
                PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem.UpdateHint => "updateHint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem? ToEnum(string value)
        {
            return value switch
            {
                "createHint" => PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem.CreateHint,
                "destructiveHint" => PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem.DestructiveHint,
                "idempotentHint" => PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem.IdempotentHint,
                "openWorldHint" => PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem.OpenWorldHint,
                "readOnlyHint" => PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem.ReadOnlyHint,
                "updateHint" => PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsDisabledItem.UpdateHint,
                _ => null,
            };
        }
    }
}