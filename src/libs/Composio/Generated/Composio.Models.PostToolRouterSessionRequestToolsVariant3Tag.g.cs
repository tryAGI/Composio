
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PostToolRouterSessionRequestToolsVariant3Tag
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
    public static class PostToolRouterSessionRequestToolsVariant3TagExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionRequestToolsVariant3Tag value)
        {
            return value switch
            {
                PostToolRouterSessionRequestToolsVariant3Tag.CreateHint => "createHint",
                PostToolRouterSessionRequestToolsVariant3Tag.DestructiveHint => "destructiveHint",
                PostToolRouterSessionRequestToolsVariant3Tag.IdempotentHint => "idempotentHint",
                PostToolRouterSessionRequestToolsVariant3Tag.OpenWorldHint => "openWorldHint",
                PostToolRouterSessionRequestToolsVariant3Tag.ReadOnlyHint => "readOnlyHint",
                PostToolRouterSessionRequestToolsVariant3Tag.UpdateHint => "updateHint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionRequestToolsVariant3Tag? ToEnum(string value)
        {
            return value switch
            {
                "createHint" => PostToolRouterSessionRequestToolsVariant3Tag.CreateHint,
                "destructiveHint" => PostToolRouterSessionRequestToolsVariant3Tag.DestructiveHint,
                "idempotentHint" => PostToolRouterSessionRequestToolsVariant3Tag.IdempotentHint,
                "openWorldHint" => PostToolRouterSessionRequestToolsVariant3Tag.OpenWorldHint,
                "readOnlyHint" => PostToolRouterSessionRequestToolsVariant3Tag.ReadOnlyHint,
                "updateHint" => PostToolRouterSessionRequestToolsVariant3Tag.UpdateHint,
                _ => null,
            };
        }
    }
}