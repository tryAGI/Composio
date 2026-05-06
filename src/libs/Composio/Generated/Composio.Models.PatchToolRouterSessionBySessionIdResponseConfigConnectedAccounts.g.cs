
#nullable enable

namespace Composio
{
    /// <summary>
    /// Per-toolkit connected account override (single nano-ID). Returns the first override when multi-account is enabled; see `all_connected_accounts` for the full list.
    /// </summary>
    public sealed partial class PatchToolRouterSessionBySessionIdResponseConfigConnectedAccounts
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}