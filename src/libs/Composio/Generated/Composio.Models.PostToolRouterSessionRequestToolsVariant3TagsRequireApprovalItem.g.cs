
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PostToolRouterSessionRequestToolsVariant3TagsRequireApprovalItem
    {
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolRouterSessionRequestToolsVariant3TagsRequireApprovalItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionRequestToolsVariant3TagsRequireApprovalItem value)
        {
            return value switch
            {
                PostToolRouterSessionRequestToolsVariant3TagsRequireApprovalItem.DestructiveHint => "destructiveHint",
                PostToolRouterSessionRequestToolsVariant3TagsRequireApprovalItem.IdempotentHint => "idempotentHint",
                PostToolRouterSessionRequestToolsVariant3TagsRequireApprovalItem.OpenWorldHint => "openWorldHint",
                PostToolRouterSessionRequestToolsVariant3TagsRequireApprovalItem.ReadOnlyHint => "readOnlyHint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionRequestToolsVariant3TagsRequireApprovalItem? ToEnum(string value)
        {
            return value switch
            {
                "destructiveHint" => PostToolRouterSessionRequestToolsVariant3TagsRequireApprovalItem.DestructiveHint,
                "idempotentHint" => PostToolRouterSessionRequestToolsVariant3TagsRequireApprovalItem.IdempotentHint,
                "openWorldHint" => PostToolRouterSessionRequestToolsVariant3TagsRequireApprovalItem.OpenWorldHint,
                "readOnlyHint" => PostToolRouterSessionRequestToolsVariant3TagsRequireApprovalItem.ReadOnlyHint,
                _ => null,
            };
        }
    }
}