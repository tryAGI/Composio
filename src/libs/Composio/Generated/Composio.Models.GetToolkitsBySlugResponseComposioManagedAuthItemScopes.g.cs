
#nullable enable

namespace Composio
{
    /// <summary>
    /// OAuth scopes available in the Composio-managed auth config for this auth mode.<br/>
    /// Example: {"available":["read","write"]}
    /// </summary>
    public sealed partial class GetToolkitsBySlugResponseComposioManagedAuthItemScopes
    {
        /// <summary>
        /// Available OAuth scopes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Available { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolkitsBySlugResponseComposioManagedAuthItemScopes" /> class.
        /// </summary>
        /// <param name="available">
        /// Available OAuth scopes
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetToolkitsBySlugResponseComposioManagedAuthItemScopes(
            global::System.Collections.Generic.IList<string> available)
        {
            this.Available = available ?? throw new global::System.ArgumentNullException(nameof(available));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolkitsBySlugResponseComposioManagedAuthItemScopes" /> class.
        /// </summary>
        public GetToolkitsBySlugResponseComposioManagedAuthItemScopes()
        {
        }

    }
}