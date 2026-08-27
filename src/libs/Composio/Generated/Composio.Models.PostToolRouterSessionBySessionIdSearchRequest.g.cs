
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PostToolRouterSessionBySessionIdSearchRequest
    {
        /// <summary>
        /// List of search queries to execute in parallel. Up to 7 queries supported.<br/>
        /// Example: [{"use_case":"Send a slack message to a channel"}]
        /// </summary>
        /// <example>[{"use_case":"Send a slack message to a channel"}]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("queries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionBySessionIdSearchRequestQuerie> Queries { get; set; }

        /// <summary>
        /// Optional model hint for search/planning behavior (e.g., "gpt-4o"). Ignored if invalid.<br/>
        /// Example: gpt-4o
        /// </summary>
        /// <example>gpt-4o</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Search path to use. Defaults to auto. Use tool_search to bypass cached plans and run direct tool search.<br/>
        /// Example: tool_search
        /// </summary>
        /// <example>tool_search</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PostToolRouterSessionBySessionIdSearchRequestSearchStrategyJsonConverter))]
        public global::Composio.PostToolRouterSessionBySessionIdSearchRequestSearchStrategy? SearchStrategy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdSearchRequest" /> class.
        /// </summary>
        /// <param name="queries">
        /// List of search queries to execute in parallel. Up to 7 queries supported.<br/>
        /// Example: [{"use_case":"Send a slack message to a channel"}]
        /// </param>
        /// <param name="model">
        /// Optional model hint for search/planning behavior (e.g., "gpt-4o"). Ignored if invalid.<br/>
        /// Example: gpt-4o
        /// </param>
        /// <param name="searchStrategy">
        /// Search path to use. Defaults to auto. Use tool_search to bypass cached plans and run direct tool search.<br/>
        /// Example: tool_search
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolRouterSessionBySessionIdSearchRequest(
            global::System.Collections.Generic.IList<global::Composio.PostToolRouterSessionBySessionIdSearchRequestQuerie> queries,
            string? model,
            global::Composio.PostToolRouterSessionBySessionIdSearchRequestSearchStrategy? searchStrategy)
        {
            this.Queries = queries ?? throw new global::System.ArgumentNullException(nameof(queries));
            this.Model = model;
            this.SearchStrategy = searchStrategy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdSearchRequest" /> class.
        /// </summary>
        public PostToolRouterSessionBySessionIdSearchRequest()
        {
        }

    }
}