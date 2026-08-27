
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PostConnectedAccountsRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.PostConnectedAccountsRequestAuthConfig AuthConfig { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connection")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.PostConnectedAccountsRequestConnection Connection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsRequest" /> class.
        /// </summary>
        /// <param name="authConfig"></param>
        /// <param name="connection"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostConnectedAccountsRequest(
            global::Composio.PostConnectedAccountsRequestAuthConfig authConfig,
            global::Composio.PostConnectedAccountsRequestConnection connection)
        {
            this.AuthConfig = authConfig ?? throw new global::System.ArgumentNullException(nameof(authConfig));
            this.Connection = connection ?? throw new global::System.ArgumentNullException(nameof(connection));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsRequest" /> class.
        /// </summary>
        public PostConnectedAccountsRequest()
        {
        }

    }
}