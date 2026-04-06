#nullable enable

namespace Composio
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// List available tools<br/>
        /// Retrieve a paginated list of available tools with comprehensive filtering, sorting and search capabilities. Use query parameters to narrow down results by toolkit, tags, or search terms.
        /// </summary>
        /// <param name="toolkitSlug"></param>
        /// <param name="toolSlugs"></param>
        /// <param name="authConfigIds"></param>
        /// <param name="important"></param>
        /// <param name="tags"></param>
        /// <param name="scopes">
        /// Filter tools by one or more scopes (can be specified multiple times)
        /// </param>
        /// <param name="query"></param>
        /// <param name="search"></param>
        /// <param name="includeDeprecated">
        /// Default Value: true
        /// </param>
        /// <param name="toolkitVersions"></param>
        /// <param name="limit"></param>
        /// <param name="cursor"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.ToolsPaginated> GetV31ToolsAsync(
            string? toolkitSlug = default,
            string? toolSlugs = default,
            global::Composio.OneOf<string, global::System.Collections.Generic.IList<string>>? authConfigIds = default,
            global::Composio.GetV31ToolsImportant? important = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::System.Collections.Generic.IList<string>? scopes = default,
            string? query = default,
            string? search = default,
            bool? includeDeprecated = default,
            global::Composio.OneOf<object, string, global::System.Collections.Generic.Dictionary<string, string>>? toolkitVersions = default,
            double? limit = default,
            string? cursor = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}