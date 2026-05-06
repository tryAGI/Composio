
#nullable enable

namespace Composio
{
    /// <summary>
    /// Per-toolkit connected account override (single nano-ID). Each connected account must exist (not deleted or disabled) and belong to the same `user_id` as the session.<br/>
    /// Example: {"github":"ca_3m4n5o6p7q8r"}
    /// </summary>
    public sealed partial class PostToolRouterSessionRequestConnectedAccounts
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}