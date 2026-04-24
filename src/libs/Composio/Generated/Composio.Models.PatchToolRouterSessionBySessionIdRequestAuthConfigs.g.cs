
#nullable enable

namespace Composio
{
    /// <summary>
    /// The auth configs to use for the session. This will override the default behavior and use the given auth config when specific toolkits are being executed<br/>
    /// Example: {"gmail":"ac_1a2b3c4d5e6f","slack":"ac_7g8h9i0j1k2l"}
    /// </summary>
    public sealed partial class PatchToolRouterSessionBySessionIdRequestAuthConfigs
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}