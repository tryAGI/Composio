
#nullable enable

namespace Composio
{
    /// <summary>
    /// The connected accounts to use for the session. This will override the default behaviour and use the given connected account when specific toolkits are being executed. Each connected account must exist (not deleted or disabled) and belong to the same `user_id` as the session — otherwise session creation fails with a clear error explaining which account didn't match.<br/>
    /// Example: {"github":"ca_3m4n5o6p7q8r"}
    /// </summary>
    public sealed partial class PatchToolRouterSessionBySessionIdRequestConnectedAccounts
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}