
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant9
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authScheme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant9AuthSchemeJsonConverter))]
        public global::Composio.PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant9AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolkitSlug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolkitSlug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("val")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant9Val Val { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant9" /> class.
        /// </summary>
        /// <param name="toolkitSlug"></param>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant9(
            string toolkitSlug,
            global::Composio.PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant9Val val,
            global::Composio.PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant9AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.ToolkitSlug = toolkitSlug ?? throw new global::System.ArgumentNullException(nameof(toolkitSlug));
            this.Val = val ?? throw new global::System.ArgumentNullException(nameof(val));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant9" /> class.
        /// </summary>
        public PostV31ToolsExecuteByToolSlugRequestCustomConnectionDataVariant9()
        {
        }
    }
}