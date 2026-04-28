
#nullable enable

namespace Composio
{
    /// <summary>
    /// Sandbox compute tier: standard (1 vCPU / 1 GB), medium (2 vCPU / 2 GB), large (4 vCPU / 4 GB), xlarge (8 vCPU / 8 GB). Patching this value recreates the sandbox on next access — sandbox FS state is lost, but /mnt/files/ R2 mount persists.<br/>
    /// Example: large
    /// </summary>
    public enum PatchToolRouterSessionBySessionIdRequestWorkbenchSandboxSize
    {
        /// <summary>
        /// standard (1 vCPU / 1 GB), medium (2 vCPU / 2 GB), large (4 vCPU / 4 GB), xlarge (8 vCPU / 8 GB). Patching this value recreates the sandbox on next access — sandbox FS state is lost, but /mnt/files/ R2 mount persists.
        /// </summary>
        Large,
        /// <summary>
        /// standard (1 vCPU / 1 GB), medium (2 vCPU / 2 GB), large (4 vCPU / 4 GB), xlarge (8 vCPU / 8 GB). Patching this value recreates the sandbox on next access — sandbox FS state is lost, but /mnt/files/ R2 mount persists.
        /// </summary>
        Medium,
        /// <summary>
        /// standard (1 vCPU / 1 GB), medium (2 vCPU / 2 GB), large (4 vCPU / 4 GB), xlarge (8 vCPU / 8 GB). Patching this value recreates the sandbox on next access — sandbox FS state is lost, but /mnt/files/ R2 mount persists.
        /// </summary>
        Standard,
        /// <summary>
        /// standard (1 vCPU / 1 GB), medium (2 vCPU / 2 GB), large (4 vCPU / 4 GB), xlarge (8 vCPU / 8 GB). Patching this value recreates the sandbox on next access — sandbox FS state is lost, but /mnt/files/ R2 mount persists.
        /// </summary>
        Xlarge,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchToolRouterSessionBySessionIdRequestWorkbenchSandboxSizeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchToolRouterSessionBySessionIdRequestWorkbenchSandboxSize value)
        {
            return value switch
            {
                PatchToolRouterSessionBySessionIdRequestWorkbenchSandboxSize.Large => "large",
                PatchToolRouterSessionBySessionIdRequestWorkbenchSandboxSize.Medium => "medium",
                PatchToolRouterSessionBySessionIdRequestWorkbenchSandboxSize.Standard => "standard",
                PatchToolRouterSessionBySessionIdRequestWorkbenchSandboxSize.Xlarge => "xlarge",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchToolRouterSessionBySessionIdRequestWorkbenchSandboxSize? ToEnum(string value)
        {
            return value switch
            {
                "large" => PatchToolRouterSessionBySessionIdRequestWorkbenchSandboxSize.Large,
                "medium" => PatchToolRouterSessionBySessionIdRequestWorkbenchSandboxSize.Medium,
                "standard" => PatchToolRouterSessionBySessionIdRequestWorkbenchSandboxSize.Standard,
                "xlarge" => PatchToolRouterSessionBySessionIdRequestWorkbenchSandboxSize.Xlarge,
                _ => null,
            };
        }
    }
}