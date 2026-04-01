
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant6AuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        BearerToken,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant6AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant6AuthScheme value)
        {
            return value switch
            {
                PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant6AuthScheme.BearerToken => "BEARER_TOKEN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant6AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "BEARER_TOKEN" => PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant6AuthScheme.BearerToken,
                _ => null,
            };
        }
    }
}