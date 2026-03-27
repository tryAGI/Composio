#nullable enable

namespace Composio
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Update project configuration<br/>
        /// Updates the project configuration settings.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PatchOrgProjectConfigResponse> PatchOrgProjectConfigAsync(

            global::Composio.PatchOrgProjectConfigRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update project configuration<br/>
        /// Updates the project configuration settings.
        /// </summary>
        /// <param name="is2faEnabled"></param>
        /// <param name="logoUrl"></param>
        /// <param name="displayName"></param>
        /// <param name="maskSecretKeysInConnectedAccount"></param>
        /// <param name="logVisibilitySetting"></param>
        /// <param name="requireMcpApiKey"></param>
        /// <param name="isComposioLinkEnabledForManagedAuth">
        /// Whether to enable composio link for managed authentication. This key will be deprecated in the future. Please don't use this key.
        /// </param>
        /// <param name="signedUrlFileExpiryInSeconds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PatchOrgProjectConfigResponse> PatchOrgProjectConfigAsync(
            bool? is2faEnabled = default,
            string? logoUrl = default,
            string? displayName = default,
            bool? maskSecretKeysInConnectedAccount = default,
            global::Composio.PatchOrgProjectConfigRequestLogVisibilitySetting? logVisibilitySetting = default,
            bool? requireMcpApiKey = default,
            bool? isComposioLinkEnabledForManagedAuth = default,
            double? signedUrlFileExpiryInSeconds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}