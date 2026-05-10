
#nullable enable

namespace Composio
{
    /// <summary>
    /// Configuration for workbench behavior<br/>
    /// Default Value: {"enable":true,"enable_proxy_execution":true}
    /// </summary>
    public sealed partial class PostToolRouterSessionRequestWorkbench
    {
        /// <summary>
        /// Set to false to disable the workbench entirely. When disabled, no code execution tools are available in the session.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable")]
        public bool? Enable { get; set; }

        /// <summary>
        /// Whether proxy execution is enabled. When enabled, workbench can call URLs and APIs directly.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_proxy_execution")]
        public bool? EnableProxyExecution { get; set; }

        /// <summary>
        /// Character threshold for automatic offloading. When workbench response exceeds this threshold, it will be automatically offloaded. Default is picked automatically based on the response size.<br/>
        /// Example: 20000
        /// </summary>
        /// <example>20000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_offload_threshold")]
        public double? AutoOffloadThreshold { get; set; }

        /// <summary>
        /// Sandbox compute tier: standard (1 vCPU / 1 GB), medium (2 vCPU / 2 GB), large (4 vCPU / 4 GB), xlarge (8 vCPU / 8 GB). Defaults to standard.<br/>
        /// Default Value: standard<br/>
        /// Example: standard
        /// </summary>
        /// <example>standard</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandbox_size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Composio.JsonConverters.PostToolRouterSessionRequestWorkbenchSandboxSizeJsonConverter))]
        public global::Composio.PostToolRouterSessionRequestWorkbenchSandboxSize? SandboxSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequestWorkbench" /> class.
        /// </summary>
        /// <param name="enable">
        /// Set to false to disable the workbench entirely. When disabled, no code execution tools are available in the session.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="enableProxyExecution">
        /// Whether proxy execution is enabled. When enabled, workbench can call URLs and APIs directly.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="autoOffloadThreshold">
        /// Character threshold for automatic offloading. When workbench response exceeds this threshold, it will be automatically offloaded. Default is picked automatically based on the response size.<br/>
        /// Example: 20000
        /// </param>
        /// <param name="sandboxSize">
        /// Sandbox compute tier: standard (1 vCPU / 1 GB), medium (2 vCPU / 2 GB), large (4 vCPU / 4 GB), xlarge (8 vCPU / 8 GB). Defaults to standard.<br/>
        /// Default Value: standard<br/>
        /// Example: standard
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolRouterSessionRequestWorkbench(
            bool? enable,
            bool? enableProxyExecution,
            double? autoOffloadThreshold,
            global::Composio.PostToolRouterSessionRequestWorkbenchSandboxSize? sandboxSize)
        {
            this.Enable = enable;
            this.EnableProxyExecution = enableProxyExecution;
            this.AutoOffloadThreshold = autoOffloadThreshold;
            this.SandboxSize = sandboxSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolRouterSessionRequestWorkbench" /> class.
        /// </summary>
        public PostToolRouterSessionRequestWorkbench()
        {
        }

    }
}