
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchToolRouterSessionBySessionIdResponseConfigTagsEnabledItem
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
    public static class PatchToolRouterSessionBySessionIdResponseConfigTagsEnabledItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchToolRouterSessionBySessionIdResponseConfigTagsEnabledItem value)
        {
            return value switch
            {
                PatchToolRouterSessionBySessionIdResponseConfigTagsEnabledItem.CreateHint => "createHint",
                PatchToolRouterSessionBySessionIdResponseConfigTagsEnabledItem.DestructiveHint => "destructiveHint",
                PatchToolRouterSessionBySessionIdResponseConfigTagsEnabledItem.IdempotentHint => "idempotentHint",
                PatchToolRouterSessionBySessionIdResponseConfigTagsEnabledItem.OpenWorldHint => "openWorldHint",
                PatchToolRouterSessionBySessionIdResponseConfigTagsEnabledItem.ReadOnlyHint => "readOnlyHint",
                PatchToolRouterSessionBySessionIdResponseConfigTagsEnabledItem.UpdateHint => "updateHint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchToolRouterSessionBySessionIdResponseConfigTagsEnabledItem? ToEnum(string value)
        {
            return value switch
            {
                "createHint" => PatchToolRouterSessionBySessionIdResponseConfigTagsEnabledItem.CreateHint,
                "destructiveHint" => PatchToolRouterSessionBySessionIdResponseConfigTagsEnabledItem.DestructiveHint,
                "idempotentHint" => PatchToolRouterSessionBySessionIdResponseConfigTagsEnabledItem.IdempotentHint,
                "openWorldHint" => PatchToolRouterSessionBySessionIdResponseConfigTagsEnabledItem.OpenWorldHint,
                "readOnlyHint" => PatchToolRouterSessionBySessionIdResponseConfigTagsEnabledItem.ReadOnlyHint,
                "updateHint" => PatchToolRouterSessionBySessionIdResponseConfigTagsEnabledItem.UpdateHint,
                _ => null,
            };
        }
    }
}