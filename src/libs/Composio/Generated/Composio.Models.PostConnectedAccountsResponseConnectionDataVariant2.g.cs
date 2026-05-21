
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostConnectedAccountsResponseConnectionDataVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authScheme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant2AuthSchemeJsonConverter))]
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant2AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("val")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant4, global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant5, global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant6, global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant7>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.OneOf<global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant4, global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant5, global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant6, global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant7> Val { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsResponseConnectionDataVariant2" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostConnectedAccountsResponseConnectionDataVariant2(
            global::Composio.OneOf<global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant4, global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant5, global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant6, global::Composio.PostConnectedAccountsResponseConnectionDataVariant2ValVariant7> val,
            global::Composio.PostConnectedAccountsResponseConnectionDataVariant2AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsResponseConnectionDataVariant2" /> class.
        /// </summary>
        public PostConnectedAccountsResponseConnectionDataVariant2()
        {
        }

    }
}