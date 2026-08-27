
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PostOrgOwnerProjectNewResponse
    {
        /// <summary>
        /// Unique identifier for the project<br/>
        /// Example: pr_1a2b3c4d5e6f
        /// </summary>
        /// <example>pr_1a2b3c4d5e6f</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name of the project<br/>
        /// Example: My Awesome Project
        /// </summary>
        /// <example>My Awesome Project</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// API key for the project<br/>
        /// Example: ak_a1b2c3d4e5f6g7h8i9j0
        /// </summary>
        /// <example>ak_a1b2c3d4e5f6g7h8i9j0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostOrgOwnerProjectNewResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the project<br/>
        /// Example: pr_1a2b3c4d5e6f
        /// </param>
        /// <param name="name">
        /// Name of the project<br/>
        /// Example: My Awesome Project
        /// </param>
        /// <param name="apiKey">
        /// API key for the project<br/>
        /// Example: ak_a1b2c3d4e5f6g7h8i9j0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostOrgOwnerProjectNewResponse(
            string id,
            string? name,
            string? apiKey)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name;
            this.ApiKey = apiKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostOrgOwnerProjectNewResponse" /> class.
        /// </summary>
        public PostOrgOwnerProjectNewResponse()
        {
        }

    }
}