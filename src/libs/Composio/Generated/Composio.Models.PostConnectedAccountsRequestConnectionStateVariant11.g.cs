
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostConnectedAccountsRequestConnectionStateVariant11
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authScheme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PostConnectedAccountsRequestConnectionStateVariant11AuthSchemeJsonConverter))]
        public global::Composio.PostConnectedAccountsRequestConnectionStateVariant11AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("val")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant1, global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant2, global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant3, global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant4>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.OneOf<global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant1, global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant2, global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant3, global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant4> Val { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsRequestConnectionStateVariant11" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostConnectedAccountsRequestConnectionStateVariant11(
            global::Composio.OneOf<global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant1, global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant2, global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant3, global::Composio.PostConnectedAccountsRequestConnectionStateVariant11ValVariant4> val,
            global::Composio.PostConnectedAccountsRequestConnectionStateVariant11AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsRequestConnectionStateVariant11" /> class.
        /// </summary>
        public PostConnectedAccountsRequestConnectionStateVariant11()
        {
        }
    }
}