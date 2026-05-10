
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConnectedAccountsByNanoidResponseStateVariant8
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authScheme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant8AuthSchemeJsonConverter))]
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("val")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant1, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant2, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant3, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant4, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant5, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant6>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.OneOf<global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant1, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant2, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant3, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant4, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant5, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant6> Val { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsByNanoidResponseStateVariant8" /> class.
        /// </summary>
        /// <param name="val"></param>
        /// <param name="authScheme"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConnectedAccountsByNanoidResponseStateVariant8(
            global::Composio.OneOf<global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant1, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant2, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant3, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant4, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant5, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8ValVariant6> val,
            global::Composio.GetConnectedAccountsByNanoidResponseStateVariant8AuthScheme authScheme)
        {
            this.AuthScheme = authScheme;
            this.Val = val;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsByNanoidResponseStateVariant8" /> class.
        /// </summary>
        public GetConnectedAccountsByNanoidResponseStateVariant8()
        {
        }

    }
}