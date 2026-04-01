
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant11AuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        S2sOauth2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant11AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant11AuthScheme value)
        {
            return value switch
            {
                PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant11AuthScheme.S2sOauth2 => "S2S_OAUTH2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant11AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "S2S_OAUTH2" => PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant11AuthScheme.S2sOauth2,
                _ => null,
            };
        }
    }
}