
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum GetToolRouterSessionBySessionIdResponseConfigTagsRequireApprovalItem
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
    public static class GetToolRouterSessionBySessionIdResponseConfigTagsRequireApprovalItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetToolRouterSessionBySessionIdResponseConfigTagsRequireApprovalItem value)
        {
            return value switch
            {
                GetToolRouterSessionBySessionIdResponseConfigTagsRequireApprovalItem.CreateHint => "createHint",
                GetToolRouterSessionBySessionIdResponseConfigTagsRequireApprovalItem.DestructiveHint => "destructiveHint",
                GetToolRouterSessionBySessionIdResponseConfigTagsRequireApprovalItem.IdempotentHint => "idempotentHint",
                GetToolRouterSessionBySessionIdResponseConfigTagsRequireApprovalItem.OpenWorldHint => "openWorldHint",
                GetToolRouterSessionBySessionIdResponseConfigTagsRequireApprovalItem.ReadOnlyHint => "readOnlyHint",
                GetToolRouterSessionBySessionIdResponseConfigTagsRequireApprovalItem.UpdateHint => "updateHint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetToolRouterSessionBySessionIdResponseConfigTagsRequireApprovalItem? ToEnum(string value)
        {
            return value switch
            {
                "createHint" => GetToolRouterSessionBySessionIdResponseConfigTagsRequireApprovalItem.CreateHint,
                "destructiveHint" => GetToolRouterSessionBySessionIdResponseConfigTagsRequireApprovalItem.DestructiveHint,
                "idempotentHint" => GetToolRouterSessionBySessionIdResponseConfigTagsRequireApprovalItem.IdempotentHint,
                "openWorldHint" => GetToolRouterSessionBySessionIdResponseConfigTagsRequireApprovalItem.OpenWorldHint,
                "readOnlyHint" => GetToolRouterSessionBySessionIdResponseConfigTagsRequireApprovalItem.ReadOnlyHint,
                "updateHint" => GetToolRouterSessionBySessionIdResponseConfigTagsRequireApprovalItem.UpdateHint,
                _ => null,
            };
        }
    }
}