
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PostToolRouterSessionResponseConfigToolsVariant3TagsRequireApprovalItem
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
    public static class PostToolRouterSessionResponseConfigToolsVariant3TagsRequireApprovalItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionResponseConfigToolsVariant3TagsRequireApprovalItem value)
        {
            return value switch
            {
                PostToolRouterSessionResponseConfigToolsVariant3TagsRequireApprovalItem.CreateHint => "createHint",
                PostToolRouterSessionResponseConfigToolsVariant3TagsRequireApprovalItem.DestructiveHint => "destructiveHint",
                PostToolRouterSessionResponseConfigToolsVariant3TagsRequireApprovalItem.IdempotentHint => "idempotentHint",
                PostToolRouterSessionResponseConfigToolsVariant3TagsRequireApprovalItem.OpenWorldHint => "openWorldHint",
                PostToolRouterSessionResponseConfigToolsVariant3TagsRequireApprovalItem.ReadOnlyHint => "readOnlyHint",
                PostToolRouterSessionResponseConfigToolsVariant3TagsRequireApprovalItem.UpdateHint => "updateHint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionResponseConfigToolsVariant3TagsRequireApprovalItem? ToEnum(string value)
        {
            return value switch
            {
                "createHint" => PostToolRouterSessionResponseConfigToolsVariant3TagsRequireApprovalItem.CreateHint,
                "destructiveHint" => PostToolRouterSessionResponseConfigToolsVariant3TagsRequireApprovalItem.DestructiveHint,
                "idempotentHint" => PostToolRouterSessionResponseConfigToolsVariant3TagsRequireApprovalItem.IdempotentHint,
                "openWorldHint" => PostToolRouterSessionResponseConfigToolsVariant3TagsRequireApprovalItem.OpenWorldHint,
                "readOnlyHint" => PostToolRouterSessionResponseConfigToolsVariant3TagsRequireApprovalItem.ReadOnlyHint,
                "updateHint" => PostToolRouterSessionResponseConfigToolsVariant3TagsRequireApprovalItem.UpdateHint,
                _ => null,
            };
        }
    }
}