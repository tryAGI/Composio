
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PostToolRouterSessionResponseConfigTagsEnabledItem
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
    public static class PostToolRouterSessionResponseConfigTagsEnabledItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionResponseConfigTagsEnabledItem value)
        {
            return value switch
            {
                PostToolRouterSessionResponseConfigTagsEnabledItem.CreateHint => "createHint",
                PostToolRouterSessionResponseConfigTagsEnabledItem.DestructiveHint => "destructiveHint",
                PostToolRouterSessionResponseConfigTagsEnabledItem.IdempotentHint => "idempotentHint",
                PostToolRouterSessionResponseConfigTagsEnabledItem.OpenWorldHint => "openWorldHint",
                PostToolRouterSessionResponseConfigTagsEnabledItem.ReadOnlyHint => "readOnlyHint",
                PostToolRouterSessionResponseConfigTagsEnabledItem.UpdateHint => "updateHint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionResponseConfigTagsEnabledItem? ToEnum(string value)
        {
            return value switch
            {
                "createHint" => PostToolRouterSessionResponseConfigTagsEnabledItem.CreateHint,
                "destructiveHint" => PostToolRouterSessionResponseConfigTagsEnabledItem.DestructiveHint,
                "idempotentHint" => PostToolRouterSessionResponseConfigTagsEnabledItem.IdempotentHint,
                "openWorldHint" => PostToolRouterSessionResponseConfigTagsEnabledItem.OpenWorldHint,
                "readOnlyHint" => PostToolRouterSessionResponseConfigTagsEnabledItem.ReadOnlyHint,
                "updateHint" => PostToolRouterSessionResponseConfigTagsEnabledItem.UpdateHint,
                _ => null,
            };
        }
    }
}