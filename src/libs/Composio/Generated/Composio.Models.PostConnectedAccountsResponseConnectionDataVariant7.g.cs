
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostConnectedAccountsResponseConnectionDataVariant7
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authScheme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant7AuthSchemeJsonConverter))]
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant7AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("val")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant4, global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant5, global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant6>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.OneOf<global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant4, global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant5, global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant6> Val { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsResponseConnectionDataVariant7" /> class.
        /// </summary>
        /// <param name="authScheme"></param>
        /// <param name="val"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostConnectedAccountsResponseConnectionDataVariant7(
            global::Composio.OneOf<global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant4, global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant5, global::Composio.PostConnectedAccountsResponseConnectionDataVariant7ValVariant6> val,
            global::Composio.PostConnectedAccountsResponseConnectionDataVariant7AuthScheme authScheme)
        {
            this.Val = val;
            this.AuthScheme = authScheme;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsResponseConnectionDataVariant7" /> class.
        /// </summary>
        public PostConnectedAccountsResponseConnectionDataVariant7()
        {
        }
    }
}