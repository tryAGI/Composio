
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostCustomToolkitsUpsertRequest
    {
        /// <summary>
        /// Unique slug identifier for the toolkit. Your slug will be prefixed with CUSTOM_ to avoid collision with composio managed toolkits. Spaces will be converted to underscores.<br/>
        /// Example: MY_TOOLKIT
        /// </summary>
        /// <example>MY_TOOLKIT</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolkit_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.PostCustomToolkitsUpsertRequestToolkitConfig ToolkitConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCustomToolkitsUpsertRequest" /> class.
        /// </summary>
        /// <param name="slug">
        /// Unique slug identifier for the toolkit. Your slug will be prefixed with CUSTOM_ to avoid collision with composio managed toolkits. Spaces will be converted to underscores.<br/>
        /// Example: MY_TOOLKIT
        /// </param>
        /// <param name="toolkitConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostCustomToolkitsUpsertRequest(
            string slug,
            global::Composio.PostCustomToolkitsUpsertRequestToolkitConfig toolkitConfig)
        {
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.ToolkitConfig = toolkitConfig ?? throw new global::System.ArgumentNullException(nameof(toolkitConfig));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCustomToolkitsUpsertRequest" /> class.
        /// </summary>
        public PostCustomToolkitsUpsertRequest()
        {
        }

    }
}