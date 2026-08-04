
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostCustomToolkitsSyncResponse
    {
        /// <summary>
        /// Synced toolkit slug<br/>
        /// Example: CUSTOM_MY_TOOLKIT
        /// </summary>
        /// <example>CUSTOM_MY_TOOLKIT</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// Version of the toolkit created after sync<br/>
        /// Example: 00000000_00
        /// </summary>
        /// <example>00000000_00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// Number of tools synced for toolkit<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("synced_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SyncedCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCustomToolkitsSyncResponse" /> class.
        /// </summary>
        /// <param name="slug">
        /// Synced toolkit slug<br/>
        /// Example: CUSTOM_MY_TOOLKIT
        /// </param>
        /// <param name="version">
        /// Version of the toolkit created after sync<br/>
        /// Example: 00000000_00
        /// </param>
        /// <param name="syncedCount">
        /// Number of tools synced for toolkit<br/>
        /// Example: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostCustomToolkitsSyncResponse(
            string slug,
            string version,
            double syncedCount)
        {
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.SyncedCount = syncedCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCustomToolkitsSyncResponse" /> class.
        /// </summary>
        public PostCustomToolkitsSyncResponse()
        {
        }

    }
}