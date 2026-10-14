
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
    public static class PostToolRouterSessionRequestTagsRequireApprovalItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionRequestTagsRequireApprovalItem value)
        {
            return value switch
            {
                PostToolRouterSessionRequestTagsRequireApprovalItem.CreateHint => "createHint",
                PostToolRouterSessionRequestTagsRequireApprovalItem.DestructiveHint => "destructiveHint",
                PostToolRouterSessionRequestTagsRequireApprovalItem.IdempotentHint => "idempotentHint",
                PostToolRouterSessionRequestTagsRequireApprovalItem.OpenWorldHint => "openWorldHint",
                PostToolRouterSessionRequestTagsRequireApprovalItem.ReadOnlyHint => "readOnlyHint",
                PostToolRouterSessionRequestTagsRequireApprovalItem.UpdateHint => "updateHint",
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
                "createHint" => PostToolRouterSessionRequestTagsRequireApprovalItem.CreateHint,
                "destructiveHint" => PostToolRouterSessionRequestTagsRequireApprovalItem.DestructiveHint,
                "idempotentHint" => PostToolRouterSessionRequestTagsRequireApprovalItem.IdempotentHint,
                "openWorldHint" => PostToolRouterSessionRequestTagsRequireApprovalItem.OpenWorldHint,
                "readOnlyHint" => PostToolRouterSessionRequestTagsRequireApprovalItem.ReadOnlyHint,
                "updateHint" => PostToolRouterSessionRequestTagsRequireApprovalItem.UpdateHint,
                _ => null,
            };
        }
    }
}