
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2ModeJsonConverter))]
        public global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2Mode Mode { get; set; }

        /// <summary>
        /// Headers sent to the MCP server. Use {{generic_api_key}} where the API key goes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Headers { get; set; }

        /// <summary>
        /// Label and help text for the API key input on the connect page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_field")]
        public global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2ApiKeyField? ApiKeyField { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2" /> class.
        /// </summary>
        /// <param name="headers">
        /// Headers sent to the MCP server. Use {{generic_api_key}} where the API key goes.
        /// </param>
        /// <param name="mode"></param>
        /// <param name="apiKeyField">
        /// Label and help text for the API key input on the connect page
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2(
            global::System.Collections.Generic.Dictionary<string, string> headers,
            global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2Mode mode,
            global::Composio.PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2ApiKeyField? apiKeyField)
        {
            this.Mode = mode;
            this.Headers = headers ?? throw new global::System.ArgumentNullException(nameof(headers));
            this.ApiKeyField = apiKeyField;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2" /> class.
        /// </summary>
        public PostCustomToolkitsUpsertRequestToolkitConfigAuthSchemeVariant2()
        {
        }

    }
}