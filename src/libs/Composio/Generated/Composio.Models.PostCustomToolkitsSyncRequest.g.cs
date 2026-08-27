
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PostCustomToolkitsSyncRequest
    {
        /// <summary>
        /// Toolkit slug to sync<br/>
        /// Example: CUSTOM_MY_TOOLKIT
        /// </summary>
        /// <example>CUSTOM_MY_TOOLKIT</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// The unique identifier for the connected account<br/>
        /// Example: ca_1a2b3c4d5e6f
        /// </summary>
        /// <example>ca_1a2b3c4d5e6f</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("connected_account_id")]
        public string? ConnectedAccountId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCustomToolkitsSyncRequest" /> class.
        /// </summary>
        /// <param name="slug">
        /// Toolkit slug to sync<br/>
        /// Example: CUSTOM_MY_TOOLKIT
        /// </param>
        /// <param name="connectedAccountId">
        /// The unique identifier for the connected account<br/>
        /// Example: ca_1a2b3c4d5e6f
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostCustomToolkitsSyncRequest(
            string slug,
            string? connectedAccountId)
        {
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.ConnectedAccountId = connectedAccountId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCustomToolkitsSyncRequest" /> class.
        /// </summary>
        public PostCustomToolkitsSyncRequest()
        {
        }

    }
}