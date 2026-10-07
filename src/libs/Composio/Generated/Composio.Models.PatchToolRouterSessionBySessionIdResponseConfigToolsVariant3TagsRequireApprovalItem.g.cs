
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsRequireApprovalItem
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
    public static class PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsRequireApprovalItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsRequireApprovalItem value)
        {
            return value switch
            {
                PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsRequireApprovalItem.DestructiveHint => "destructiveHint",
                PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsRequireApprovalItem.IdempotentHint => "idempotentHint",
                PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsRequireApprovalItem.OpenWorldHint => "openWorldHint",
                PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsRequireApprovalItem.ReadOnlyHint => "readOnlyHint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsRequireApprovalItem? ToEnum(string value)
        {
            return value switch
            {
                "destructiveHint" => PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsRequireApprovalItem.DestructiveHint,
                "idempotentHint" => PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsRequireApprovalItem.IdempotentHint,
                "openWorldHint" => PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsRequireApprovalItem.OpenWorldHint,
                "readOnlyHint" => PatchToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsRequireApprovalItem.ReadOnlyHint,
                _ => null,
            };
        }
    }
}