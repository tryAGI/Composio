
#nullable enable

namespace Composio
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PostConnectedAccountsResponseConnectionDataVariant15
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authScheme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PostConnectedAccountsResponseConnectionDataVariant15AuthSchemeJsonConverter))]
        public global::Composio.PostConnectedAccountsResponseConnectionDataVariant15AuthScheme AuthScheme { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("val")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.PostConnectedAccountsResponseConnectionDataVariant15ValVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant15ValVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant15ValVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant15ValVariant4, global::Composio.PostConnectedAccountsResponseConnectionDataVariant15ValVariant5, global::Composio.PostConnectedAccountsResponseConnectionDataVariant15ValVariant6>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.OneOf<global::Composio.PostConnectedAccountsResponseConnectionDataVariant15ValVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant15ValVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant15ValVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant15ValVariant4, global::Composio.PostConnectedAccountsResponseConnectionDataVariant15ValVariant5, global::Composio.PostConnectedAccountsResponseConnectionDataVariant15ValVariant6> Val { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsResponseConnectionDataVariant15" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostConnectedAccountsResponseConnectionDataVariant15(
            global::Composio.OneOf<global::Composio.PostConnectedAccountsResponseConnectionDataVariant15ValVariant1, global::Composio.PostConnectedAccountsResponseConnectionDataVariant15ValVariant2, global::Composio.PostConnectedAccountsResponseConnectionDataVariant15ValVariant3, global::Composio.PostConnectedAccountsResponseConnectionDataVariant15ValVariant4, global::Composio.PostConnectedAccountsResponseConnectionDataVariant15ValVariant5, global::Composio.PostConnectedAccountsResponseConnectionDataVariant15ValVariant6> val,
            global::Composio.PostConnectedAccountsResponseConnectionDataVariant15AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostConnectedAccountsResponseConnectionDataVariant15" /> class.
        /// </summary>
        public PostConnectedAccountsResponseConnectionDataVariant15()
        {
        }

    }
}