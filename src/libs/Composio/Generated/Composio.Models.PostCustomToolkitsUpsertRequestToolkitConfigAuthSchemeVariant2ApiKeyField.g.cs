
#nullable enable

namespace Composio
{
    /// <summary>
    /// End-user-facing copy for the API key input on the connect page
    /// </summary>
    public sealed partial class PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2ApiKeyField
    {
        /// <summary>
        /// Label shown to end users for the API key input on the connect page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Help text shown to end users below the API key input on the connect page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2ApiKeyField" /> class.
        /// </summary>
        /// <param name="displayName">
        /// Label shown to end users for the API key input on the connect page
        /// </param>
        /// <param name="description">
        /// Help text shown to end users below the API key input on the connect page
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2ApiKeyField(
            string? displayName,
            string? description)
        {
            this.DisplayName = displayName;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2ApiKeyField" /> class.
        /// </summary>
        public PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2ApiKeyField()
        {
        }

    }
}