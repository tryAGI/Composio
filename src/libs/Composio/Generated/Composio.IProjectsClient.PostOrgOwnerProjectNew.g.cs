#nullable enable

namespace Composio
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Create a new project<br/>
        /// Creates a new project within the authenticated user's organization using the specified name. Projects are isolated environments within your organization, each with their own API keys, webhook configurations, and resources. Use this endpoint to create additional projects for different environments (e.g., development, staging, production) or for separate applications.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PostOrgOwnerProjectNewResponse> PostOrgOwnerProjectNewAsync(

            global::Composio.PostOrgOwnerProjectNewRequest request,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new project<br/>
        /// Creates a new project within the authenticated user's organization using the specified name. Projects are isolated environments within your organization, each with their own API keys, webhook configurations, and resources. Use this endpoint to create additional projects for different environments (e.g., development, staging, production) or for separate applications.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Composio.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.AutoSDKHttpResponse<global::Composio.PostOrgOwnerProjectNewResponse>> PostOrgOwnerProjectNewAsResponseAsync(

            global::Composio.PostOrgOwnerProjectNewRequest request,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new project<br/>
        /// Creates a new project within the authenticated user's organization using the specified name. Projects are isolated environments within your organization, each with their own API keys, webhook configurations, and resources. Use this endpoint to create additional projects for different environments (e.g., development, staging, production) or for separate applications.
        /// </summary>
        /// <param name="name">
        /// A unique name for your project that follows the required format rules<br/>
        /// Example: my-awesome-project
        /// </param>
        /// <param name="shouldCreateApiKey">
        /// Whether to create an API key for the project. If true, the API key will be created and returned in the response.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
        /// <param name="apiKeyAllowedIps">
        /// IPv4 or IPv6 addresses allowed to use the project API key. Requires should_create_api_key to be true. Omit to allow requests from any IP address.<br/>
        /// Example: [203.0.113.10]
        /// </param>
        /// <param name="apiKeyPermissions">
        /// Permission levels for the project API key. Requires should_create_api_key to be true. Omit to create a full-access API key.<br/>
        /// Example: [{"preset":"tool_execution","access":"write"}]
        /// </param>
        /// <param name="config">
        /// Configuration for the project. Use zdr_enabled for Zero Data Retention; log_visibility_setting remains supported for existing clients. Do not send both fields.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Composio.PostOrgOwnerProjectNewResponse> PostOrgOwnerProjectNewAsync(
            string name,
            bool? shouldCreateApiKey = default,
            global::System.Collections.Generic.IList<string>? apiKeyAllowedIps = default,
            global::System.Collections.Generic.IList<global::Composio.PostOrgOwnerProjectNewRequestApiKeyPermission>? apiKeyPermissions = default,
            global::Composio.PostOrgOwnerProjectNewRequestConfig? config = default,
            global::Composio.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}