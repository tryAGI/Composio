
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConnectedAccountsResponseItemStateVariant9
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authScheme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant9AuthSchemeJsonConverter))]
        public global::Composio.GetConnectedAccountsResponseItemStateVariant9AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("val")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant1, global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant2, global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant3, global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant4, global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant5, global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant6>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.OneOf<global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant1, global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant2, global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant3, global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant4, global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant5, global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant6> Val { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsResponseItemStateVariant9" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConnectedAccountsResponseItemStateVariant9(
            global::Composio.OneOf<global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant1, global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant2, global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant3, global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant4, global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant5, global::Composio.GetConnectedAccountsResponseItemStateVariant9ValVariant6> val,
            global::Composio.GetConnectedAccountsResponseItemStateVariant9AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsResponseItemStateVariant9" /> class.
        /// </summary>
        public GetConnectedAccountsResponseItemStateVariant9()
        {
        }

    }
}