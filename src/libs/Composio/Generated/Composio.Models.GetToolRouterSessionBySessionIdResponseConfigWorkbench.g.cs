
#nullable enable

namespace Composio
{
    /// <summary>
    /// Workbench configuration<br/>
    /// Default Value: {"enable":true,"proxy_execution_enabled":true}
    /// </summary>
    public sealed partial class GetToolRouterSessionBySessionIdResponseConfigWorkbench
    {
        /// <summary>
        /// Whether the workbench (code execution sandbox) is enabled. When false, COMPOSIO_REMOTE_WORKBENCH and COMPOSIO_REMOTE_BASH_TOOL are not exposed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable")]
        public bool? Enable { get; set; }

        /// <summary>
        /// Whether proxy execution is enabled in the workbench
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proxy_execution_enabled")]
        public bool? ProxyExecutionEnabled { get; set; }

        /// <summary>
        /// Character threshold after which tool execution response are saved to a file in workbench. Default is 20k.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_offload_threshold")]
        public double? AutoOffloadThreshold { get; set; }

        /// <summary>
        /// Sandbox compute tier: standard (1 vCPU / 1 GB), medium (2 vCPU / 2 GB), large (4 vCPU / 4 GB), xlarge (8 vCPU / 8 GB). Defaults to standard.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandbox_size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.GetToolRouterSessionBySessionIdResponseConfigWorkbenchSandboxSizeJsonConverter))]
        public global::Composio.GetToolRouterSessionBySessionIdResponseConfigWorkbenchSandboxSize? SandboxSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolRouterSessionBySessionIdResponseConfigWorkbench" /> class.
        /// </summary>
        /// <param name="enable">
        /// Whether the workbench (code execution sandbox) is enabled. When false, COMPOSIO_REMOTE_WORKBENCH and COMPOSIO_REMOTE_BASH_TOOL are not exposed.
        /// </param>
        /// <param name="proxyExecutionEnabled">
        /// Whether proxy execution is enabled in the workbench
        /// </param>
        /// <param name="autoOffloadThreshold">
        /// Character threshold after which tool execution response are saved to a file in workbench. Default is 20k.
        /// </param>
        /// <param name="sandboxSize">
        /// Sandbox compute tier: standard (1 vCPU / 1 GB), medium (2 vCPU / 2 GB), large (4 vCPU / 4 GB), xlarge (8 vCPU / 8 GB). Defaults to standard.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetToolRouterSessionBySessionIdResponseConfigWorkbench(
            bool? enable,
            bool? proxyExecutionEnabled,
            double? autoOffloadThreshold,
            global::Composio.GetToolRouterSessionBySessionIdResponseConfigWorkbenchSandboxSize? sandboxSize)
        {
            this.Enable = enable;
            this.ProxyExecutionEnabled = proxyExecutionEnabled;
            this.AutoOffloadThreshold = autoOffloadThreshold;
            this.SandboxSize = sandboxSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetToolRouterSessionBySessionIdResponseConfigWorkbench" /> class.
        /// </summary>
        public GetToolRouterSessionBySessionIdResponseConfigWorkbench()
        {
        }

    }
}