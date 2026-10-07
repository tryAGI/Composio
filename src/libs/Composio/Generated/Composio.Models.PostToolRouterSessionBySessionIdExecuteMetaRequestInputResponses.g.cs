
#nullable enable

namespace Composio
{
    /// <summary>
    /// Experimental: the user's answers to the questions an earlier response asked, keyed by the same ids. Send them with the same tool call to continue it.<br/>
    /// Example: {"approval_3f9a1c2b7d4e5f60":{"action":"accept","content":{"decision":"approve"}}}
    /// </summary>
    public sealed partial class PostToolRouterSessionBySessionIdExecuteMetaRequestInputResponses
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}