
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PostToolRouterSessionBySessionIdExecuteMetaResponseDiscriminatorResultType
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        Failed,
        /// <summary>
        ///
        /// </summary>
        InputRequired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolRouterSessionBySessionIdExecuteMetaResponseDiscriminatorResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionBySessionIdExecuteMetaResponseDiscriminatorResultType value)
        {
            return value switch
            {
                PostToolRouterSessionBySessionIdExecuteMetaResponseDiscriminatorResultType.Completed => "completed",
                PostToolRouterSessionBySessionIdExecuteMetaResponseDiscriminatorResultType.Failed => "failed",
                PostToolRouterSessionBySessionIdExecuteMetaResponseDiscriminatorResultType.InputRequired => "input_required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionBySessionIdExecuteMetaResponseDiscriminatorResultType? ToEnum(string value)
        {
            return value switch
            {
                "completed" => PostToolRouterSessionBySessionIdExecuteMetaResponseDiscriminatorResultType.Completed,
                "failed" => PostToolRouterSessionBySessionIdExecuteMetaResponseDiscriminatorResultType.Failed,
                "input_required" => PostToolRouterSessionBySessionIdExecuteMetaResponseDiscriminatorResultType.InputRequired,
                _ => null,
            };
        }
    }
}