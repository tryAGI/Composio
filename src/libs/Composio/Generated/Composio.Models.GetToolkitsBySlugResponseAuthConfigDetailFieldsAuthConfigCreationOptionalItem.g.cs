
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreationOptionalItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("displayName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        public string? Default { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Required { get; set; }

        /// <summary>
        /// Whether this field holds a secret/credential value. Clients use it to decide whether to mask the input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_secret")]
        public bool? IsSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("legacy_template_name")]
        public string? LegacyTemplateName { get; set; }

        /// <summary>
        /// Whether this field is shown to the end user in the hosted connect flow. Fields with `false` are never required — the field's `default` applies unless the developer supplies a value on the auth config (e.g. as a shared credential).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_visible")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool UserVisible { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreationOptionalItem" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="displayName"></param>
        /// <param name="type"></param>
        /// <param name="description"></param>
        /// <param name="required"></param>
        /// <param name="userVisible">
        /// Whether this field is shown to the end user in the hosted connect flow. Fields with `false` are never required — the field's `default` applies unless the developer supplies a value on the auth config (e.g. as a shared credential).
        /// </param>
        /// <param name="default"></param>
        /// <param name="isSecret">
        /// Whether this field holds a secret/credential value. Clients use it to decide whether to mask the input.
        /// </param>
        /// <param name="legacyTemplateName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreationOptionalItem(
            string name,
            string displayName,
            string type,
            string description,
            bool required,
            bool userVisible,
            string? @default,
            bool? isSecret,
            string? legacyTemplateName)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Default = @default;
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Required = required;
            this.IsSecret = isSecret;
            this.LegacyTemplateName = legacyTemplateName;
            this.UserVisible = userVisible;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreationOptionalItem" /> class.
        /// </summary>
        public GetToolkitsBySlugResponseAuthConfigDetailFieldsAuthConfigCreationOptionalItem()
        {
        }

    }
}