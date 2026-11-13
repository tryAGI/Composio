
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetToolkitsBySlugResponseComposioManagedAuthItem
    {
        /// <summary>
        /// Unique id of this Composio-managed app.<br/>
        /// Example: ma_V1StGXR8_Z5j
        /// </summary>
        /// <example>ma_V1StGXR8_Z5j</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("managed_app_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ManagedAppId { get; set; }

        /// <summary>
        /// Whether this is the toolkit's default Composio-managed app.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_default")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsDefault { get; set; }

        /// <summary>
        /// Authentication mode for the Composio-managed auth config<br/>
        /// Example: OAUTH2
        /// </summary>
        /// <example>OAUTH2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Mode { get; set; }

        /// <summary>
        /// OAuth scopes available in the Composio-managed auth config for this auth mode.<br/>
        /// Example: {"available":["read","write"]}
        /// </summary>
        /// <example>{"available":["read","write"]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.GetToolkitsBySlugResponseComposioManagedAuthItemScopes Scopes { get; set; }

        /// <summary>
        /// OAuth user scopes available in the Composio-managed auth config for this auth mode. Only present for Slack toolkits.<br/>
        /// Example: {"available":["search:read","users:read"]}
        /// </summary>
        /// <example>{"available":["search:read","users:read"]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_scopes")]
        public global::Composio.GetToolkitsBySlugResponseComposioManagedAuthItemUserScopes? UserScopes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolkitsBySlugResponseComposioManagedAuthItem" /> class.
        /// </summary>
        /// <param name="managedAppId">
        /// Unique id of this Composio-managed app.<br/>
        /// Example: ma_V1StGXR8_Z5j
        /// </param>
        /// <param name="isDefault">
        /// Whether this is the toolkit's default Composio-managed app.<br/>
        /// Example: true
        /// </param>
        /// <param name="mode">
        /// Authentication mode for the Composio-managed auth config<br/>
        /// Example: OAUTH2
        /// </param>
        /// <param name="scopes">
        /// OAuth scopes available in the Composio-managed auth config for this auth mode.<br/>
        /// Example: {"available":["read","write"]}
        /// </param>
        /// <param name="userScopes">
        /// OAuth user scopes available in the Composio-managed auth config for this auth mode. Only present for Slack toolkits.<br/>
        /// Example: {"available":["search:read","users:read"]}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetToolkitsBySlugResponseComposioManagedAuthItem(
            string managedAppId,
            bool isDefault,
            string mode,
            global::Composio.GetToolkitsBySlugResponseComposioManagedAuthItemScopes scopes,
            global::Composio.GetToolkitsBySlugResponseComposioManagedAuthItemUserScopes? userScopes)
        {
            this.ManagedAppId = managedAppId ?? throw new global::System.ArgumentNullException(nameof(managedAppId));
            this.IsDefault = isDefault;
            this.Mode = mode ?? throw new global::System.ArgumentNullException(nameof(mode));
            this.Scopes = scopes ?? throw new global::System.ArgumentNullException(nameof(scopes));
            this.UserScopes = userScopes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolkitsBySlugResponseComposioManagedAuthItem" /> class.
        /// </summary>
        public GetToolkitsBySlugResponseComposioManagedAuthItem()
        {
        }

    }
}