
#nullable enable

namespace Composio
{
    /// <summary>
    /// Square PNG or JPEG logo, 256-1024px, max 3MB. Defaults to the Composio logo.
    /// </summary>
    public sealed partial class PostCustomToolkitsUpsertRequestToolkitConfigLogoFile
    {
        /// <summary>
        /// Base64-encoded image, max 3MB decoded
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Image MIME type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PostCustomToolkitsUpsertRequestToolkitConfigLogoFileMimeTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigLogoFileMimeType MimeType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCustomToolkitsUpsertRequestToolkitConfigLogoFile" /> class.
        /// </summary>
        /// <param name="content">
        /// Base64-encoded image, max 3MB decoded
        /// </param>
        /// <param name="mimeType">
        /// Image MIME type
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostCustomToolkitsUpsertRequestToolkitConfigLogoFile(
            string content,
            global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigLogoFileMimeType mimeType)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.MimeType = mimeType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCustomToolkitsUpsertRequestToolkitConfigLogoFile" /> class.
        /// </summary>
        public PostCustomToolkitsUpsertRequestToolkitConfigLogoFile()
        {
        }

    }
}