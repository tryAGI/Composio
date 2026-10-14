
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsRequireApprovalItem
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
    public static class PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsRequireApprovalItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsRequireApprovalItem value)
        {
            return value switch
            {
                PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsRequireApprovalItem.CreateHint => "createHint",
                PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsRequireApprovalItem.DestructiveHint => "destructiveHint",
                PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsRequireApprovalItem.IdempotentHint => "idempotentHint",
                PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsRequireApprovalItem.OpenWorldHint => "openWorldHint",
                PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsRequireApprovalItem.ReadOnlyHint => "readOnlyHint",
                PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsRequireApprovalItem.UpdateHint => "updateHint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsRequireApprovalItem? ToEnum(string value)
        {
            return value switch
            {
                "createHint" => PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsRequireApprovalItem.CreateHint,
                "destructiveHint" => PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsRequireApprovalItem.DestructiveHint,
                "idempotentHint" => PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsRequireApprovalItem.IdempotentHint,
                "openWorldHint" => PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsRequireApprovalItem.OpenWorldHint,
                "readOnlyHint" => PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsRequireApprovalItem.ReadOnlyHint,
                "updateHint" => PatchToolRouterSessionBySessionIdRequestToolsVariant3TagsRequireApprovalItem.UpdateHint,
                _ => null,
            };
        }
    }
}