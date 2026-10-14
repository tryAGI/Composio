
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PostToolRouterSessionResponseConfigToolsVariant3TagsDisabledItem
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
    public static class PostToolRouterSessionResponseConfigToolsVariant3TagsDisabledItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionResponseConfigToolsVariant3TagsDisabledItem value)
        {
            return value switch
            {
                PostToolRouterSessionResponseConfigToolsVariant3TagsDisabledItem.CreateHint => "createHint",
                PostToolRouterSessionResponseConfigToolsVariant3TagsDisabledItem.DestructiveHint => "destructiveHint",
                PostToolRouterSessionResponseConfigToolsVariant3TagsDisabledItem.IdempotentHint => "idempotentHint",
                PostToolRouterSessionResponseConfigToolsVariant3TagsDisabledItem.OpenWorldHint => "openWorldHint",
                PostToolRouterSessionResponseConfigToolsVariant3TagsDisabledItem.ReadOnlyHint => "readOnlyHint",
                PostToolRouterSessionResponseConfigToolsVariant3TagsDisabledItem.UpdateHint => "updateHint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionResponseConfigToolsVariant3TagsDisabledItem? ToEnum(string value)
        {
            return value switch
            {
                "createHint" => PostToolRouterSessionResponseConfigToolsVariant3TagsDisabledItem.CreateHint,
                "destructiveHint" => PostToolRouterSessionResponseConfigToolsVariant3TagsDisabledItem.DestructiveHint,
                "idempotentHint" => PostToolRouterSessionResponseConfigToolsVariant3TagsDisabledItem.IdempotentHint,
                "openWorldHint" => PostToolRouterSessionResponseConfigToolsVariant3TagsDisabledItem.OpenWorldHint,
                "readOnlyHint" => PostToolRouterSessionResponseConfigToolsVariant3TagsDisabledItem.ReadOnlyHint,
                "updateHint" => PostToolRouterSessionResponseConfigToolsVariant3TagsDisabledItem.UpdateHint,
                _ => null,
            };
        }
    }
}