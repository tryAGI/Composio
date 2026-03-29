
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConnectedAccountsResponseItemStateVariant8
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authScheme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.GetConnectedAccountsResponseItemStateVariant8AuthSchemeJsonConverter))]
        public global::Composio.GetConnectedAccountsResponseItemStateVariant8AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("val")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant1, global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant2, global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant3, global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant4, global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant5, global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant6>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.OneOf<global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant1, global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant2, global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant3, global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant4, global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant5, global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant6> Val { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsResponseItemStateVariant8" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConnectedAccountsResponseItemStateVariant8(
            global::Composio.OneOf<global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant1, global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant2, global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant3, global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant4, global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant5, global::Composio.GetConnectedAccountsResponseItemStateVariant8ValVariant6> val,
            global::Composio.GetConnectedAccountsResponseItemStateVariant8AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsResponseItemStateVariant8" /> class.
        /// </summary>
        public GetConnectedAccountsResponseItemStateVariant8()
        {
        }
    }
}