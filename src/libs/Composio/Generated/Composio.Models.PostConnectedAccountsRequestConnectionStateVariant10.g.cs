
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PostConnectedAccountsRequestConnectionStateVariant10
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authScheme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant10AuthSchemeJsonConverter))]
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant10AuthScheme AuthScheme { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("val")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant1, global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant2, global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant3, global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant4, global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant5, global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant6>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.OneOf<global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant1, global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant2, global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant3, global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant4, global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant5, global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant6> Val { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsRequestConnectionStateVariant10" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostConnectedAccountsRequestConnectionStateVariant10(
            global::Composio.OneOf<global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant1, global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant2, global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant3, global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant4, global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant5, global::Composio.PostConnectedAccountsRequestConnectionStateVariant10ValVariant6> val,
            global::Composio.PostConnectedAccountsRequestConnectionStateVariant10AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsRequestConnectionStateVariant10" /> class.
        /// </summary>
        public PostConnectedAccountsRequestConnectionStateVariant10()
        {
        }

    }
}