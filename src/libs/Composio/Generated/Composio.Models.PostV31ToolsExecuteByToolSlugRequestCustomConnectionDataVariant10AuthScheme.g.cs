
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant10AuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        GoogleServiceAccount,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant10AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant10AuthScheme value)
        {
            return value switch
            {
                PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant10AuthScheme.GoogleServiceAccount => "GOOGLE_SERVICE_ACCOUNT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant10AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "GOOGLE_SERVICE_ACCOUNT" => PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant10AuthScheme.GoogleServiceAccount,
                _ => null,
            };
        }
    }
}