
#nullable enable

namespace Composio
{
    /// <summary>
    /// The location of the parameter. Can be 'query' or 'header'.
    /// </summary>
    public enum PostV31ToolsExecuteByToolSlugRequestCustomAuthParamsParameterIn
    {
        /// <summary>
        /// 
        /// </summary>
        Header,
        /// <summary>
        /// 
        /// </summary>
        Query,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostV31ToolsExecuteByToolSlugRequestCustomAuthParamsParameterInExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostV31ToolsExecuteByToolSlugRequestCustomAuthParamsParameterIn value)
        {
            return value switch
            {
                PostV31ToolsExecuteByToolSlugRequestCustomAuthParamsParameterIn.Header => "header",
                PostV31ToolsExecuteByToolSlugRequestCustomAuthParamsParameterIn.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostV31ToolsExecuteByToolSlugRequestCustomAuthParamsParameterIn? ToEnum(string value)
        {
            return value switch
            {
                "header" => PostV31ToolsExecuteByToolSlugRequestCustomAuthParamsParameterIn.Header,
                "query" => PostV31ToolsExecuteByToolSlugRequestCustomAuthParamsParameterIn.Query,
                _ => null,
            };
        }
    }
}