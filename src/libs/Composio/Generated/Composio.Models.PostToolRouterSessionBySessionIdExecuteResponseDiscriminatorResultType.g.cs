
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PostToolRouterSessionBySessionIdExecuteResponseDiscriminatorResultType
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
    public static class PostToolRouterSessionBySessionIdExecuteResponseDiscriminatorResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionBySessionIdExecuteResponseDiscriminatorResultType value)
        {
            return value switch
            {
                PostToolRouterSessionBySessionIdExecuteResponseDiscriminatorResultType.Completed => "completed",
                PostToolRouterSessionBySessionIdExecuteResponseDiscriminatorResultType.Failed => "failed",
                PostToolRouterSessionBySessionIdExecuteResponseDiscriminatorResultType.InputRequired => "input_required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionBySessionIdExecuteResponseDiscriminatorResultType? ToEnum(string value)
        {
            return value switch
            {
                "completed" => PostToolRouterSessionBySessionIdExecuteResponseDiscriminatorResultType.Completed,
                "failed" => PostToolRouterSessionBySessionIdExecuteResponseDiscriminatorResultType.Failed,
                "input_required" => PostToolRouterSessionBySessionIdExecuteResponseDiscriminatorResultType.InputRequired,
                _ => null,
            };
        }
    }
}