
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2AdditionalFieldsGenericId
    {
        /// <summary>
        /// Label shown to the user connecting their account
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// Help text below the input
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2AdditionalFieldsGenericId" /> class.
        /// </summary>
        /// <param name="displayName">
        /// Label shown to the user connecting their account
        /// </param>
        /// <param name="description">
        /// Help text below the input
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2AdditionalFieldsGenericId(
            string displayName,
            string? description)
        {
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2AdditionalFieldsGenericId" /> class.
        /// </summary>
        public PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2AdditionalFieldsGenericId()
        {
        }

    }
}