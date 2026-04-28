
#nullable enable

namespace Composio
{
    /// <summary>
    /// Sandbox compute tier: standard (1 vCPU / 1 GB), medium (2 vCPU / 2 GB), large (4 vCPU / 4 GB), xlarge (8 vCPU / 8 GB). Defaults to standard.
    /// </summary>
    public enum PatchToolRouterSessionBySessionIdResponseConfigWorkbenchSandboxSize
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
    public static class PatchToolRouterSessionBySessionIdResponseConfigWorkbenchSandboxSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchToolRouterSessionBySessionIdResponseConfigWorkbenchSandboxSize value)
        {
            return value switch
            {
                PatchToolRouterSessionBySessionIdResponseConfigWorkbenchSandboxSize.Large => "large",
                PatchToolRouterSessionBySessionIdResponseConfigWorkbenchSandboxSize.Medium => "medium",
                PatchToolRouterSessionBySessionIdResponseConfigWorkbenchSandboxSize.Standard => "standard",
                PatchToolRouterSessionBySessionIdResponseConfigWorkbenchSandboxSize.Xlarge => "xlarge",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchToolRouterSessionBySessionIdResponseConfigWorkbenchSandboxSize? ToEnum(string value)
        {
            return value switch
            {
                "large" => PatchToolRouterSessionBySessionIdResponseConfigWorkbenchSandboxSize.Large,
                "medium" => PatchToolRouterSessionBySessionIdResponseConfigWorkbenchSandboxSize.Medium,
                "standard" => PatchToolRouterSessionBySessionIdResponseConfigWorkbenchSandboxSize.Standard,
                "xlarge" => PatchToolRouterSessionBySessionIdResponseConfigWorkbenchSandboxSize.Xlarge,
                _ => null,
            };
        }
    }
}