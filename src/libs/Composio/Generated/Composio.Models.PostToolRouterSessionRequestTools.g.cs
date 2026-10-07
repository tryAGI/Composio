
#nullable enable

namespace Composio
{
    /// <summary>
    /// Tool-level configuration per toolkit. Allows you to enable, disable, or filter by tags for specific tools within each toolkit, and experimentally to list tools that need approval. Every tool slug must be a valid Composio tool slug for that toolkit — invalid or typo'd slugs fail session creation with a clear error listing which ones didn't match.
    /// </summary>
    public sealed partial class PostToolRouterSessionRequestTools
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}