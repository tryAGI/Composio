
#nullable enable

namespace Composio
{
    /// <summary>
    /// Proxy execute configuration for this session. Omitted when not set.
    /// </summary>
    public sealed partial class GetToolRouterSessionBySessionIdResponseConfigProxyExecute
    {
        /// <summary>
        /// When true, enables proxy execute outside the workbench. When false, also disables proxy execution inside the workbench.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolRouterSessionBySessionIdResponseConfigProxyExecute" /> class.
        /// </summary>
        /// <param name="enable">
        /// When true, enables proxy execute outside the workbench. When false, also disables proxy execution inside the workbench.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetToolRouterSessionBySessionIdResponseConfigProxyExecute(
            bool enable)
        {
            this.Enable = enable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolRouterSessionBySessionIdResponseConfigProxyExecute" /> class.
        /// </summary>
        public GetToolRouterSessionBySessionIdResponseConfigProxyExecute()
        {
        }

    }
}