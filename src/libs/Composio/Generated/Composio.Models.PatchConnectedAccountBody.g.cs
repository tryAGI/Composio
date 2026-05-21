
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchConnectedAccountBody
    {
        /// <summary>
        /// A human-readable alias for this connected account. Pass an empty string to clear the alias. Must be unique per entity and toolkit within the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        public string? Alias { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connection")]
        public global::Composio.PatchConnectedAccountBodyConnection? Connection { get; set; }

        /// <summary>
        /// Experimental features - not stable, may be modified or removed in future versions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experimental")]
        public global::Composio.PatchConnectedAccountBodyExperimental? Experimental { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchConnectedAccountBody" /> class.
        /// </summary>
        /// <param name="alias">
        /// A human-readable alias for this connected account. Pass an empty string to clear the alias. Must be unique per entity and toolkit within the project.
        /// </param>
        /// <param name="connection"></param>
        /// <param name="experimental">
        /// Experimental features - not stable, may be modified or removed in future versions.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchConnectedAccountBody(
            string? alias,
            global::Composio.PatchConnectedAccountBodyConnection? connection,
            global::Composio.PatchConnectedAccountBodyExperimental? experimental)
        {
            this.Alias = alias;
            this.Connection = connection;
            this.Experimental = experimental;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchConnectedAccountBody" /> class.
        /// </summary>
        public PatchConnectedAccountBody()
        {
        }

    }
}