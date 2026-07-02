#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Composio
{
    public partial interface ITriggersClient
    {
        /// <summary>
        /// Create or update a trigger<br/>
        /// Creates a new trigger instance or updates an existing one with the same configuration. Triggers listen for events from external services (webhooks or polling) and can invoke your workflows. If a matching trigger already exists and is disabled, it will be re-enabled. Provide either a connected_account_id to pin a specific user connection, or a user_id to auto-resolve the first active connection for that user and the trigger's toolkit.
        /// </summary>
        /// <param name="slug">
        /// The slug of the trigger instance. Case-insensitive (internally normalized to uppercase).
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PostTriggerInstancesBySlugUpsertResponse> PostTriggerInstancesBySlugUpsertAsync(
            string slug,

            global::Composio.PostTriggerInstancesBySlugUpsertRequest request,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or update a trigger<br/>
        /// Creates a new trigger instance or updates an existing one with the same configuration. Triggers listen for events from external services (webhooks or polling) and can invoke your workflows. If a matching trigger already exists and is disabled, it will be re-enabled. Provide either a connected_account_id to pin a specific user connection, or a user_id to auto-resolve the first active connection for that user and the trigger's toolkit.
        /// </summary>
        /// <param name="slug">
        /// The slug of the trigger instance. Case-insensitive (internally normalized to uppercase).
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.AutoSDKHttpResponse<global::Composio.PostTriggerInstancesBySlugUpsertResponse>> PostTriggerInstancesBySlugUpsertAsResponseAsync(
            string slug,

            global::Composio.PostTriggerInstancesBySlugUpsertRequest request,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or update a trigger<br/>
        /// Creates a new trigger instance or updates an existing one with the same configuration. Triggers listen for events from external services (webhooks or polling) and can invoke your workflows. If a matching trigger already exists and is disabled, it will be re-enabled. Provide either a connected_account_id to pin a specific user connection, or a user_id to auto-resolve the first active connection for that user and the trigger's toolkit.
        /// </summary>
        /// <param name="slug">
        /// The slug of the trigger instance. Case-insensitive (internally normalized to uppercase).
        /// </param>
        /// <param name="connectedAccountId">
        /// Connected account nanoid. Optional when user_id is provided — the first active connection for that user and the trigger's toolkit is auto-resolved.
        /// </param>
        /// <param name="userId">
        /// The user id (entity id) that owns the connection. When connected_account_id is omitted, the first active connection for this user and the trigger's toolkit is auto-resolved (same as tool execution). When connected_account_id is also provided and the project has 2FA enabled, user_id is validated against the owner of that connection.
        /// </param>
        /// <param name="triggerConfig2">
        /// Trigger configuration
        /// </param>
        /// <param name="toolkitVersions">
        /// Toolkit version specification. Supports "latest" string or a record mapping toolkit slugs to specific versions.<br/>
        /// Example: latest
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PostTriggerInstancesBySlugUpsertResponse> PostTriggerInstancesBySlugUpsertAsync(
            string slug,
            string? connectedAccountId = default,
            string? userId = default,
            global::System.Collections.Generic.Dictionary<string, object?>? triggerConfig2 = default,
            global::Composio.AnyOf<string, global::System.Collections.Generic.Dictionary<string, string>, object>? toolkitVersions = default,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}