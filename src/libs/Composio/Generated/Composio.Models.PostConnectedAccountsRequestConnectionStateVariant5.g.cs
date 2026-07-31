
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostConnectedAccountsRequestConnectionStateVariant5
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authScheme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant5AuthSchemeJsonConverter))]
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant5AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("val")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant1, global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant2, global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant3, global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant4, global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant5>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.OneOf<global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant1, global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant2, global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant3, global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant4, global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant5> Val { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsRequestConnectionStateVariant5" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostConnectedAccountsRequestConnectionStateVariant5(
            global::Composio.OneOf<global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant1, global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant2, global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant3, global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant4, global::Composio.PostConnectedAccountsRequestConnectionStateVariant5ValVariant5> val,
            global::Composio.PostConnectedAccountsRequestConnectionStateVariant5AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsRequestConnectionStateVariant5" /> class.
        /// </summary>
        public PostConnectedAccountsRequestConnectionStateVariant5()
        {
        }

    }
}