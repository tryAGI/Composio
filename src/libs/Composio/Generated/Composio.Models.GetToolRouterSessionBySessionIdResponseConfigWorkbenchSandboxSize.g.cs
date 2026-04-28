
#nullable enable

namespace Composio
{
    /// <summary>
    /// Sandbox compute tier: standard (1 vCPU / 1 GB), medium (2 vCPU / 2 GB), large (4 vCPU / 4 GB), xlarge (8 vCPU / 8 GB). Defaults to standard.
    /// </summary>
    public enum GetToolRouterSessionBySessionIdResponseConfigWorkbenchSandboxSize
    {
        /// <summary>
        /// standard (1 vCPU / 1 GB), medium (2 vCPU / 2 GB), large (4 vCPU / 4 GB), xlarge (8 vCPU / 8 GB). Defaults to standard.
        /// </summary>
        Large,
        /// <summary>
        /// standard (1 vCPU / 1 GB), medium (2 vCPU / 2 GB), large (4 vCPU / 4 GB), xlarge (8 vCPU / 8 GB). Defaults to standard.
        /// </summary>
        Medium,
        /// <summary>
        /// standard (1 vCPU / 1 GB), medium (2 vCPU / 2 GB), large (4 vCPU / 4 GB), xlarge (8 vCPU / 8 GB). Defaults to standard.
        /// </summary>
        Standard,
        /// <summary>
        /// standard (1 vCPU / 1 GB), medium (2 vCPU / 2 GB), large (4 vCPU / 4 GB), xlarge (8 vCPU / 8 GB). Defaults to standard.
        /// </summary>
        Xlarge,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetToolRouterSessionBySessionIdResponseConfigWorkbenchSandboxSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetToolRouterSessionBySessionIdResponseConfigWorkbenchSandboxSize value)
        {
            return value switch
            {
                GetToolRouterSessionBySessionIdResponseConfigWorkbenchSandboxSize.Large => "large",
                GetToolRouterSessionBySessionIdResponseConfigWorkbenchSandboxSize.Medium => "medium",
                GetToolRouterSessionBySessionIdResponseConfigWorkbenchSandboxSize.Standard => "standard",
                GetToolRouterSessionBySessionIdResponseConfigWorkbenchSandboxSize.Xlarge => "xlarge",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetToolRouterSessionBySessionIdResponseConfigWorkbenchSandboxSize? ToEnum(string value)
        {
            return value switch
            {
                "large" => GetToolRouterSessionBySessionIdResponseConfigWorkbenchSandboxSize.Large,
                "medium" => GetToolRouterSessionBySessionIdResponseConfigWorkbenchSandboxSize.Medium,
                "standard" => GetToolRouterSessionBySessionIdResponseConfigWorkbenchSandboxSize.Standard,
                "xlarge" => GetToolRouterSessionBySessionIdResponseConfigWorkbenchSandboxSize.Xlarge,
                _ => null,
            };
        }
    }
}