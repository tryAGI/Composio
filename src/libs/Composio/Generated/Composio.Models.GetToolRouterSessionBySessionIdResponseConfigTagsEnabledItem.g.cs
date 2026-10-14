
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum GetToolRouterSessionBySessionIdResponseConfigTagsEnabledItem
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
    public static class GetToolRouterSessionBySessionIdResponseConfigTagsEnabledItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetToolRouterSessionBySessionIdResponseConfigTagsEnabledItem value)
        {
            return value switch
            {
                GetToolRouterSessionBySessionIdResponseConfigTagsEnabledItem.CreateHint => "createHint",
                GetToolRouterSessionBySessionIdResponseConfigTagsEnabledItem.DestructiveHint => "destructiveHint",
                GetToolRouterSessionBySessionIdResponseConfigTagsEnabledItem.IdempotentHint => "idempotentHint",
                GetToolRouterSessionBySessionIdResponseConfigTagsEnabledItem.OpenWorldHint => "openWorldHint",
                GetToolRouterSessionBySessionIdResponseConfigTagsEnabledItem.ReadOnlyHint => "readOnlyHint",
                GetToolRouterSessionBySessionIdResponseConfigTagsEnabledItem.UpdateHint => "updateHint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetToolRouterSessionBySessionIdResponseConfigTagsEnabledItem? ToEnum(string value)
        {
            return value switch
            {
                "createHint" => GetToolRouterSessionBySessionIdResponseConfigTagsEnabledItem.CreateHint,
                "destructiveHint" => GetToolRouterSessionBySessionIdResponseConfigTagsEnabledItem.DestructiveHint,
                "idempotentHint" => GetToolRouterSessionBySessionIdResponseConfigTagsEnabledItem.IdempotentHint,
                "openWorldHint" => GetToolRouterSessionBySessionIdResponseConfigTagsEnabledItem.OpenWorldHint,
                "readOnlyHint" => GetToolRouterSessionBySessionIdResponseConfigTagsEnabledItem.ReadOnlyHint,
                "updateHint" => GetToolRouterSessionBySessionIdResponseConfigTagsEnabledItem.UpdateHint,
                _ => null,
            };
        }
    }
}