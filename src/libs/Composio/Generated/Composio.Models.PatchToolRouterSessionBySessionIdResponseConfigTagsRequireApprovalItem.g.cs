
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchToolRouterSessionBySessionIdResponseConfigTagsRequireApprovalItem
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
    public static class PatchToolRouterSessionBySessionIdResponseConfigTagsRequireApprovalItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchToolRouterSessionBySessionIdResponseConfigTagsRequireApprovalItem value)
        {
            return value switch
            {
                PatchToolRouterSessionBySessionIdResponseConfigTagsRequireApprovalItem.DestructiveHint => "destructiveHint",
                PatchToolRouterSessionBySessionIdResponseConfigTagsRequireApprovalItem.IdempotentHint => "idempotentHint",
                PatchToolRouterSessionBySessionIdResponseConfigTagsRequireApprovalItem.OpenWorldHint => "openWorldHint",
                PatchToolRouterSessionBySessionIdResponseConfigTagsRequireApprovalItem.ReadOnlyHint => "readOnlyHint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchToolRouterSessionBySessionIdResponseConfigTagsRequireApprovalItem? ToEnum(string value)
        {
            return value switch
            {
                "destructiveHint" => PatchToolRouterSessionBySessionIdResponseConfigTagsRequireApprovalItem.DestructiveHint,
                "idempotentHint" => PatchToolRouterSessionBySessionIdResponseConfigTagsRequireApprovalItem.IdempotentHint,
                "openWorldHint" => PatchToolRouterSessionBySessionIdResponseConfigTagsRequireApprovalItem.OpenWorldHint,
                "readOnlyHint" => PatchToolRouterSessionBySessionIdResponseConfigTagsRequireApprovalItem.ReadOnlyHint,
                _ => null,
            };
        }
    }
}