
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PostToolRouterSessionRequestTagsEnableItem
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
    public static class PostToolRouterSessionRequestTagsEnableItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionRequestTagsEnableItem value)
        {
            return value switch
            {
                PostToolRouterSessionRequestTagsEnableItem.CreateHint => "createHint",
                PostToolRouterSessionRequestTagsEnableItem.DestructiveHint => "destructiveHint",
                PostToolRouterSessionRequestTagsEnableItem.IdempotentHint => "idempotentHint",
                PostToolRouterSessionRequestTagsEnableItem.OpenWorldHint => "openWorldHint",
                PostToolRouterSessionRequestTagsEnableItem.ReadOnlyHint => "readOnlyHint",
                PostToolRouterSessionRequestTagsEnableItem.UpdateHint => "updateHint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionRequestTagsEnableItem? ToEnum(string value)
        {
            return value switch
            {
                "createHint" => PostToolRouterSessionRequestTagsEnableItem.CreateHint,
                "destructiveHint" => PostToolRouterSessionRequestTagsEnableItem.DestructiveHint,
                "idempotentHint" => PostToolRouterSessionRequestTagsEnableItem.IdempotentHint,
                "openWorldHint" => PostToolRouterSessionRequestTagsEnableItem.OpenWorldHint,
                "readOnlyHint" => PostToolRouterSessionRequestTagsEnableItem.ReadOnlyHint,
                "updateHint" => PostToolRouterSessionRequestTagsEnableItem.UpdateHint,
                _ => null,
            };
        }
    }
}