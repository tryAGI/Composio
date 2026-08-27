
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CustomAuthConfigUpdateCredentials
    {
        /// <summary>
        /// OAuth scopes requested for the auth config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Composio.AnyOf<string, global::System.Collections.Generic.IList<string>>? Scopes { get; set; }

        /// <summary>
        /// OAuth user-token scopes requested for the auth config. This is primarily used by Slack OAuth v2.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_scopes")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Composio.AnyOf<string, global::System.Collections.Generic.IList<string>>? UserScopes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomAuthConfigUpdateCredentials" /> class.
        /// </summary>
        /// <param name="scopes">
        /// OAuth scopes requested for the auth config.
        /// </param>
        /// <param name="userScopes">
        /// OAuth user-token scopes requested for the auth config. This is primarily used by Slack OAuth v2.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomAuthConfigUpdateCredentials(
            global::Composio.AnyOf<string, global::System.Collections.Generic.IList<string>>? scopes,
            global::Composio.AnyOf<string, global::System.Collections.Generic.IList<string>>? userScopes)
        {
            this.Scopes = scopes;
            this.UserScopes = userScopes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomAuthConfigUpdateCredentials" /> class.
        /// </summary>
        public CustomAuthConfigUpdateCredentials()
        {
        }

    }
}