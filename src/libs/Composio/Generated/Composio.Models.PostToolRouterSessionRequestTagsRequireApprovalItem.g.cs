
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PostToolRouterSessionRequestTagsRequireApprovalItem
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
    public static class PostToolRouterSessionRequestTagsRequireApprovalItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionRequestTagsRequireApprovalItem value)
        {
            return value switch
            {
                PostToolRouterSessionRequestTagsRequireApprovalItem.DestructiveHint => "destructiveHint",
                PostToolRouterSessionRequestTagsRequireApprovalItem.IdempotentHint => "idempotentHint",
                PostToolRouterSessionRequestTagsRequireApprovalItem.OpenWorldHint => "openWorldHint",
                PostToolRouterSessionRequestTagsRequireApprovalItem.ReadOnlyHint => "readOnlyHint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionRequestTagsRequireApprovalItem? ToEnum(string value)
        {
            return value switch
            {
                "destructiveHint" => PostToolRouterSessionRequestTagsRequireApprovalItem.DestructiveHint,
                "idempotentHint" => PostToolRouterSessionRequestTagsRequireApprovalItem.IdempotentHint,
                "openWorldHint" => PostToolRouterSessionRequestTagsRequireApprovalItem.OpenWorldHint,
                "readOnlyHint" => PostToolRouterSessionRequestTagsRequireApprovalItem.ReadOnlyHint,
                _ => null,
            };
        }
    }
}