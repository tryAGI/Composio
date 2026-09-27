
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ToolDetailsToolkit
    {
        /// <summary>
        /// Unique identifier of the parent toolkit<br/>
        /// Example: github
        /// </summary>
        /// <example>github</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Human-readable name of the parent toolkit<br/>
        /// Example: GitHub
        /// </summary>
        /// <example>GitHub</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// URL to the toolkit logo image<br/>
        /// Example: https://github.githubassets.com/assets/GitHub-Mark-ea2971cee799.png
        /// </summary>
        /// <example>https://github.githubassets.com/assets/GitHub-Mark-ea2971cee799.png</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("logo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Logo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolDetailsToolkit" /> class.
        /// </summary>
        /// <param name="slug">
        /// Unique identifier of the parent toolkit<br/>
        /// Example: github
        /// </param>
        /// <param name="name">
        /// Human-readable name of the parent toolkit<br/>
        /// Example: GitHub
        /// </param>
        /// <param name="logo">
        /// URL to the toolkit logo image<br/>
        /// Example: https://github.githubassets.com/assets/GitHub-Mark-ea2971cee799.png
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolDetailsToolkit(
            string slug,
            string name,
            string logo)
        {
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Logo = logo ?? throw new global::System.ArgumentNullException(nameof(logo));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolDetailsToolkit" /> class.
        /// </summary>
        public ToolDetailsToolkit()
        {
        }

    }
}