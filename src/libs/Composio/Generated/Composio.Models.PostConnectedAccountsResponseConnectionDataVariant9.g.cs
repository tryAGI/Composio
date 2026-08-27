
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PostConnectedAccountsResponseConnectionDataVariant9
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authScheme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant9AuthSchemeJsonConverter))]
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant9AuthScheme AuthScheme { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("val")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant4, global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant5, global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant6>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.OneOf<global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant4, global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant5, global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant6> Val { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsResponseConnectionDataVariant9" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostConnectedAccountsResponseConnectionDataVariant9(
            global::Composio.OneOf<global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant4, global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant5, global::Composio.PostConnectedAccountsResponseConnectionDataVariant9ValVariant6> val,
            global::Composio.PostConnectedAccountsResponseConnectionDataVariant9AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsResponseConnectionDataVariant9" /> class.
        /// </summary>
        public PostConnectedAccountsResponseConnectionDataVariant9()
        {
        }

    }
}