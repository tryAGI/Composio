
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PostCustomToolkitsUpsertRequestToolkitConfig
    {
        /// <summary>
        /// Display name of the toolkit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// MCP server URL. Must use https.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AppUrl { get; set; }

        /// <summary>
        /// Square PNG or JPEG logo, 256-1024px, max 3MB. Defaults to the Model Context Protocol logo.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logo_file")]
        public global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigLogoFile? LogoFile { get; set; }

        /// <summary>
        /// How users authenticate to the MCP server
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
        /// Display name of the toolkit
        /// </param>
        /// <param name="appUrl">
        /// MCP server URL. Must use https.
        /// </param>
        /// <param name="authSchemes">
        /// How users authenticate to the MCP server
        /// </param>
        /// <param name="logoFile">
        /// Square PNG or JPEG logo, 256-1024px, max 3MB. Defaults to the Model Context Protocol logo.
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