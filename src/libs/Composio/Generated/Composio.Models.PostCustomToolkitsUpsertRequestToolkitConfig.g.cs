
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostCustomToolkitsUpsertRequestToolkitConfig
    {
        /// <summary>
        /// Human readable name for your application
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// App URL for the toolkit. For MCP apps, please provide the MCP URL here
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AppUrl { get; set; }

        /// <summary>
        /// Square logo image (PNG or JPEG, 256-1024px, max 3MB) shown for this toolkit in the dashboard and on connect pages. Uploaded to Composio-hosted storage; defaults to the Composio logo when omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logo_file")]
        public global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigLogoFile? LogoFile { get; set; }

        /// <summary>
        /// Authentication schemes for the toolkit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_schemes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Composio.OneOf<global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant1, global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2, global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3>> AuthSchemes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCustomToolkitsUpsertRequestToolkitConfig" /> class.
        /// </summary>
        /// <param name="name">
        /// Human readable name for your application
        /// </param>
        /// <param name="appUrl">
        /// App URL for the toolkit. For MCP apps, please provide the MCP URL here
        /// </param>
        /// <param name="authSchemes">
        /// Authentication schemes for the toolkit
        /// </param>
        /// <param name="logoFile">
        /// Square logo image (PNG or JPEG, 256-1024px, max 3MB) shown for this toolkit in the dashboard and on connect pages. Uploaded to Composio-hosted storage; defaults to the Composio logo when omitted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostCustomToolkitsUpsertRequestToolkitConfig(
            string name,
            string appUrl,
            global::System.Collections.Generic.IList<global::Composio.OneOf<global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant1, global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2, global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant3>> authSchemes,
            global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigLogoFile? logoFile)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AppUrl = appUrl ?? throw new global::System.ArgumentNullException(nameof(appUrl));
            this.LogoFile = logoFile;
            this.AuthSchemes = authSchemes ?? throw new global::System.ArgumentNullException(nameof(authSchemes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCustomToolkitsUpsertRequestToolkitConfig" /> class.
        /// </summary>
        public PostCustomToolkitsUpsertRequestToolkitConfig()
        {
        }

    }
}