
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PostToolRouterSessionRequestToolsVariant3TagsDisableItem
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
    public static class PostToolRouterSessionRequestToolsVariant3TagsDisableItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionRequestToolsVariant3TagsDisableItem value)
        {
            return value switch
            {
                PostToolRouterSessionRequestToolsVariant3TagsDisableItem.CreateHint => "createHint",
                PostToolRouterSessionRequestToolsVariant3TagsDisableItem.DestructiveHint => "destructiveHint",
                PostToolRouterSessionRequestToolsVariant3TagsDisableItem.IdempotentHint => "idempotentHint",
                PostToolRouterSessionRequestToolsVariant3TagsDisableItem.OpenWorldHint => "openWorldHint",
                PostToolRouterSessionRequestToolsVariant3TagsDisableItem.ReadOnlyHint => "readOnlyHint",
                PostToolRouterSessionRequestToolsVariant3TagsDisableItem.UpdateHint => "updateHint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionRequestToolsVariant3TagsDisableItem? ToEnum(string value)
        {
            return value switch
            {
                "createHint" => PostToolRouterSessionRequestToolsVariant3TagsDisableItem.CreateHint,
                "destructiveHint" => PostToolRouterSessionRequestToolsVariant3TagsDisableItem.DestructiveHint,
                "idempotentHint" => PostToolRouterSessionRequestToolsVariant3TagsDisableItem.IdempotentHint,
                "openWorldHint" => PostToolRouterSessionRequestToolsVariant3TagsDisableItem.OpenWorldHint,
                "readOnlyHint" => PostToolRouterSessionRequestToolsVariant3TagsDisableItem.ReadOnlyHint,
                "updateHint" => PostToolRouterSessionRequestToolsVariant3TagsDisableItem.UpdateHint,
                _ => null,
            };
        }
    }
}