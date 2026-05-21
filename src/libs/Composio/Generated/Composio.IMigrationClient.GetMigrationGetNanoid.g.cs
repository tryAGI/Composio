#nullable enable

namespace Composio
{
    public partial interface IMigrationClient
    {
        /// <summary>
        /// Get NanoId from UUID<br/>
        /// Convert a legacy UUID to its corresponding NanoId for migration purposes. This endpoint facilitates the transition from UUID-based identifiers to the more compact NanoId format used in the v3 API.
        /// </summary>
        /// <param name="uuid">
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </param>
        /// <param name="type">
        /// Example: CONNECTED_ACCOUNT
        /// </param>
        /// <param name="xApiKey">
        /// Your Composio API key used for authentication<br/>
        /// Example: ak_a1b2c3d4e5f6g7h8i9j0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.GetMigrationGetNanoidResponse> GetMigrationGetNanoidAsync(
            global::System.Guid uuid,
            global::Composio.GetMigrationGetNanoidType type,
            string xApiKey,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get NanoId from UUID<br/>
        /// Convert a legacy UUID to its corresponding NanoId for migration purposes. This endpoint facilitates the transition from UUID-based identifiers to the more compact NanoId format used in the v3 API.
        /// </summary>
        /// <param name="uuid">
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </param>
        /// <param name="type">
        /// Example: CONNECTED_ACCOUNT
        /// </param>
        /// <param name="xApiKey">
        /// Your Composio API key used for authentication<br/>
        /// Example: ak_a1b2c3d4e5f6g7h8i9j0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.AutoSDKHttpResponse<global::Composio.GetMigrationGetNanoidResponse>> GetMigrationGetNanoidAsResponseAsync(
            global::System.Guid uuid,
            global::Composio.GetMigrationGetNanoidType type,
            string xApiKey,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}