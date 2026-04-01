#nullable enable

namespace Composio
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Get required scopes for tools<br/>
        /// Resolves required scopes for the specified tools at a given toolkit version. All requested tools must belong to the same toolkit. Returns the flat scope union plus per-tool structured scope requirements when available.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PostV31ToolsScopesRequiredResponse> PostV31ToolsScopesRequiredAsync(

            global::Composio.PostV31ToolsScopesRequiredRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get required scopes for tools<br/>
        /// Resolves required scopes for the specified tools at a given toolkit version. All requested tools must belong to the same toolkit. Returns the flat scope union plus per-tool structured scope requirements when available.
        /// </summary>
        /// <param name="tools">
        /// Tool slugs to resolve scopes for. All tools must belong to the same toolkit.<br/>
        /// Example: [gmail_view_email, gmail_send_email]
        /// </param>
        /// <param name="version">
        /// Toolkit version to resolve scopes against for the requested toolkit. Defaults to the pinned HTTP version when omitted.<br/>
        /// Example: latest
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PostV31ToolsScopesRequiredResponse> PostV31ToolsScopesRequiredAsync(
            global::System.Collections.Generic.IList<string> tools,
            string? version = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}