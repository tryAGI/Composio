
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PostToolRouterSessionResponseConfigTagsRequireApprovalItem
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
    public static class PostToolRouterSessionResponseConfigTagsRequireApprovalItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionResponseConfigTagsRequireApprovalItem value)
        {
            return value switch
            {
                PostToolRouterSessionResponseConfigTagsRequireApprovalItem.CreateHint => "createHint",
                PostToolRouterSessionResponseConfigTagsRequireApprovalItem.DestructiveHint => "destructiveHint",
                PostToolRouterSessionResponseConfigTagsRequireApprovalItem.IdempotentHint => "idempotentHint",
                PostToolRouterSessionResponseConfigTagsRequireApprovalItem.OpenWorldHint => "openWorldHint",
                PostToolRouterSessionResponseConfigTagsRequireApprovalItem.ReadOnlyHint => "readOnlyHint",
                PostToolRouterSessionResponseConfigTagsRequireApprovalItem.UpdateHint => "updateHint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionResponseConfigTagsRequireApprovalItem? ToEnum(string value)
        {
            return value switch
            {
                "createHint" => PostToolRouterSessionResponseConfigTagsRequireApprovalItem.CreateHint,
                "destructiveHint" => PostToolRouterSessionResponseConfigTagsRequireApprovalItem.DestructiveHint,
                "idempotentHint" => PostToolRouterSessionResponseConfigTagsRequireApprovalItem.IdempotentHint,
                "openWorldHint" => PostToolRouterSessionResponseConfigTagsRequireApprovalItem.OpenWorldHint,
                "readOnlyHint" => PostToolRouterSessionResponseConfigTagsRequireApprovalItem.ReadOnlyHint,
                "updateHint" => PostToolRouterSessionResponseConfigTagsRequireApprovalItem.UpdateHint,
                _ => null,
            };
        }
    }
}