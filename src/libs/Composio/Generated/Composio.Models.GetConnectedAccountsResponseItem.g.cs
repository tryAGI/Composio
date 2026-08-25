
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConnectedAccountsResponseItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolkit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.GetConnectedAccountsResponseItemToolkit Toolkit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.GetConnectedAccountsResponseItemAuthConfig AuthConfig { get; set; }

        /// <summary>
        /// The id of the connection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Duplicates state.authScheme. Kept for backward compatibility with existing readers; use state.authScheme instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authScheme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemAuthSchemeJsonConverter))]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::Composio.GetConnectedAccountsResponseItemAuthScheme? AuthScheme { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.GetConnectedAccountsResponseItemStatus Status { get; set; }

        /// <summary>
        /// Experimental features - not stable, may be modified or removed in future versions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experimental")]
        public global::Composio.GetConnectedAccountsResponseItemExperimental? Experimental { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.GetConnectedAccountsResponseItemStateVariant1, global::Composio.GetConnectedAccountsResponseItemStateVariant2, global::Composio.GetConnectedAccountsResponseItemStateVariant3, global::Composio.GetConnectedAccountsResponseItemStateVariant4, global::Composio.GetConnectedAccountsResponseItemStateVariant5, global::Composio.GetConnectedAccountsResponseItemStateVariant6, global::Composio.GetConnectedAccountsResponseItemStateVariant7, global::Composio.GetConnectedAccountsResponseItemStateVariant8, global::Composio.GetConnectedAccountsResponseItemStateVariant9, global::Composio.GetConnectedAccountsResponseItemStateVariant10, global::Composio.GetConnectedAccountsResponseItemStateVariant11, global::Composio.GetConnectedAccountsResponseItemStateVariant12, global::Composio.GetConnectedAccountsResponseItemStateVariant13, global::Composio.GetConnectedAccountsResponseItemStateVariant14, global::Composio.GetConnectedAccountsResponseItemStateVariant15>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.OneOf<global::Composio.GetConnectedAccountsResponseItemStateVariant1, global::Composio.GetConnectedAccountsResponseItemStateVariant2, global::Composio.GetConnectedAccountsResponseItemStateVariant3, global::Composio.GetConnectedAccountsResponseItemStateVariant4, global::Composio.GetConnectedAccountsResponseItemStateVariant5, global::Composio.GetConnectedAccountsResponseItemStateVariant6, global::Composio.GetConnectedAccountsResponseItemStateVariant7, global::Composio.GetConnectedAccountsResponseItemStateVariant8, global::Composio.GetConnectedAccountsResponseItemStateVariant9, global::Composio.GetConnectedAccountsResponseItemStateVariant10, global::Composio.GetConnectedAccountsResponseItemStateVariant11, global::Composio.GetConnectedAccountsResponseItemStateVariant12, global::Composio.GetConnectedAccountsResponseItemStateVariant13, global::Composio.GetConnectedAccountsResponseItemStateVariant14, global::Composio.GetConnectedAccountsResponseItemStateVariant15> State { get; set; }

        /// <summary>
        /// This is deprecated, use `state` instead
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, object?> Data { get; set; }

        /// <summary>
        /// The reason the connection status changed.
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsResponseItem" /> class.
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
        /// <param name="wordId">
        /// A short, token-friendly identifier for multi-account disambiguation, typically toolkit-prefixed with 1-2 words (e.g., "gmail_red-castle")
        /// </param>
        /// <param name="alias">
        /// A user-defined alias for the connected account
        /// </param>
        /// <param name="experimental">
        /// Experimental features - not stable, may be modified or removed in future versions.
        /// </param>
        /// <param name="statusReason">
        /// The reason the connection status changed.
        /// </param>
        /// <param name="testRequestEndpoint">
        /// The endpoint to make test request for verification
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConnectedAccountsResponseItem(
            global::Composio.GetConnectedAccountsResponseItemToolkit toolkit,
            global::Composio.GetConnectedAccountsResponseItemAuthConfig authConfig,
            string id,
            string userId,
            global::Composio.GetConnectedAccountsResponseItemStatus status,
            string createdAt,
            string updatedAt,
            global::Composio.OneOf<global::Composio.GetConnectedAccountsResponseItemStateVariant1, global::Composio.GetConnectedAccountsResponseItemStateVariant2, global::Composio.GetConnectedAccountsResponseItemStateVariant3, global::Composio.GetConnectedAccountsResponseItemStateVariant4, global::Composio.GetConnectedAccountsResponseItemStateVariant5, global::Composio.GetConnectedAccountsResponseItemStateVariant6, global::Composio.GetConnectedAccountsResponseItemStateVariant7, global::Composio.GetConnectedAccountsResponseItemStateVariant8, global::Composio.GetConnectedAccountsResponseItemStateVariant9, global::Composio.GetConnectedAccountsResponseItemStateVariant10, global::Composio.GetConnectedAccountsResponseItemStateVariant11, global::Composio.GetConnectedAccountsResponseItemStateVariant12, global::Composio.GetConnectedAccountsResponseItemStateVariant13, global::Composio.GetConnectedAccountsResponseItemStateVariant14, global::Composio.GetConnectedAccountsResponseItemStateVariant15> state,
            global::System.Collections.Generic.Dictionary<string, object?> data,
            bool isDisabled,
            string? wordId,
            string? alias,
            global::Composio.GetConnectedAccountsResponseItemExperimental? experimental,
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
            this.Experimental = experimental;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.State = state;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.StatusReason = statusReason;
            this.IsDisabled = isDisabled;
            this.TestRequestEndpoint = testRequestEndpoint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsResponseItem" /> class.
        /// </summary>
        public GetConnectedAccountsResponseItem()
        {
        }

    }
}