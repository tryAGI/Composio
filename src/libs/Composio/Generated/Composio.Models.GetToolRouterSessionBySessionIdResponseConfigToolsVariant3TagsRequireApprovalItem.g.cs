
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsRequireApprovalItem
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
    public static class GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsRequireApprovalItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsRequireApprovalItem value)
        {
            return value switch
            {
                GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsRequireApprovalItem.DestructiveHint => "destructiveHint",
                GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsRequireApprovalItem.IdempotentHint => "idempotentHint",
                GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsRequireApprovalItem.OpenWorldHint => "openWorldHint",
                GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsRequireApprovalItem.ReadOnlyHint => "readOnlyHint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsRequireApprovalItem? ToEnum(string value)
        {
            return value switch
            {
                "destructiveHint" => GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsRequireApprovalItem.DestructiveHint,
                "idempotentHint" => GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsRequireApprovalItem.IdempotentHint,
                "openWorldHint" => GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsRequireApprovalItem.OpenWorldHint,
                "readOnlyHint" => GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsRequireApprovalItem.ReadOnlyHint,
                _ => null,
            };
        }
    }
}