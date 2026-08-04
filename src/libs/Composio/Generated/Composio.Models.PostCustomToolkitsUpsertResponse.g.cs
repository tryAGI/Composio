
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostCustomToolkitsUpsertResponse
    {
        /// <summary>
        /// Slug to be used with composio<br/>
        /// Example: CUSTOM_MY_TOOLKIT
        /// </summary>
        /// <example>CUSTOM_MY_TOOLKIT</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCustomToolkitsUpsertResponse" /> class.
        /// </summary>
        /// <param name="slug">
        /// Slug to be used with composio<br/>
        /// Example: CUSTOM_MY_TOOLKIT
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostCustomToolkitsUpsertResponse(
            string slug)
        {
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCustomToolkitsUpsertResponse" /> class.
        /// </summary>
        public PostCustomToolkitsUpsertResponse()
        {
        }

    }
}