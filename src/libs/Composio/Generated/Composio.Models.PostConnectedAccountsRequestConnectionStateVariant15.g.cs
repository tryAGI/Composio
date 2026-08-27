
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PostConnectedAccountsRequestConnectionStateVariant15
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authScheme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant15AuthSchemeJsonConverter))]
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant15AuthScheme AuthScheme { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("val")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostConnectedAccountsRequestConnectionStateVariant15ValVariant1, global::Composio.PostConnectedAccountsRequestConnectionStateVariant15ValVariant2, global::Composio.PostConnectedAccountsRequestConnectionStateVariant15ValVariant3, global::Composio.PostConnectedAccountsRequestConnectionStateVariant15ValVariant4, global::Composio.PostConnectedAccountsRequestConnectionStateVariant15ValVariant5, global::Composio.PostConnectedAccountsRequestConnectionStateVariant15ValVariant6>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.OneOf<global::Composio.PostConnectedAccountsRequestConnectionStateVariant15ValVariant1, global::Composio.PostConnectedAccountsRequestConnectionStateVariant15ValVariant2, global::Composio.PostConnectedAccountsRequestConnectionStateVariant15ValVariant3, global::Composio.PostConnectedAccountsRequestConnectionStateVariant15ValVariant4, global::Composio.PostConnectedAccountsRequestConnectionStateVariant15ValVariant5, global::Composio.PostConnectedAccountsRequestConnectionStateVariant15ValVariant6> Val { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsRequestConnectionStateVariant15" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostConnectedAccountsRequestConnectionStateVariant15(
            global::Composio.OneOf<global::Composio.PostConnectedAccountsRequestConnectionStateVariant15ValVariant1, global::Composio.PostConnectedAccountsRequestConnectionStateVariant15ValVariant2, global::Composio.PostConnectedAccountsRequestConnectionStateVariant15ValVariant3, global::Composio.PostConnectedAccountsRequestConnectionStateVariant15ValVariant4, global::Composio.PostConnectedAccountsRequestConnectionStateVariant15ValVariant5, global::Composio.PostConnectedAccountsRequestConnectionStateVariant15ValVariant6> val,
            global::Composio.PostConnectedAccountsRequestConnectionStateVariant15AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsRequestConnectionStateVariant15" /> class.
        /// </summary>
        public PostConnectedAccountsRequestConnectionStateVariant15()
        {
        }

    }
}