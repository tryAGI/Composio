
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchToolRouterSessionBySessionIdResponseConfigTagsDisabledItem
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
    public static class PatchToolRouterSessionBySessionIdResponseConfigTagsDisabledItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchToolRouterSessionBySessionIdResponseConfigTagsDisabledItem value)
        {
            return value switch
            {
                PatchToolRouterSessionBySessionIdResponseConfigTagsDisabledItem.CreateHint => "createHint",
                PatchToolRouterSessionBySessionIdResponseConfigTagsDisabledItem.DestructiveHint => "destructiveHint",
                PatchToolRouterSessionBySessionIdResponseConfigTagsDisabledItem.IdempotentHint => "idempotentHint",
                PatchToolRouterSessionBySessionIdResponseConfigTagsDisabledItem.OpenWorldHint => "openWorldHint",
                PatchToolRouterSessionBySessionIdResponseConfigTagsDisabledItem.ReadOnlyHint => "readOnlyHint",
                PatchToolRouterSessionBySessionIdResponseConfigTagsDisabledItem.UpdateHint => "updateHint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchToolRouterSessionBySessionIdResponseConfigTagsDisabledItem? ToEnum(string value)
        {
            return value switch
            {
                "createHint" => PatchToolRouterSessionBySessionIdResponseConfigTagsDisabledItem.CreateHint,
                "destructiveHint" => PatchToolRouterSessionBySessionIdResponseConfigTagsDisabledItem.DestructiveHint,
                "idempotentHint" => PatchToolRouterSessionBySessionIdResponseConfigTagsDisabledItem.IdempotentHint,
                "openWorldHint" => PatchToolRouterSessionBySessionIdResponseConfigTagsDisabledItem.OpenWorldHint,
                "readOnlyHint" => PatchToolRouterSessionBySessionIdResponseConfigTagsDisabledItem.ReadOnlyHint,
                "updateHint" => PatchToolRouterSessionBySessionIdResponseConfigTagsDisabledItem.UpdateHint,
                _ => null,
            };
        }
    }
}