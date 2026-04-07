
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConnectedAccountsByNanoidResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolkit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.GetConnectedAccountsByNanoidResponseToolkit Toolkit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.GetConnectedAccountsByNanoidResponseAuthConfig AuthConfig { get; set; }

        /// <summary>
        /// The id of the connection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// A short, token-friendly identifier for multi-account disambiguation, typically toolkit-prefixed with 1-2 words (e.g., "gmail_red-castle")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word_id")]
        public string? WordId { get; set; }

        /// <summary>
        /// A user-defined alias for the connected account
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        public string? Alias { get; set; }

        /// <summary>
        /// This is deprecated, we will not be providing userId from this api anymore, you will only be able to read via userId not get it back
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// The status of the connection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.GetConnectedAccountsByNanoidResponseStatus Status { get; set; }

        /// <summary>
        /// The created at of the connection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// The updated at of the connection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// The state of the connection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant4, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant5, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant11, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.OneOf<global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant4, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant5, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant11, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14> State { get; set; }

        /// <summary>
        /// This is deprecated, use `state` instead
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, object?> Data { get; set; }

        /// <summary>
        /// The reason the connection status changed. Possible reasons: Connection initiation did not complete within 10 minutes, Permanent auth error during token refresh, Max auth failures reached, OAuth callback failed during token exchange, Connection status updated by user, Auth config is disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_reason")]
        public string? StatusReason { get; set; }

        /// <summary>
        /// Whether the connection is disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_disabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsDisabled { get; set; }

        /// <summary>
        /// The endpoint to make test request for verification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_request_endpoint")]
        public string? TestRequestEndpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deprecated")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::Composio.GetConnectedAccountsByNanoidResponseDeprecated? Deprecated { get; set; }

        /// <summary>
        /// The initialization data of the connection, including configuration parameters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, object?> Params { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsByNanoidResponse" /> class.
        /// </summary>
        /// <param name="toolkit"></param>
        /// <param name="authConfig"></param>
        /// <param name="id">
        /// The id of the connection
        /// </param>
        /// <param name="userId">
        /// This is deprecated, we will not be providing userId from this api anymore, you will only be able to read via userId not get it back
        /// </param>
        /// <param name="status">
        /// The status of the connection
        /// </param>
        /// <param name="createdAt">
        /// The created at of the connection
        /// </param>
        /// <param name="updatedAt">
        /// The updated at of the connection
        /// </param>
        /// <param name="state">
        /// The state of the connection
        /// </param>
        /// <param name="data">
        /// This is deprecated, use `state` instead
        /// </param>
        /// <param name="isDisabled">
        /// Whether the connection is disabled
        /// </param>
        /// <param name="params">
        /// The initialization data of the connection, including configuration parameters
        /// </param>
        /// <param name="wordId">
        /// A short, token-friendly identifier for multi-account disambiguation, typically toolkit-prefixed with 1-2 words (e.g., "gmail_red-castle")
        /// </param>
        /// <param name="alias">
        /// A user-defined alias for the connected account
        /// </param>
        /// <param name="statusReason">
        /// The reason the connection status changed. Possible reasons: Connection initiation did not complete within 10 minutes, Permanent auth error during token refresh, Max auth failures reached, OAuth callback failed during token exchange, Connection status updated by user, Auth config is disabled
        /// </param>
        /// <param name="testRequestEndpoint">
        /// The endpoint to make test request for verification
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConnectedAccountsByNanoidResponse(
            global::Composio.GetConnectedAccountsByNanoidResponseToolkit toolkit,
            global::Composio.GetConnectedAccountsByNanoidResponseAuthConfig authConfig,
            string id,
            string userId,
            global::Composio.GetConnectedAccountsByNanoidResponseStatus status,
            string createdAt,
            string updatedAt,
            global::Composio.OneOf<global::Composio.GetConnectedAccountsByNanoidResponseStateVariant1, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant3, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant4, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant5, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant7, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant9, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant10, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant11, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant12, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant13, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant14> state,
            global::System.Collections.Generic.Dictionary<string, object?> data,
            bool isDisabled,
            global::System.Collections.Generic.Dictionary<string, object?> @params,
            string? wordId,
            string? alias,
            string? statusReason,
            string? testRequestEndpoint)
        {
            this.Toolkit = toolkit ?? throw new global::System.ArgumentNullException(nameof(toolkit));
            this.AuthConfig = authConfig ?? throw new global::System.ArgumentNullException(nameof(authConfig));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.WordId = wordId;
            this.Alias = alias;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Status = status;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.State = state;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.StatusReason = statusReason;
            this.IsDisabled = isDisabled;
            this.TestRequestEndpoint = testRequestEndpoint;
            this.Params = @params ?? throw new global::System.ArgumentNullException(nameof(@params));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsByNanoidResponse" /> class.
        /// </summary>
        public GetConnectedAccountsByNanoidResponse()
        {
        }
    }
}