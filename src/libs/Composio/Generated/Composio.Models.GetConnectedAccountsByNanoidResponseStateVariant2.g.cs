
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConnectedAccountsByNanoidResponseStateVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authScheme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant2AuthSchemeJsonConverter))]
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("val")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant1, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant2, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant3, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant4, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant5, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant6, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant7>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.OneOf<global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant1, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant2, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant3, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant4, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant5, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant6, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant7> Val { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsByNanoidResponseStateVariant2" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConnectedAccountsByNanoidResponseStateVariant2(
            global::Composio.OneOf<global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant1, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant2, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant3, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant4, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant5, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant6, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2ValVariant7> val,
            global::Composio.GetConnectedAccountsByNanoidResponseStateVariant2AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsByNanoidResponseStateVariant2" /> class.
        /// </summary>
        public GetConnectedAccountsByNanoidResponseStateVariant2()
        {
        }

    }
}