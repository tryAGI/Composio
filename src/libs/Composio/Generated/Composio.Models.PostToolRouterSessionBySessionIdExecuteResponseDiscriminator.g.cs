
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PostToolRouterSessionBySessionIdExecuteResponseDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PostToolRouterSessionBySessionIdExecuteResponseDiscriminatorResultTypeJsonConverter))]
        public global::Composio.PostToolRouterSessionBySessionIdExecuteResponseDiscriminatorResultType? ResultType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdExecuteResponseDiscriminator" /> class.
        /// </summary>
        /// <param name="resultType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolRouterSessionBySessionIdExecuteResponseDiscriminator(
            global::Composio.PostToolRouterSessionBySessionIdExecuteResponseDiscriminatorResultType? resultType)
        {
            this.ResultType = resultType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionBySessionIdExecuteResponseDiscriminator" /> class.
        /// </summary>
        public PostToolRouterSessionBySessionIdExecuteResponseDiscriminator()
        {
        }

    }
}