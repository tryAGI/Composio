
#nullable enable

namespace Composio
{
    /// <summary>
    /// The arguments required by the tool<br/>
    /// Default Value: {}<br/>
    /// Example: {"repository":"octocat/Hello-World","workflow_id":"main.yml","ref":"main","inputs":{"environment":"production"}}
    /// </summary>
    public sealed partial class PostToolRouterSessionBySessionIdExecuteRequestArguments
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}