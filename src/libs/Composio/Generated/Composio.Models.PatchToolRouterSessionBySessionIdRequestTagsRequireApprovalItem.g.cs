
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchToolRouterSessionBySessionIdRequestTagsRequireApprovalItem
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
    public static class PatchToolRouterSessionBySessionIdRequestTagsRequireApprovalItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchToolRouterSessionBySessionIdRequestTagsRequireApprovalItem value)
        {
            return value switch
            {
                PatchToolRouterSessionBySessionIdRequestTagsRequireApprovalItem.DestructiveHint => "destructiveHint",
                PatchToolRouterSessionBySessionIdRequestTagsRequireApprovalItem.IdempotentHint => "idempotentHint",
                PatchToolRouterSessionBySessionIdRequestTagsRequireApprovalItem.OpenWorldHint => "openWorldHint",
                PatchToolRouterSessionBySessionIdRequestTagsRequireApprovalItem.ReadOnlyHint => "readOnlyHint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchToolRouterSessionBySessionIdRequestTagsRequireApprovalItem? ToEnum(string value)
        {
            return value switch
            {
                "destructiveHint" => PatchToolRouterSessionBySessionIdRequestTagsRequireApprovalItem.DestructiveHint,
                "idempotentHint" => PatchToolRouterSessionBySessionIdRequestTagsRequireApprovalItem.IdempotentHint,
                "openWorldHint" => PatchToolRouterSessionBySessionIdRequestTagsRequireApprovalItem.OpenWorldHint,
                "readOnlyHint" => PatchToolRouterSessionBySessionIdRequestTagsRequireApprovalItem.ReadOnlyHint,
                _ => null,
            };
        }
    }
}