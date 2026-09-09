
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PostAuthConfigsResponseAuthConfig
    {
        /// <summary>
        /// The auth config id of the toolkit (must be a valid auth config id)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The authentication mode of the toolkit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_scheme")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AuthScheme { get; set; }

        /// <summary>
        /// Whether the auth config is managed by Composio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_composio_managed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsComposioManaged { get; set; }

        /// <summary>
        /// The tools that the user can use with the auth config. DEPRECATED: use [Get required scopes](https://docs.composio.dev/reference/api-reference/toolkits/recommendToolkitScopes) to resolve the scopes for the tools you need, then pass those scopes in `credentials.scopes`.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restrict_to_following_tools")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? RestrictToFollowingTools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostAuthConfigsResponseAuthConfig" /> class.
        /// </summary>
        /// <param name="id">
        /// The auth config id of the toolkit (must be a valid auth config id)
        /// </param>
        /// <param name="authScheme">
        /// The authentication mode of the toolkit
        /// </param>
        /// <param name="isComposioManaged">
        /// Whether the auth config is managed by Composio
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostAuthConfigsResponseAuthConfig(
            string id,
            string authScheme,
            bool isComposioManaged)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AuthScheme = authScheme ?? throw new global::System.ArgumentNullException(nameof(authScheme));
            this.IsComposioManaged = isComposioManaged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostAuthConfigsResponseAuthConfig" /> class.
        /// </summary>
        public PostAuthConfigsResponseAuthConfig()
        {
        }

    }
}