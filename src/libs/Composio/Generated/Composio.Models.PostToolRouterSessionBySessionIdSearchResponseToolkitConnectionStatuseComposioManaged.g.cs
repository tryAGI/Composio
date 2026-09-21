
#nullable enable

namespace Composio
{
    /// <summary>
    /// Present when the toolkit is connected through the Composio managed account rather than a connected account of the user.
    /// </summary>
    public sealed partial class PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseComposioManaged
    {
        /// <summary>
        /// Tools of this toolkit that run on the Composio managed account
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_tool_slugs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AllowedToolSlugs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseComposioManaged" /> class.
        /// </summary>
        /// <param name="allowedToolSlugs">
        /// Tools of this toolkit that run on the Composio managed account
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseComposioManaged(
            global::System.Collections.Generic.IList<string> allowedToolSlugs)
        {
            this.AllowedToolSlugs = allowedToolSlugs ?? throw new global::System.ArgumentNullException(nameof(allowedToolSlugs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseComposioManaged" /> class.
        /// </summary>
        public PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseComposioManaged()
        {
        }

    }
}