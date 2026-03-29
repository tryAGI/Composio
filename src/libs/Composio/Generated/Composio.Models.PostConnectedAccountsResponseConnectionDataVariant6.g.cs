
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostConnectedAccountsResponseConnectionDataVariant6
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authScheme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant6AuthSchemeJsonConverter))]
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant6AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("val")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant4>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.OneOf<global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant4> Val { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsResponseConnectionDataVariant6" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostConnectedAccountsResponseConnectionDataVariant6(
            global::Composio.OneOf<global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant6ValVariant4> val,
            global::Composio.PostConnectedAccountsResponseConnectionDataVariant6AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsResponseConnectionDataVariant6" /> class.
        /// </summary>
        public PostConnectedAccountsResponseConnectionDataVariant6()
        {
        }
    }
}