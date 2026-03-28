
#nullable enable

namespace Composio
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConnectedAccountsByNanoidResponseStateVariant6
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authScheme")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant6AuthSchemeJsonConverter))]
        public global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6AuthScheme AuthScheme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("val")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.OneOfJsonConverter<global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant1, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant2, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant3, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant4>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Composio.OneOf<global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant1, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant2, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant3, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant4> Val { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsByNanoidResponseStateVariant6" /> class.
        /// </summary>
        /// <param name="authScheme"></param>
        /// <param name="val"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConnectedAccountsByNanoidResponseStateVariant6(
            global::Composio.OneOf<global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant1, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant2, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant3, global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6ValVariant4> val,
            global::Composio.GetConnectedAccountsByNanoidResponseStateVariant6AuthScheme authScheme)
        {
            this.Val = val;
            this.AuthScheme = authScheme;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConnectedAccountsByNanoidResponseStateVariant6" /> class.
        /// </summary>
        public GetConnectedAccountsByNanoidResponseStateVariant6()
        {
        }
    }
}