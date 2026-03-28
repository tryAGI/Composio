
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConnectedAccountsResponseItemStateVariant14
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authScheme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant14AuthSchemeJsonConverter))]
        public global::Composio.GetConnectedAccountsResponseItemStateVariant14AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("val")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant1, global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant2, global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant3, global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant4, global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant5, global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant6>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.OneOf<global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant1, global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant2, global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant3, global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant4, global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant5, global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant6> Val { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsResponseItemStateVariant14" /> class.
        /// </summary>
        /// <param name="authScheme"></param>
        /// <param name="val"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConnectedAccountsResponseItemStateVariant14(
            global::Composio.OneOf<global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant1, global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant2, global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant3, global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant4, global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant5, global::Composio.GetConnectedAccountsResponseItemStateVariant14ValVariant6> val,
            global::Composio.GetConnectedAccountsResponseItemStateVariant14AuthScheme authScheme)
        {
            this.Val = val;
            this.AuthScheme = authScheme;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsResponseItemStateVariant14" /> class.
        /// </summary>
        public GetConnectedAccountsResponseItemStateVariant14()
        {
        }
    }
}