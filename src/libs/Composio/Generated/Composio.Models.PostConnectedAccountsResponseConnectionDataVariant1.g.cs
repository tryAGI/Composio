
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostConnectedAccountsResponseConnectionDataVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authScheme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant1AuthSchemeJsonConverter))]
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant1AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("val")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant4, global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant5, global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant6>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.OneOf<global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant4, global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant5, global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant6> Val { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsResponseConnectionDataVariant1" /> class.
        /// </summary>
        /// <param name="authScheme"></param>
        /// <param name="val"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostConnectedAccountsResponseConnectionDataVariant1(
            global::Composio.OneOf<global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant4, global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant5, global::Composio.PostConnectedAccountsResponseConnectionDataVariant1ValVariant6> val,
            global::Composio.PostConnectedAccountsResponseConnectionDataVariant1AuthScheme authScheme)
        {
            this.Val = val;
            this.AuthScheme = authScheme;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsResponseConnectionDataVariant1" /> class.
        /// </summary>
        public PostConnectedAccountsResponseConnectionDataVariant1()
        {
        }
    }
}