
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant1ModeJsonConverter))]
        public global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant1Mode Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant1" /> class.
        /// </summary>
        /// <param name="mode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant1(
            global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant1Mode mode)
        {
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant1" /> class.
        /// </summary>
        public PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant1()
        {
        }

    }
}