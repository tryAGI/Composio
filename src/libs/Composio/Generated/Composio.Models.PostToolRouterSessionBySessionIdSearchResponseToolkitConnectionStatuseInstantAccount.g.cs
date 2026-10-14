
#nullable enable

namespace Composio
{
    /// <summary>
    /// Present when the toolkit is connected through the Composio instant account rather than a connected account of the user.
    /// </summary>
    public sealed partial class PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseInstantAccount
    {
        /// <summary>
        /// Tools of this toolkit that run on the Composio instant account
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_tool_slugs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AllowedToolSlugs { get; set; }

        /// <summary>
        /// Price of each tool, keyed by tool slug.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prices")]
        public global::System.Collections.Generic.Dictionary<string, global::Composio.ToolPricing>? Prices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseInstantAccount" /> class.
        /// </summary>
        /// <param name="allowedToolSlugs">
        /// Tools of this toolkit that run on the Composio instant account
        /// </param>
        /// <param name="prices">
        /// Price of each tool, keyed by tool slug.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseInstantAccount(
            global::System.Collections.Generic.IList<string> allowedToolSlugs,
            global::System.Collections.Generic.Dictionary<string, global::Composio.ToolPricing>? prices)
        {
            this.AllowedToolSlugs = allowedToolSlugs ?? throw new global::System.ArgumentNullException(nameof(allowedToolSlugs));
            this.Prices = prices;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseInstantAccount" /> class.
        /// </summary>
        public PostToolRouterSessionBySessionIdSearchResponseToolkitConnectionStatuseInstantAccount()
        {
        }

    }
}