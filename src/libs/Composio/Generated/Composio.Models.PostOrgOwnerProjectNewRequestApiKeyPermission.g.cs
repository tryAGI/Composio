
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PostOrgOwnerProjectNewRequestApiKeyPermission
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PostOrgOwnerProjectNewRequestApiKeyPermissionPresetJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.PostOrgOwnerProjectNewRequestApiKeyPermissionPreset Preset { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PostOrgOwnerProjectNewRequestApiKeyPermissionAccessJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.PostOrgOwnerProjectNewRequestApiKeyPermissionAccess Access { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostOrgOwnerProjectNewRequestApiKeyPermission" /> class.
        /// </summary>
        /// <param name="preset"></param>
        /// <param name="access"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostOrgOwnerProjectNewRequestApiKeyPermission(
            global::Composio.PostOrgOwnerProjectNewRequestApiKeyPermissionPreset preset,
            global::Composio.PostOrgOwnerProjectNewRequestApiKeyPermissionAccess access)
        {
            this.Preset = preset;
            this.Access = access;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostOrgOwnerProjectNewRequestApiKeyPermission" /> class.
        /// </summary>
        public PostOrgOwnerProjectNewRequestApiKeyPermission()
        {
        }

    }
}