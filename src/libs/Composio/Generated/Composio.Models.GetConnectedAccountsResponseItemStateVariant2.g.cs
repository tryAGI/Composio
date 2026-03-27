
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConnectedAccountsResponseItemStateVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authScheme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant2AuthSchemeJsonConverter))]
        public global::Composio.GetConnectedAccountsResponseItemStateVariant2AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("val")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant1, global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant2, global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant3, global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant4, global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant5, global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant6>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.OneOf<global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant1, global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant2, global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant3, global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant4, global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant5, global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant6> Val { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsResponseItemStateVariant2" /> class.
        /// </summary>
        /// <param name="authScheme"></param>
        /// <param name="val"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConnectedAccountsResponseItemStateVariant2(
            global::Composio.OneOf<global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant1, global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant2, global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant3, global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant4, global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant5, global::Composio.GetConnectedAccountsResponseItemStateVariant2ValVariant6> val,
            global::Composio.GetConnectedAccountsResponseItemStateVariant2AuthScheme authScheme)
        {
            this.Val = val;
            this.AuthScheme = authScheme;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsResponseItemStateVariant2" /> class.
        /// </summary>
        public GetConnectedAccountsResponseItemStateVariant2()
        {
        }
    }
}