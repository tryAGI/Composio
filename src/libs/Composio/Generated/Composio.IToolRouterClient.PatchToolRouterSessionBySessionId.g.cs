#nullable enable

namespace Composio
{
    public partial interface IToolRouterClient
    {
        /// <summary>
        /// Patch a tool router session config<br/>
        /// Partially updates the configuration of an existing tool router session. Only the fields provided in the request body will be updated. Uses optimistic concurrency control to prevent lost updates. The previous config is stored in config history.
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the tool router session<br/>
        /// Example: trs_1a2b3c4d5e6f
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PatchToolRouterSessionBySessionIdResponse> PatchToolRouterSessionBySessionIdAsync(
            string sessionId,

            global::Composio.PatchToolRouterSessionBySessionIdRequest request,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Patch a tool router session config<br/>
        /// Partially updates the configuration of an existing tool router session. Only the fields provided in the request body will be updated. Uses optimistic concurrency control to prevent lost updates. The previous config is stored in config history.
        /// </summary>
        /// <param name="sessionId">
        /// The unique identifier of the tool router session<br/>
        /// Example: trs_1a2b3c4d5e6f
        /// </param>
        /// <param name="toolkits">
        /// Toolkit configuration - specify either enable toolkits (allowlist) or disable toolkits (denylist). Mutually exclusive.
        /// </param>
        /// <param name="authConfigs">
        /// The auth configs to use for the session. This will override the default behavior and use the given auth config when specific toolkits are being executed<br/>
        /// Example: {"gmail":"ac_1a2b3c4d5e6f","slack":"ac_7g8h9i0j1k2l"}
        /// </param>
        /// <param name="connectedAccounts">
        /// The connected accounts to use for the session. This will override the default behaviour and use the given connected account when specific toolkits are being executed. Each connected account must exist (not deleted or disabled) and belong to the same `user_id` as the session — otherwise session creation fails with a clear error explaining which account didn't match.<br/>
        /// Example: {"github":"ca_3m4n5o6p7q8r"}
        /// </param>
        /// <param name="manageConnections"></param>
        /// <param name="tools">
        /// Tool-level configuration per toolkit. Allows you to enable, disable, or filter by tags for specific tools within each toolkit. Every slug passed in `enable` / `disable` must be a valid Composio tool slug for that toolkit — invalid or typo'd slugs fail session creation with a clear error listing which ones didn't match.<br/>
        /// Example: {"gmail":{"enable":["GMAIL_SEND_EMAIL","GMAIL_FETCH_EMAILS"]},"slack":{"disable":["SLACK_ADD_EMOJI"]},"slackbot":{"tags":{"enable":["destructiveHint"],"disable":["openWorldHint"]}}}
        /// </param>
        /// <param name="tags">
        /// Global MCP tool annotation hints for filtering. Array format is treated as enabled list. Object format supports both enabled (tool must have at least one) and disabled (tool must NOT have any) lists. Toolkit-level tags override this. Toolkit enabled/disabled lists take precedence over tag filtering.<br/>
        /// Example: {"enable":["openWorldHint"],"disable":["destructiveHint"]}
        /// </param>
        /// <param name="workbench"></param>
        /// <param name="multiAccount"></param>
        /// <param name="preload">
        /// Preload configuration. Controls which tools appear in `session.tools` and the MCP server tool list so the agent can call them directly without going through search first — useful for frequently used tools. Each slug must be allowed by the session filters (`toolkits`, `tools`, `tags`), otherwise session creation fails with a 400. Custom tools declared in `custom_tools` / `custom_toolkits` can also be preloaded. Not supported when multi-account is enabled. Each preloaded tool adds to the agent context window, so keep the list at or under ~20 tools.
        /// </param>
        /// <param name="experimental"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PatchToolRouterSessionBySessionIdResponse> PatchToolRouterSessionBySessionIdAsync(
            string sessionId,
            global::Composio.AnyOf<global::Composio.PatchToolRouterSessionBySessionIdRequestToolkitsVariant1, global::Composio.PatchToolRouterSessionBySessionIdRequestToolkitsVariant2>? toolkits = default,
            global::System.Collections.Generic.Dictionary<string, string>? authConfigs = default,
            global::System.Collections.Generic.Dictionary<string, string>? connectedAccounts = default,
            global::Composio.PatchToolRouterSessionBySessionIdRequestManageConnections? manageConnections = default,
            object? tools = default,
            global::Composio.AnyOf<global::System.Collections.Generic.IList<global::Composio.PatchToolRouterSessionBySessionIdRequestTag>, global::Composio.PatchToolRouterSessionBySessionIdRequestTags>? tags = default,
            global::Composio.PatchToolRouterSessionBySessionIdRequestWorkbench? workbench = default,
            global::Composio.PatchToolRouterSessionBySessionIdRequestMultiAccount? multiAccount = default,
            global::Composio.PatchToolRouterSessionBySessionIdRequestPreload? preload = default,
            global::Composio.PatchToolRouterSessionBySessionIdRequestExperimental? experimental = default,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}