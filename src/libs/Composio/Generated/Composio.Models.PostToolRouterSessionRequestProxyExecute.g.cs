
#nullable enable

namespace Composio
{
    /// <summary>
    /// Configure proxy execute. Omitted from responses when not set. Session creation fails when enable is false and workbench.enable_proxy_execution is explicitly true.
    /// </summary>
    public sealed partial class PostToolRouterSessionRequestProxyExecute
    {
        /// <summary>
        /// When true, the agent can make authenticated HTTP requests to connected app APIs outside the workbench. When false, proxy execution is also disabled inside the workbench, regardless of workbench.enable_proxy_execution. When not set, proxy execute is disabled outside the workbench.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequestProxyExecute" /> class.
        /// </summary>
        /// <param name="enable">
        /// When true, the agent can make authenticated HTTP requests to connected app APIs outside the workbench. When false, proxy execution is also disabled inside the workbench, regardless of workbench.enable_proxy_execution. When not set, proxy execute is disabled outside the workbench.<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolRouterSessionRequestProxyExecute(
            bool enable)
        {
            this.Enable = enable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequestProxyExecute" /> class.
        /// </summary>
        public PostToolRouterSessionRequestProxyExecute()
        {
        }

    }
}