#nullable enable

namespace Composio
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Get tool enum list<br/>
        /// Lists the slug of every tool in the latest version of each Composio-managed toolkit, such as GMAIL_SEND_EMAIL. Tools of custom toolkits are not included.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<string>> GetToolsEnumAsync(
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get tool enum list<br/>
        /// Lists the slug of every tool in the latest version of each Composio-managed toolkit, such as GMAIL_SEND_EMAIL. Tools of custom toolkits are not included.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.AutoSDKHttpResponse<global::System.Collections.Generic.IList<string>>> GetToolsEnumAsResponseAsync(
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}