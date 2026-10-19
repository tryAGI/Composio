
#nullable enable

namespace Composio
{
    /// <summary>
    /// Hooks that run on this session's tool calls. A hook can block a call before it runs, or block its result before the agent sees it.
    /// </summary>
    public sealed partial class PostToolRouterSessionRequestHooks
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}