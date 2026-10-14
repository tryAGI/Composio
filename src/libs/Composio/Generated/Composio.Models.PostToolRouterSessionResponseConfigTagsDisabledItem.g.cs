
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PostToolRouterSessionResponseConfigTagsDisabledItem
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
    public static class PostToolRouterSessionResponseConfigTagsDisabledItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionResponseConfigTagsDisabledItem value)
        {
            return value switch
            {
                PostToolRouterSessionResponseConfigTagsDisabledItem.CreateHint => "createHint",
                PostToolRouterSessionResponseConfigTagsDisabledItem.DestructiveHint => "destructiveHint",
                PostToolRouterSessionResponseConfigTagsDisabledItem.IdempotentHint => "idempotentHint",
                PostToolRouterSessionResponseConfigTagsDisabledItem.OpenWorldHint => "openWorldHint",
                PostToolRouterSessionResponseConfigTagsDisabledItem.ReadOnlyHint => "readOnlyHint",
                PostToolRouterSessionResponseConfigTagsDisabledItem.UpdateHint => "updateHint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionResponseConfigTagsDisabledItem? ToEnum(string value)
        {
            return value switch
            {
                "createHint" => PostToolRouterSessionResponseConfigTagsDisabledItem.CreateHint,
                "destructiveHint" => PostToolRouterSessionResponseConfigTagsDisabledItem.DestructiveHint,
                "idempotentHint" => PostToolRouterSessionResponseConfigTagsDisabledItem.IdempotentHint,
                "openWorldHint" => PostToolRouterSessionResponseConfigTagsDisabledItem.OpenWorldHint,
                "readOnlyHint" => PostToolRouterSessionResponseConfigTagsDisabledItem.ReadOnlyHint,
                "updateHint" => PostToolRouterSessionResponseConfigTagsDisabledItem.UpdateHint,
                _ => null,
            };
        }
    }
}