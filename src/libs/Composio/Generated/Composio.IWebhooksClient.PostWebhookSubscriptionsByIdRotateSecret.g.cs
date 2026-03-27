#nullable enable

namespace Composio
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        /// Rotate webhook secret<br/>
        /// Generates a new signing secret for the webhook subscription. The new secret is returned only in this response.
        /// </summary>
        /// <param name="id">
        /// Webhook subscription ID
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PostWebhookSubscriptionsByIdRotateSecretResponse> PostWebhookSubscriptionsByIdRotateSecretAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}