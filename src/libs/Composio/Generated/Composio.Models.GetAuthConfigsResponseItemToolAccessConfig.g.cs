
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Composio
{
    /// <summary>
    /// DEPRECATED: use [Get required scopes](https://docs.composio.dev/reference/api-reference/toolkits/recommendToolkitScopes) to resolve the scopes for the tools you need, then pass those scopes in `credentials.scopes`.
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class GetAuthConfigsResponseItemToolAccessConfig
    {
        /// <summary>
        /// Tools used to generate the minimum required scopes for the auth config (only valid for OAuth). If passed, this will update the scopes. DEPRECATED: use [Get required scopes](https://docs.composio.dev/reference/api-reference/toolkits/recommendToolkitScopes) to resolve the scopes for the tools you need, then pass those scopes in `credentials.scopes`.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools_for_connected_account_creation")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? ToolsForConnectedAccountCreation { get; set; }

        /// <summary>
        /// The actions that the user can perform on the auth config. If passed, this will update the actions that the user can perform on the auth config. DEPRECATED: use [Get required scopes](https://docs.composio.dev/reference/api-reference/toolkits/recommendToolkitScopes) to resolve the scopes for the tools you need, then pass those scopes in `credentials.scopes`.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools_available_for_execution")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.IList<string>? ToolsAvailableForExecution { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}