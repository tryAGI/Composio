
#nullable enable

namespace Composio
{
    /// <summary>
    /// Additional values each user enters when connecting. Reference each field in a header, for example X-Org-Id: {{generic_id}}. Use display_name for the user-facing label. Every user must supply each declared field. Values are not secret.
    /// </summary>
    public sealed partial class PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2AdditionalFields
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generic_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2AdditionalFieldsGenericId GenericId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2AdditionalFields" /> class.
        /// </summary>
        /// <param name="genericId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2AdditionalFields(
            global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2AdditionalFieldsGenericId genericId)
        {
            this.GenericId = genericId ?? throw new global::System.ArgumentNullException(nameof(genericId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2AdditionalFields" /> class.
        /// </summary>
        public PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2AdditionalFields()
        {
        }

    }
}