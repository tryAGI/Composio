
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authScheme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant1AuthSchemeJsonConverter))]
        public global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant1AuthScheme AuthScheme { get; set; }

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
        public required global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant1Val Val { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant1" /> class.
        /// </summary>
        /// <param name="toolkitSlug"></param>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant1(
            string toolkitSlug,
            global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant1Val val,
            global::Composio.PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant1AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.ToolkitSlug = toolkitSlug ?? throw new global::System.ArgumentNullException(nameof(toolkitSlug));
            this.Val = val ?? throw new global::System.ArgumentNullException(nameof(val));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant1" /> class.
        /// </summary>
        public PostToolRouterSessionBySessionIdProxyExecuteRequestCustomConnectionDataVariant1()
        {
        }

    }
}