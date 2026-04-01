
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public enum PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant4AuthScheme
    {
        /// <summary>
        /// 
        /// </summary>
        BasicWithJwt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant4AuthSchemeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant4AuthScheme value)
        {
            return value switch
            {
                PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant4AuthScheme.BasicWithJwt => "BASIC_WITH_JWT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant4AuthScheme? ToEnum(string value)
        {
            return value switch
            {
                "BASIC_WITH_JWT" => PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant4AuthScheme.BasicWithJwt,
                _ => null,
            };
        }
    }
}