#nullable enable

namespace Composio
{
    public partial interface IToolRouterClient
    {
        /// <summary>
        /// Create a presigned upload URL for a mount file<br/>
        /// Generates a presigned upload URL for uploading a file to a workbench session mount. The caller should PUT the file content directly to the returned URL.
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the tool router session<br/>
        /// Example: trs_1a2b3c4d5e6f
        /// </param>
        /// <param name="mountId">
        /// ID of the storage mount<br/>
        /// Example: files
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PostToolRouterSessionBySessionIdMountsByMountIdUploadUrlResponse> PostToolRouterSessionBySessionIdMountsByMountIdUploadUrlAsync(
            string sessionId,
            string mountId,

            global::Composio.PostToolRouterSessionBySessionIdMountsByMountIdUploadUrlRequest request,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a presigned upload URL for a mount file<br/>
        /// Generates a presigned upload URL for uploading a file to a workbench session mount. The caller should PUT the file content directly to the returned URL.
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the tool router session<br/>
        /// Example: trs_1a2b3c4d5e6f
        /// </param>
        /// <param name="mountId">
        /// ID of the storage mount<br/>
        /// Example: files
        /// </param>
        /// <param name="mountRelativePath">
        /// Supports subdirectories (e.g. "data/output.csv", "images/charts/chart.png")<br/>
        /// Example: report.pdf
        /// </param>
        /// <param name="mimetype">
        /// MIME type of the file being uploaded<br/>
        /// Example: application/pdf
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PostToolRouterSessionBySessionIdMountsByMountIdUploadUrlResponse> PostToolRouterSessionBySessionIdMountsByMountIdUploadUrlAsync(
            string sessionId,
            string mountId,
            string mountRelativePath,
            string? mimetype = default,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}