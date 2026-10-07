
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public enum PostToolRouterSessionBySessionIdProxyExecuteResponseDiscriminatorResultType
    {
        /// <summary>
        ///
        /// </summary>
        Completed,
        /// <summary>
        ///
        /// </summary>
        InputRequired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolRouterSessionBySessionIdProxyExecuteResponseDiscriminatorResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolRouterSessionBySessionIdProxyExecuteResponseDiscriminatorResultType value)
        {
            return value switch
            {
                PostToolRouterSessionBySessionIdProxyExecuteResponseDiscriminatorResultType.Completed => "completed",
                PostToolRouterSessionBySessionIdProxyExecuteResponseDiscriminatorResultType.InputRequired => "input_required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolRouterSessionBySessionIdProxyExecuteResponseDiscriminatorResultType? ToEnum(string value)
        {
            return value switch
            {
                "completed" => PostToolRouterSessionBySessionIdProxyExecuteResponseDiscriminatorResultType.Completed,
                "input_required" => PostToolRouterSessionBySessionIdProxyExecuteResponseDiscriminatorResultType.InputRequired,
                _ => null,
            };
        }
    }
}