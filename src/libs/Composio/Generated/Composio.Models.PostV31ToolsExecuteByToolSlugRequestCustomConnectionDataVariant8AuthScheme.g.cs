
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant8AuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        NoAuth,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant8AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant8AuthScheme value)
        {
            return value switch
            {
                PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant8AuthScheme.NoAuth => "NO_AUTH",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant8AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "NO_AUTH" => PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant8AuthScheme.NoAuth,
                _ => null,
            };
        }
    }
}