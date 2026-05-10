
#nullable enable

namespace Composio
{
    /// <summary>
    /// Information about the authenticated user<br/>
    /// Example: {"id":"550e8400-e29b-41d4-a716-446655440002","email":"user@example.com","name":"John Doe","role":"admin","metadata":{"prefers_old_dashboard":false}}
    /// </summary>
    public sealed partial class GetAuthSessionInfoResponseOrgMember
    {
        /// <summary>
        /// UUID identifier for the organization member<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440002
        /// </summary>
        /// <example>550e8400-e29b-41d4-a716-446655440002</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Email address of the authenticated user<br/>
        /// Example: user@example.com
        /// </summary>
        /// <example>user@example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// Display name of the authenticated user<br/>
        /// Example: John Doe
        /// </summary>
        /// <example>John Doe</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Access role of the authenticated user within the organization<br/>
        /// Example: admin
        /// </summary>
        /// <example>admin</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Role { get; set; }

        /// <summary>
        /// User metadata (JSONB). Typed keys are shown; additional keys pass through unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.GetAuthSessionInfoResponseOrgMemberMetadata Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAuthSessionInfoResponseOrgMember" /> class.
        /// </summary>
        /// <param name="id">
        /// UUID identifier for the organization member<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440002
        /// </param>
        /// <param name="email">
        /// Email address of the authenticated user<br/>
        /// Example: user@example.com
        /// </param>
        /// <param name="name">
        /// Display name of the authenticated user<br/>
        /// Example: John Doe
        /// </param>
        /// <param name="role">
        /// Access role of the authenticated user within the organization<br/>
        /// Example: admin
        /// </param>
        /// <param name="metadata">
        /// User metadata (JSONB). Typed keys are shown; additional keys pass through unchanged.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAuthSessionInfoResponseOrgMember(
            string id,
            string email,
            string name,
            string role,
            global::Composio.GetAuthSessionInfoResponseOrgMemberMetadata metadata)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAuthSessionInfoResponseOrgMember" /> class.
        /// </summary>
        public GetAuthSessionInfoResponseOrgMember()
        {
        }

    }
}