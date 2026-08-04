
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3ModeJsonConverter))]
        public global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3Mode Mode { get; set; }

        /// <summary>
        /// URL to fetch the full auth scheme from, usually the /.well-known/oauth-authorization-server path of your MCP URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discovery_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DiscoveryUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3" /> class.
        /// </summary>
        /// <param name="discoveryUrl">
        /// URL to fetch the full auth scheme from, usually the /.well-known/oauth-authorization-server path of your MCP URL
        /// </param>
        /// <param name="mode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3(
            string discoveryUrl,
            global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3Mode mode)
        {
            this.Mode = mode;
            this.DiscoveryUrl = discoveryUrl ?? throw new global::System.ArgumentNullException(nameof(discoveryUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3" /> class.
        /// </summary>
        public PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3()
        {
        }

    }
}