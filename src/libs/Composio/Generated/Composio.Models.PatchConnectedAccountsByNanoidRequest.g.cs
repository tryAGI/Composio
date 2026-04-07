
#nullable enable

namespace Composio
{
    /// <summary>
    /// Example: {"alias":"work-gmail"}
    /// </summary>
    public sealed partial class PatchConnectedAccountsByNanoidRequest
    {
        /// <summary>
        /// A human-readable alias for this connected account. Pass an empty string to clear the alias. Must be unique per entity and toolkit within the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Alias { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchConnectedAccountsByNanoidRequest" /> class.
        /// </summary>
        /// <param name="alias">
        /// A human-readable alias for this connected account. Pass an empty string to clear the alias. Must be unique per entity and toolkit within the project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchConnectedAccountsByNanoidRequest(
            string alias)
        {
            this.Alias = alias ?? throw new global::System.ArgumentNullException(nameof(alias));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchConnectedAccountsByNanoidRequest" /> class.
        /// </summary>
        public PatchConnectedAccountsByNanoidRequest()
        {
        }
    }
}