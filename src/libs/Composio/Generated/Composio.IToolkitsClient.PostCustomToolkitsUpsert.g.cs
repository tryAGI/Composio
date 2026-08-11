#nullable enable

namespace Composio
{
    public partial interface IToolkitsClient
    {
        /// <summary>
        /// Upsert a custom toolkit<br/>
        /// Experimental: custom toolkits are in pilot and this contract may change. Creates a custom toolkit for the project with the provided slug, or updates its display metadata (name, API key field copy) when the project already owns a toolkit with that slug. app_url and auth_schemes cannot be changed on an existing toolkit: re-sending them unchanged is a no-op, changing them returns 409 (delete and re-register the toolkit instead, which revokes its connections).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PostCustomToolkitsUpsertResponse> PostCustomToolkitsUpsertAsync(

            global::Composio.PostCustomToolkitsUpsertRequest request,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upsert a custom toolkit<br/>
        /// Experimental: custom toolkits are in pilot and this contract may change. Creates a custom toolkit for the project with the provided slug, or updates its display metadata (name, API key field copy) when the project already owns a toolkit with that slug. app_url and auth_schemes cannot be changed on an existing toolkit: re-sending them unchanged is a no-op, changing them returns 409 (delete and re-register the toolkit instead, which revokes its connections).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.AutoSDKHttpResponse<global::Composio.PostCustomToolkitsUpsertResponse>> PostCustomToolkitsUpsertAsResponseAsync(

            global::Composio.PostCustomToolkitsUpsertRequest request,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upsert a custom toolkit<br/>
        /// Experimental: custom toolkits are in pilot and this contract may change. Creates a custom toolkit for the project with the provided slug, or updates its display metadata (name, API key field copy) when the project already owns a toolkit with that slug. app_url and auth_schemes cannot be changed on an existing toolkit: re-sending them unchanged is a no-op, changing them returns 409 (delete and re-register the toolkit instead, which revokes its connections).
        /// </summary>
        /// <param name="slug">
        /// Unique slug identifier for the toolkit. Your slug will be prefixed with CUSTOM_ to avoid collision with composio managed toolkits. Spaces will be converted to underscores.<br/>
        /// Example: MY_TOOLKIT
        /// </param>
        /// <param name="toolkitConfig"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PostCustomToolkitsUpsertResponse> PostCustomToolkitsUpsertAsync(
            string slug,
            global::Composio.PostCustomToolkitsUpsertRequestToolkitConfig toolkitConfig,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}